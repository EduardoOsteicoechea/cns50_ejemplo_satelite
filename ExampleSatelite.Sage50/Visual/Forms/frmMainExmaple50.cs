using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Sage50
using sage.ew.global;

using ExampleSatelite.Sage50.Negocio;
using ExampleSatelite.Sage50.AvantLeap.SalesBill;
using ExampleSatelite.Sage50.AvantLeap.PaymentBill;
using ExampleSatelite.Sage50.AvantLeap.PurchaseBill;
using ExampleSatelite.Sage50.AvantLeap.ChargeAction;
using ExampleSatelite.Sage50.AvantLeap.PayAction;

namespace ExampleSatelite.Sage50.Visual.Forms
{
    public partial class frmMainExmaple50 : Form
    {
        public frmMainExmaple50()
        {
            InitializeComponent();
            _PresentarDatosSage50();
        }

        public void _PresentarDatosSage50()
        {
            string lsEmpresa = EW_GLOBAL._GetVariable("wc_Empresa").ToString();
            string lsEmpresaNombre = "";

            Company loObj = new Company();
            DataRow loRow = loObj._RowValue("nombre", "codigo='"+ lsEmpresa + "' ");
            lsEmpresaNombre = loRow["nombre"].ToString();
            loRow = null;

            this.lblValEmpresa.Text = lsEmpresa + " - " + lsEmpresaNombre;
            this.lblValEjercicio.Text = EW_GLOBAL._GetVariable("wc_Any").ToString();
            this.lblValUsuario.Text = EW_GLOBAL._GetVariable("wc_Usuario").ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            frmCliente loForm = new frmCliente();
            loForm.ShowDialog();
            loForm = null;
        }

        private void cmdArticulo_Click(object sender, EventArgs e)
        {
            frmArticulo loForm = new frmArticulo();
            loForm.ShowDialog();
            loForm = null;
        }

        private void cmdPedidoVenta_Click(object sender, EventArgs e)
        {
            frmPedidoVenta loForm = new frmPedidoVenta();
            loForm.ShowDialog();
            loForm = null;
        }

        private void cmdAlbaranVenta_Click(object sender, EventArgs e)
        {

            EjemploAlbaranxCode loEjemploAlb = new EjemploAlbaranxCode();
            loEjemploAlb._CrearEjemploAlbaran();
            loEjemploAlb = null;
            MessageBox.Show("Proceso Finalizado - Crear Albarán de Venta");
        }

        private void cmdAlbaranCompra_Click(object sender, EventArgs e)
        {
            EjemploAlbacomxCode loEjemploAlb = new EjemploAlbacomxCode();
            loEjemploAlb._CrearEjemploAlbaran();
            loEjemploAlb = null;
            MessageBox.Show("Proceso Finalizado - Crear Albarán de Compra");
        }

        // Key Elements
        // Key Elements
        // Key Elements
        // Key Elements
        // Key Elements

        private void cmdCrearFacturaVenta_Click(object sender, EventArgs e)
        {
            //string Error = string.Empty;
            //EjemploAsientos loEjemploAsi = new EjemploAsientos();
            //loEjemploAsi.GenerarFacturasVentas();
            //Error = loEjemploAsi._Error();
            //loEjemploAsi = null;
            //MessageBox.Show("Proceso Finalizado - Crear Factura de Venta - Contabilidad " + Error);
            new CreateSalesBillCommand();
            string errorMessage = SalesBillValueHolder._Error_Message == "" ? "" : "\n\nERROR: \n" + SalesBillValueHolder._Error_Message;
            MessageBox.Show("Proceso Finalizado - Crear Factura de Compra - Contabilidad " + errorMessage);
            SalesBillValueHolder.ResetVariables();
        }

        private void cmdCrearFacturaCompra_Click(object sender, EventArgs e)
        {
            //string Error = string.Empty;
            EjemploAsientos loEjemploAsi = new EjemploAsientos();
            loEjemploAsi.GenerarFacturasCompras();
            //Error = loEjemploAsi._Error();
            //loEjemploAsi = null;
            //MessageBox.Show("Proceso Finalizado - Crear Factura de Compra - Contabilidad " + Error);
            //MessageBox.Show("cmdCrearFacturaCompra_Click");
            new CreatePurchaseBillCommand();
            string errorMessage = PurchaseBillValueHolder._Error_Message == "" ? "" : "\n\nERROR: \n" + PurchaseBillValueHolder._Error_Message;
            MessageBox.Show("Proceso Finalizado - Crear Factura de Compra - Contabilidad " + errorMessage);
            PurchaseBillValueHolder.ResetVariables();
        }

        private void cmdCobro_Click(object sender, EventArgs e)
        {
            //string error = string.Empty;
            //EjemploAsientos loEjemploAsi = new EjemploAsientos();
            //loEjemploAsi.GenerarCobroFactura();
            //error = loEjemploAsi._Error();
            //loEjemploAsi = null;
            //MessageBox.Show("proceso finalizado - crear cobro de factura - contabilidad " + error);
            //MessageBox.Show("cmdCrearFacturaCompra_Click");
            new ExecuteChargeActionCommand();
            string errorMessage = ChargeActionValueHolder._Error_Message == "" ? "" : "\n\nERROR: \n" + ChargeActionValueHolder._Error_Message;
            MessageBox.Show("Proceso Finalizado - Crear Factura de Compra - Contabilidad " + errorMessage);
            ChargeActionValueHolder.ResetVariables();
        }

        private void cmdPago_Click(object sender, EventArgs e)
        {
            //string Error = string.Empty;
            //EjemploAsientos loEjemploAsi = new EjemploAsientos();
            //loEjemploAsi.GenerarPagoFactura();
            //Error = loEjemploAsi._Error();
            //loEjemploAsi = null;
            //MessageBox.Show("Proceso Finalizado - Crear Cobro de Pago - Contabilidad " + Error);
            //MessageBox.Show("cmdPago_Click");
            new ExecutePayActionCommand();
            string errorMessage = PayActionValueHolder._Error_Message == "" ? "" : "\n\nERROR: \n" + PayActionValueHolder._Error_Message;
            MessageBox.Show("Proceso Finalizado - Crear Factura de Compra - Contabilidad " + errorMessage);
            PayActionValueHolder.ResetVariables();
        }

        // Key Elements
        // Key Elements
        // Key Elements
        // Key Elements
        // Key Elements

        private void cmdFacturaVentaDirecta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cmdFacturaVentaDirecta_Click");
            EjemploFacturaVentaDirectaxCode loEjemploFac = new EjemploFacturaVentaDirectaxCode();
            loEjemploFac._CrearEjemploFacturaDirecta();
            loEjemploFac = null;
            MessageBox.Show("Proceso Finalizado - Crear Factura de Venta");
        }

        private void cmdImprimirFacturaVenta_Click(object sender, EventArgs e)
        {
            EjemploFacturaventaxCode loEjemploFac = new EjemploFacturaventaxCode();
            loEjemploFac._ImprimirFactura();
            loEjemploFac = null;
            MessageBox.Show("Proceso Finalizado - Imprimir Factura de Venta");
        }
    }
}
