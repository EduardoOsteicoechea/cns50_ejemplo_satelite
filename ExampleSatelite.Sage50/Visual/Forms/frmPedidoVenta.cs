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
using sage.ew.global;
using sage.ew.global.Diccionarios;
using sage.ew.cliente;
using sage.ew.articulo;
using sage.ew.docsven;

//propio
using ExampleSatelite.Sage50.Negocio;
using ExampleSatelite.Sage50.Datos;

namespace ExampleSatelite.Sage50.Visual.Forms
{
    public partial class frmPedidoVenta : Form
    {
        PedidoVenta _oPedidoVenta = new PedidoVenta();
        public dynamic _oEntidad;

        private int _nDigitos = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));
        private int _nArticulo = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_articulo));

        private Boolean _NuevoPedido = false;
        private string _Letra = string.Empty;
        private string _Numero = string.Empty;
        private string _Almacen = EW_GLOBAL._GetVariable("wc_almacen").ToString();

        private clsPedivenLineas _LinPedido = new clsPedivenLineas();

        public frmPedidoVenta()
        {
            InitializeComponent();

            this.textBox1.MaxLength = _nDigitos;
            this.textBox7.MaxLength = _nArticulo;
            this.textBox8.MaxLength = 50;
            _CrearEntidad();
            _CrearObjetoLinea();
            _ControlesPedido();
            Refresh();
            _ControlesPedido(false);
            textBox6.Text = "SF";
            textBox2.Focus();

        }

        private void _CrearEntidad()
        {
            _oEntidad = new clsPediven();
            _oEntidad.Cabecera.letra = "SF";
        }

        private void _CrearObjetoLinea()
        {
            _LinPedido = new clsPedivenLineas();
            _LinPedido.articulo = "";
            _LinPedido.definicion = "";
            _LinPedido.unidades = 0;
            _LinPedido.precio = 0;
            _LinPedido.dto1 = 0;
            _LinPedido.dto2 = 0;
            _LinPedido.tipoiva = "";
        }

        private void _ControlesPedido(bool tlBloquear = false)
        {
            textBox6.Enabled = !tlBloquear;
            textBox2.Enabled = !tlBloquear;

            textBox5.Enabled = tlBloquear;
            textBox1.Enabled = tlBloquear;
            textBox4.Enabled = false;
            textBox3.Enabled = false;

            textBox7.Enabled = tlBloquear;
            textBox8.Enabled = tlBloquear;
            textBox9.Enabled = tlBloquear;

            spnUnidades.Enabled = tlBloquear;
            spnPrecio.Enabled = tlBloquear;
            spnDto1.Enabled = tlBloquear;
            spnDto2.Enabled = tlBloquear;
            spnImporte.Enabled = false;

            btnGrabar.Enabled = tlBloquear;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            _NuevoPedido = false;

            string lsmensaje = "¿Desea Crear un pedido de venta?";
            string lsNumero = string.Empty, lsLetra = string.Empty;

            lsNumero = textBox2.Text.Trim().PadLeft(10, ' '); 
            lsLetra = textBox6.Text.Trim().PadLeft(2, ' ');

            if (!string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                DialogResult loResp = MessageBox.Show(lsmensaje, "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (loResp == DialogResult.Yes)
                {
                    _NuevoPedido = true;
                    _ControlesPedido(true);
                    _oEntidad.Cabecera.almacen = _Almacen;
                }
                else
                {
                    this._Letra = string.Empty;
                    this._Numero = string.Empty;

                    _CrearEntidad();
                    _CrearObjetoLinea();
                    _ControlesPedido(false);
                    textBox2.Focus();
                }

                Refresh();
            }
            else
            {
                if ((!string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox2.Text)) && (this._Letra != textBox6.Text.Trim() || this._Numero != textBox2.Text.Trim()))
                {
                    if (_oPedidoVenta._Exist(lsNumero, lsLetra))
                    {
                        _oEntidad = _oPedidoVenta._LoadEntity(lsNumero, lsLetra);

                        this._Letra = lsLetra;
                        this._Numero = lsNumero;
                        _ControlesPedido(true);
                    }
                    else
                    {
                        MessageBox.Show("El pedido no existe.", "Grabar Pedido");
                        this._Letra = string.Empty;
                        this._Numero = string.Empty;

                        _CrearEntidad();
                        _CrearObjetoLinea();
                        _ControlesPedido(false);
                        textBox2.Focus();
                    }

                    Refresh();
                }
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            _Binding();
            _ReferscarGridPedido();
        }

        private void _Binding()
        {
            // cabecera
            this._DataBindinAdd(textBox6, "Text", _oEntidad.Cabecera, "letra", true);
            this._DataBindinAdd(textBox2, "Text", _oEntidad.Cabecera, "numero", true);
            this._DataBindinAdd(textBox5, "Text", _oEntidad.Cabecera, "almacen", true);
            this._DataBindinAdd(textBox1, "Text", _oEntidad.Cabecera, "cliente", true);
            this._DataBindinAdd(textBox4, "Text", _oEntidad.Cabecera, "nombre", true);

            this._DataBindinAdd(textBox3, "Text", _oEntidad.Direccion, "direccion", true);

            // Objeto Linea local
            _BindingObjetoLinea();

        }

        private void _BindingObjetoLinea()
        {
            // Objeto Linea local
            this._DataBindinAdd(textBox7, "Text", _LinPedido, "articulo", true);
            this._DataBindinAdd(textBox8, "Text", _LinPedido, "definicion", true);
            this._DataBindinAdd(textBox9, "Text", _LinPedido, "tipoiva", true);

            this._DataBindinAdd(spnUnidades, "Text", _LinPedido, "unidades", true);
            this._DataBindinAdd(spnPrecio, "Text", _LinPedido, "precio", true);
            this._DataBindinAdd(spnDto1, "Text", _LinPedido, "dto1", true);
            this._DataBindinAdd(spnDto2, "Text", _LinPedido, "dto2", true);
        }

        public void _DataBindinAdd(dynamic toObjeto, string tcPropiedad, dynamic toDataSource, string tcDataMember, Boolean tlFormattingEnabled = false)
        {
            toObjeto.DataBindings.Clear();
            if (toObjeto.DataBindings[tcPropiedad] != null)
                toObjeto.DataBindings[0].ReadValue();
            else
                toObjeto.DataBindings.Add(tcPropiedad, toDataSource, tcDataMember, tlFormattingEnabled);
        }


        private void _ReferscarGridPedido()
        {
            dataGridView1.DataSource = "";
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = _oEntidad.Lineas;

            //if (dataGridView1.RowCount > 0)
            //    dataGridView1.Rows[0].Cells[0].Selected = true;
                
            dataGridView1.Refresh();
        }

        private void btnAceptarLinea_Click(object sender, EventArgs e)
        {
            int lnLinea = 0;
            
            // Buscamos el número maximo de la linea, para asignar el nuevo
            if (_oEntidad.Lineas != null && _oEntidad.Lineas.Count != 0)
                lnLinea = ((List<clsPedivenLineas>)((clsPediven)_oEntidad).Lineas).Max(x => x.linea);

            lnLinea++;

            _LinPedido.linea = lnLinea;

            //if (_LinPedido.unidades == 0)
            //    System.Diagnostics.Debugger.Launch();

            _oEntidad.Lineas.Add(_LinPedido);
            
            _ReferscarGridPedido();
            btnNuevaLinea_Click(sender, e);

        }

        private void btnNuevaLinea_Click(object sender, EventArgs e)
        {
            this._CrearObjetoLinea();
            this._BindingObjetoLinea();
            textBox7.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _CrearEntidad();
            _CrearObjetoLinea();
            _ControlesPedido(false);
            Refresh();
            textBox2.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Boolean llOk = false;
            string lsMensajeOk = string.Empty;
            if (_NuevoPedido)
            {
                llOk = this._oPedidoVenta._Create(this._oEntidad);
                lsMensajeOk = "Se ha creado el pedido " + this._oEntidad.Cabecera.letra + "/" + this._oEntidad.Cabecera.numero;
            }
            else
            {
                llOk = this._oPedidoVenta._Update(this._oEntidad);
                lsMensajeOk = "Se ha actualizado el pedido " + this._oEntidad.Cabecera.letra + "/" + this._oEntidad.Cabecera.numero;
            }

            if (llOk)
                MessageBox.Show(lsMensajeOk, "Grabar Pedido");
            else
                MessageBox.Show("No se ha podido grabar el pedido\r\n Verifique: "+ this._oPedidoVenta._Error_Message.Trim(), "Grabar Pedido");

            _CrearEntidad();
            _CrearObjetoLinea();
            _ControlesPedido(false);
            Refresh();
            textBox2.Focus();

        }

        private void textBox7_Validated(object sender, EventArgs e)
        {
            string lsArticulo = string.Empty;

            lsArticulo = textBox7.Text.Trim().PadRight(_nArticulo, ' ');

            if (!string.IsNullOrEmpty(textBox7.Text))
            {
                Product loProduct = new Product();
                dynamic loeProduct = new clsEntityProduct();
                loeProduct.codigo = lsArticulo;

                loProduct._Load(ref loeProduct);

                if (loeProduct.existeregistro)
                {
                    _LinPedido.articulo = loeProduct.codigo;
                    _LinPedido.definicion = loeProduct.nombre;
                    _LinPedido.tipoiva = loeProduct.tipo_iva;
                    _LinPedido.unidades = 1;
                    _ObtenerPrecio();
                    _Calcular_Importe();
                }
                else
                {
                    _LinPedido.articulo = "";
                    _LinPedido.definicion = "";
                    _LinPedido.unidades = 0;
                    _LinPedido.precio = 0;
                    _LinPedido.dto1 = 0;
                    _LinPedido.dto2 = 0;
                    _LinPedido.tipoiva = "";
                }

                _BindingObjetoLinea();
            }
        }

        private void spnUnidades_Validated(object sender, EventArgs e)
        {
            _ObtenerPrecio();
            _Calcular_Importe();
        }

        private void spnPrecio_Validated(object sender, EventArgs e)
        {
            _Calcular_Importe();
        }

        private void spnDto1_Validated(object sender, EventArgs e)
        {
            _Calcular_Importe();
        }

        private void spnDto2_Validated(object sender, EventArgs e)
        {
            _Calcular_Importe();
        }

        private void _Calcular_Importe()
        {
            decimal lnImporte = 0M;

            lnImporte = _DescuentoLineal(_LinPedido.unidades * _LinPedido.precio, _LinPedido.dto1, _LinPedido.dto2);
            lnImporte = EW_GLOBAL._Moneda._MascaraImporte.Redondeo(lnImporte);

            spnImporte.Value = lnImporte;
        }

        // método que se encargar de obtener el precio de Sage50, segun las condiciones de clientes, articulos, fecha, unidades, moneda
        // regresa un datatable con los precios, y otro si ubiera articulos regalos/ofertas
        private void _ObtenerPrecio()
        {
            Cliente loCliente = new Cliente(_oEntidad.Cabecera.cliente);
            Articulo loArticulo = new Articulo(_LinPedido.articulo, _LinPedido.talla, _LinPedido.color);
            DataTable ldPrecios = new DataTable(), ldRegalo = new DataTable();

            _oPedidoVenta._ObtenerPrecio(loCliente, loArticulo, _oEntidad.Cabecera.fecha, ref ldPrecios, ref ldRegalo, _oPedidoVenta._Moneda,
                _LinPedido.unidades, "", _LinPedido.talla, _LinPedido.color);

            if (ldPrecios.Rows.Count > 0)
            {
                DataRow loRow = ldPrecios.Rows[0];
                _LinPedido.precio = (decimal)loRow["precio"];
                _LinPedido.dto1 = (decimal)loRow["dto1"];
                _LinPedido.dto2 = (decimal)loRow["dto2"];
                loRow = null;
            }

            loCliente = null;
            loArticulo = null;
            ldPrecios.Dispose();
            ldRegalo.Dispose();
        }

        // Método que se encargar de realizar el calculo del importe lineal, como lo hace Sage50
        private decimal _DescuentoLineal(decimal tnImporte, decimal tnDto1 = 0, decimal tnDto2 = 0, decimal tnDto3_Imp = 0, decimal tnDto4 = 0, decimal tnDto5 = 0, decimal tnDto6 = 0, decimal tnDto7 = 0, bool tlEsDivisa = false)
        {
            return EW_PRECIOS._Descuento_Lineal(tnImporte, tnDto1, tnDto2, tnDto3_Imp, tnDto4, tnDto5, tnDto6, tnDto7, EW_GLOBAL._Moneda);
        }
    }
}
