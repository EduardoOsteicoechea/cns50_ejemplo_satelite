using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Sage50
using sage.ew.cliente;
//
using ExampleSatelite.Sage50.Negocio;
using ExampleSatelite.Sage50.Datos;

namespace ExampleSatelite.Sage50.Visual.Forms
{
    public partial class frmCliente : Form
    {

        Customer _oCustomer = new Customer();

        public dynamic _oEntidad;

        private bool EditandoFicha = false;
        private bool NuevaFicha = false;

        private int _nDigitos = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo("wn_digitos"));

        public frmCliente()
        {
            _CrearEntidad();
            
            InitializeComponent();

            this.panelTabla.Visible = false;
            this.panelFicha.Visible = false;
            this.textBox1.MaxLength = _nDigitos;

            _Binding();
        }

        private void _CrearEntidad()
        {
            _oEntidad = new clsEntityCustomer();
        }
        
        

        private void btnDatosCliente_Click(object sender, EventArgs e)
        {
            _Opcion(1);
        }

        private void btnFichaCliente_Click(object sender, EventArgs e)
        {
            _Opcion(2);
        }

        private void _Opcion(int tnOpcion)
        {
            switch (tnOpcion)
            {
                case 1:
                    panelFicha.Visible = false;
                    if (this.panelTabla.Visible == false)
                    {
                        this.panelTabla.Location = new System.Drawing.Point(162, 12);
                        this.panelTabla.Size = new System.Drawing.Size(718, 507);
                        this.panelTabla.Visible = true;
                    }
                    else
                    {
                        this.panelTabla.Visible = false;
                    }

                    break;
                case 2:
                    this.panelTabla.Visible = false;
                    if (this.panelFicha.Visible == false)
                    {
                        this.panelFicha.Location = new System.Drawing.Point(162, 12);
                        this.panelFicha.Size = new System.Drawing.Size(718, 507);
                        this.panelFicha.Visible = true;
                        _ControlesFicha();
                    }
                    else
                    {
                        this.panelFicha.Visible = false;
                    }
                    break;

                default:
                    break;
            }
        }

        private void cmdRefrescar_Click(object sender, EventArgs e)
        {

            string lsWhere = "", lsSelect = "";
            DataTable loData = new DataTable();

            lsSelect = this.txtSelect.Text.Trim();
            lsWhere = this.txtWhere.Text.Trim();

            loData = _oCustomer._LoadTable(lsWhere, lsSelect);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = loData;
            dataGridView1.Refresh();

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            string lsmensaje = "Codigo de cliente no existe\r\n¿Desea Crear un cliente nuevo?";

            bool llOk = false;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                _oEntidad.codigo = textBox1.Text.Trim();
                llOk = _oCustomer._Load(ref _oEntidad);

                if (llOk == false)
                {
                    MessageBox.Show(_oCustomer._Error_Message);

                    NuevaFicha = true;
                    EditandoFicha = false;
                    _CrearEntidad();
                    spnLimiteCredito.Value = 0;
                }
                else
                {
                    if (!_oEntidad.existeregistro)
                    {
                        DialogResult loResp = MessageBox.Show(lsmensaje, "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (loResp == DialogResult.Yes)
                        {
                            EditandoFicha = true;
                            _ControlesFicha(true);
                            btnFichaEditarAceptar.Text = "Aceptar";
                            textBox7.Focus();
                        }
                        else
                        {
                            _CrearEntidad();
                        }
                        spnLimiteCredito.Value = 0;
                        NuevaFicha = true;
                    }
                    else
                    {
                        NuevaFicha = false;
                        spnLimiteCredito.Value = _oCustomer._Obtener_LimiteCredito(_oEntidad.codigo);
                    }
                }
            }

            this.Refresh();
        }


        public override void Refresh()
        {
            base.Refresh();
            _Binding();
        }

        private void _Binding()
        {
            this._DataBindinAdd(textBox1, "Text", _oEntidad, "codigo", true);
            this._DataBindinAdd(textBox2, "Text", _oEntidad, "nombre", true);
            this._DataBindinAdd(textBox3, "Text", _oEntidad, "direccion", true);
            this._DataBindinAdd(textBox4, "Text", _oEntidad, "telefono", true);
            this._DataBindinAdd(textBox5, "Text", _oEntidad, "codpos", true);
            this._DataBindinAdd(textBox6, "Text", _oEntidad, "tipo_iva", true);
            this._DataBindinAdd(textBox7, "Text", _oEntidad, "cif", true);
        }


        private void _ControlesFicha(bool tlBloquear = false)
        {
            this.textBox1.Enabled = !tlBloquear;
            this.textBox2.Enabled = tlBloquear;
            this.textBox3.Enabled = tlBloquear;
            this.textBox4.Enabled = tlBloquear;
            this.textBox5.Enabled = tlBloquear;
            this.textBox6.Enabled = tlBloquear;
            this.textBox7.Enabled = tlBloquear;

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
                        _oCustomer._Create(_oEntidad);
                    }
                    else
                    {
                        _oCustomer._Update(_oEntidad);
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
                    textBox7.Focus();
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
            string lsmensaje = "¿Está seguro de borrar este cliente?";

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult loResp = MessageBox.Show(lsmensaje, "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (loResp == DialogResult.Yes)
                {
                    bool llOk = _oCustomer._Delete(_oEntidad);

                    if (!llOk)
                        MessageBox.Show(_oCustomer._Error_Message);

                    NuevaFicha = true;
                    EditandoFicha = false;
                    _CrearEntidad();

                    _ControlesFicha(false);

                    textBox1.Focus();
                }
            }
        }
    }
}
