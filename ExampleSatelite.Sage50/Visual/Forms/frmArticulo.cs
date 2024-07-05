using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

// Sage50
using sage.ew.articulo;
using sage.ew.global.Diccionarios;
//
using ExampleSatelite.Sage50.Negocio;
using ExampleSatelite.Sage50.Datos;


namespace ExampleSatelite.Sage50.Visual.Forms
{
    public partial class frmArticulo : Form
    {

        Product _oProduct = new Product();

        public dynamic _oEntidad;

        private bool EditandoFicha = false;
        private bool NuevaFicha = false;

        private int _nArticulo = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_articulo));
        private int _nFamilia = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_familia));
        private int _nSubFamilia = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_subfamilia));
        private int _nMarca = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_marcas));

        private string _codigo = string.Empty;

        public frmArticulo()
        {
            _CrearEntidad();
            
            InitializeComponent();
            this.textBox1.MaxLength = _nArticulo;
            this.textBox3.MaxLength = _nFamilia;
            this.textBox4.MaxLength = _nSubFamilia;
            this.textBox5.MaxLength = _nMarca;

            _ControlesFicha(false);
            _Binding();
        }

        private void _CrearEntidad()
        {
            _oEntidad = new clsEntityProduct();
        }
        

        private void cmdRefrescar_Click(object sender, EventArgs e)
        {

            string lsWhere = "", lsSelect = "";
            DataTable loData = new DataTable();

            lsSelect = this.txtSelect.Text.Trim();
            lsWhere = this.txtWhere.Text.Trim();

            loData = _oProduct._LoadTable(lsWhere, lsSelect);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = loData;
            dataGridView1.Refresh();

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            string lsmensaje = "Codigo de artículo no existe\r\n¿Desea Crear un artículo nuevo?";

            bool llOk = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && this._codigo != textBox1.Text.Trim())
            {
                _oEntidad.codigo = textBox1.Text.Trim();
                llOk = _oProduct._Load(ref _oEntidad);

                if (llOk == false)
                {
                    MessageBox.Show(_oProduct._Error_Message);

                    NuevaFicha = true;
                    EditandoFicha = false;
                    _CrearEntidad();
                    this._codigo = string.Empty;
                }
                else
                {
                    if (!_oEntidad.existeregistro)
                    {
                        DialogResult loResp = MessageBox.Show(lsmensaje, "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (loResp == DialogResult.Yes)
                        {
                            this._codigo = _oEntidad.codigo;
                            EditandoFicha = true;
                            _ControlesFicha(true);
                            btnFichaEditarAceptar.Text = "Aceptar";
                            textBox2.Focus();
                        }
                        else
                        {
                            _CrearEntidad();
                            this._codigo = string.Empty;
                        }
                        NuevaFicha = true;
                    }
                    else
                    {
                        NuevaFicha = false;
                        this._codigo = _oEntidad.codigo;
                    }
                }

                this.Refresh();
            }
        }


        public override void Refresh()
        {
            base.Refresh();
            _Binding();
            _ReferscarGridFicha();

            lblNomFamilia.Text = string.Empty;
            lblNomSubFamilia.Text = string.Empty;
            lblNomMarca.Text = string.Empty;
        }

        private void _Binding()
        {
            this._DataBindinAdd(textBox1, "Text", _oEntidad, "codigo", true);
            this._DataBindinAdd(textBox2, "Text", _oEntidad, "nombre", true);
            this._DataBindinAdd(textBox3, "Text", _oEntidad, "familia", true);
            this._DataBindinAdd(textBox4, "Text", _oEntidad, "subfamilia", true);
            this._DataBindinAdd(textBox5, "Text", _oEntidad, "marca", true);
            this._DataBindinAdd(textBox6, "Text", _oEntidad, "tipo_iva", true);
            this._DataBindinAdd(spnUltimoCoste, "Value", _oEntidad, "ultimocoste", true);
        }

        private void _ReferscarGridFicha()
        {
            dataGridViewTarifas.Columns.Clear();
            dataGridViewTarifas.DataSource = _oEntidad.precios;
            dataGridViewTarifas.Refresh();

            dataGridViewStock.Columns.Clear();
            dataGridViewStock.DataSource = _oEntidad.stocks;
            dataGridViewTarifas.Refresh();

        }

        private void _ControlesFicha(bool tlBloquear = false)
        {
            this.textBox1.Enabled = !tlBloquear;
            this.textBox2.Enabled = tlBloquear;
            this.textBox3.Enabled = tlBloquear;
            this.textBox4.Enabled = tlBloquear;
            this.textBox5.Enabled = tlBloquear;
            this.textBox6.Enabled = tlBloquear;
            this.spnUltimoCoste.Enabled = false;

            this.btnBorrar.Enabled = !tlBloquear;
        }


        public void _DataBindinAdd(dynamic toObjeto, string tcPropiedad, dynamic toDataSource, string tcDataMember, Boolean tlFormattingEnabled = false)
        {
            toObjeto.DataBindings.Clear();
            if (toObjeto.DataBindings[tcPropiedad] != null)
                toObjeto.DataBindings[0].ReadValue();
            else
                toObjeto.DataBindings.Add(tcPropiedad, toDataSource, tcDataMember, tlFormattingEnabled);
        }

        private void btnFichaEditarAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (EditandoFicha)
                {
                    if (NuevaFicha)
                    {
                        _oProduct._Create(_oEntidad);
                    }
                    else
                    {
                        _oProduct._Update(_oEntidad);
                    }
                    btnFichaEditarAceptar.Text = "Editar";
                    _ControlesFicha(false);
                    EditandoFicha = false;
                    textBox1.Focus();
                }
                else
                {
                    EditandoFicha = true;
                    _ControlesFicha(true);
                    btnFichaEditarAceptar.Text = "Aceptar";
                    textBox2.Focus();
                }
            }
        }

        private void btnFichaCancelar_Click(object sender, EventArgs e)
        {
            NuevaFicha = true;
            EditandoFicha = false;
            btnFichaEditarAceptar.Text = "Editar";
            _ControlesFicha(false);
            textBox1.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string lsmensaje = "¿Está seguro de borrar este artículo?";

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult loResp = MessageBox.Show(lsmensaje, "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (loResp == DialogResult.Yes)
                {
                    bool llOk = _oProduct._Delete(_oEntidad);

                    if (!llOk)
                        MessageBox.Show(_oProduct._Error_Message);

                    NuevaFicha = true;
                    EditandoFicha = false;
                    _CrearEntidad();
                    _ControlesFicha(false);
                    this._codigo = string.Empty;
                    this.Refresh();
                    this.textBox1.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
