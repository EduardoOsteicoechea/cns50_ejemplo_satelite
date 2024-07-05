using ExampleSatelite.Sage50.AvantLeap.Styles;
using sage.ew.ewbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleSatelite.Sage50.AvantLeap.CommonControl;

namespace ExampleSatelite.Sage50.AvantLeap.PurchaseBill
{
    internal class FormBottom : System.Windows.Forms.Panel
    {
        public System.Windows.Forms.Form ParentForm { get; set; }
        public FieldsPanel FieldsPanel { get; set; }
        public FormBottom(System.Windows.Forms.Form parentForm, FieldsPanel fieldsPanel)
        {
            ParentForm = parentForm;
            FieldsPanel = fieldsPanel;
            this.Width = Convert.ToInt32(Math.Round((double)(EOStyles.FormWidth * .965)));
            this.Height = Convert.ToInt32(Math.Round((double)(EOStyles.FormHeight * .12)));
            this.Location = new System.Drawing.Point(-2, fieldsPanel.Bottom);
            //this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoScroll = true;
            this.BackColor = EOStyles.c_transparent;

            System.Windows.Forms.Button CreateBillButton = new System.Windows.Forms.Button();
            CreateBillButton.Text = "Crear factura";
            CreateBillButton.Width = EOStyles.ControlFullWidth / 2;
            CreateBillButton.Height = 35;
            CreateBillButton.Location = new System.Drawing.Point(EOStyles.Column1Left * 15, 20);
            CreateBillButton.Font = EOStyles.GlobalFont3;
            CreateBillButton.BackColor = EOStyles.c_blue_1;
            CreateBillButton.ForeColor = EOStyles.c_white;
            CreateBillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            CreateBillButton.Click += CreateBillButton_Click;
            this.Controls.Add(CreateBillButton);

            parentForm.Controls.Add(this);
        }

        private void CreateBillButton_Click(object sender, EventArgs e) 
        {
            PurchaseBillValueHolder._Proveedor = FieldsPanel._Proveedor.Text;
            PurchaseBillValueHolder._FechaAsiento = FieldsPanel._FechaAsiento.Value;
            PurchaseBillValueHolder._FechaFactura = FieldsPanel._FechaFactura.Value;
            PurchaseBillValueHolder._Factura = FieldsPanel._Factura.Text;
            PurchaseBillValueHolder._Divisa = FieldsPanel._Divisa.Text;
            PurchaseBillValueHolder._Cambio = FieldsPanel._Cambio.Value;

            PurchaseBillValueHolder._IvaIncluido = FieldsPanel._IvaIncluido.Checked;

            PurchaseBillValueHolder._AnadirTipoIvaTipo = FieldsPanel._AnadirTipoIvaTipo.Text;
            PurchaseBillValueHolder._AnadirTipoIvaMontoDePartida = FieldsPanel._AnadirTipoIvaMontoDePartida.Value;

            PurchaseBillValueHolder._AnadirContrapartidaTcCuenta = FieldsPanel._AnadirContrapartidaTcCuenta.Text;
            PurchaseBillValueHolder._AnadirContrapartidaTnImporte = FieldsPanel._AnadirContrapartidaTnImporte.Value;
            PurchaseBillValueHolder._AnadirContrapartidaTlEsUnSuplido = FieldsPanel._AnadirContrapartidaTlEsUnSuplido.Checked;

            PurchaseBillValueHolder._DefinicionDebe = FieldsPanel._DefinicionDebe.Text;
            PurchaseBillValueHolder._DefinicionHaber = FieldsPanel._DefinicionHaber.Text;

            PurchaseBillValueHolder._PresentarVencimientos = FieldsPanel._PresentarVencimientos.Checked;
            PurchaseBillValueHolder._ContabilizarPago = FieldsPanel._ContabilizarPago.Checked;
            PurchaseBillValueHolder._PresentarFechaBancoPago = FieldsPanel._PresentarFechaBancoPago.Checked;
            PurchaseBillValueHolder._PresentarAsiento = FieldsPanel._PresentarAsiento.Checked;

            PurchaseBillValueHolder._CuentaBancoPago = FieldsPanel._CuentaBancoPago.Text;
            PurchaseBillValueHolder._FechaPago = FieldsPanel._FechaPago.Value;
            PurchaseBillValueHolder._PrcDtoPP = FieldsPanel._PrcDtoPP.Value;
            PurchaseBillValueHolder._AplicaRetPro = FieldsPanel._AplicaRetPro.Checked;

            string aa = "";
            aa += "_Error_Message: " + PurchaseBillValueHolder._Error_Message + "\n";
            aa += "_nDigitos: " + PurchaseBillValueHolder._nDigitos + "\n";
            aa += "_Ejercicio: " + PurchaseBillValueHolder._Ejercicio + "\n";
            aa += "_LongFactCompra: " + PurchaseBillValueHolder._LongFactCompra + "\n";

            aa += "_Proveedor: " + PurchaseBillValueHolder._Proveedor + "\n";
            aa += "_FechaAsiento: " + PurchaseBillValueHolder._FechaAsiento + "\n";
            aa += "_FechaFactura: " + PurchaseBillValueHolder._FechaFactura + "\n";
            aa += "_Factura: " + PurchaseBillValueHolder._Factura + "\n";
            aa += "_Divisa: " + PurchaseBillValueHolder._Divisa + "\n";
            aa += "_Cambio: " + PurchaseBillValueHolder._Cambio + "\n";

            aa += "_IvaIncluido: " + PurchaseBillValueHolder._IvaIncluido + "\n";

            aa += "_AnadirTipoIvaTipo: " + PurchaseBillValueHolder._AnadirTipoIvaTipo + "\n";
            aa += "_AnadirTipoIvaMontoDePartida: " + PurchaseBillValueHolder._AnadirTipoIvaMontoDePartida + "\n";

            aa += "_AnadirContrapartidaTcCuenta: " + PurchaseBillValueHolder._AnadirContrapartidaTcCuenta + "\n";
            aa += "_AnadirContrapartidaTnImporte: " + PurchaseBillValueHolder._AnadirContrapartidaTnImporte + "\n";
            aa += "_AnadirContrapartidaTlEsUnSuplido: " + PurchaseBillValueHolder._AnadirContrapartidaTlEsUnSuplido + "\n";

            aa += "_DefinicionDebe: " + PurchaseBillValueHolder._DefinicionDebe + "\n";
            aa += "_DefinicionHaber: " + PurchaseBillValueHolder._DefinicionHaber + "\n";

            aa += "_PresentarVencimientos: " + PurchaseBillValueHolder._PresentarVencimientos + "\n";
            aa += "_ContabilizarPago: " + PurchaseBillValueHolder._ContabilizarPago + "\n";
            aa += "_PresentarFechaBancoPago: " + PurchaseBillValueHolder._PresentarFechaBancoPago + "\n";
            aa += "_PresentarAsiento: " + PurchaseBillValueHolder._PresentarAsiento + "\n";

            aa += "_CuentaBancoPago: " + PurchaseBillValueHolder._CuentaBancoPago + "\n";
            aa += "_FechaPago: " + PurchaseBillValueHolder._FechaPago + "\n";
            aa += "_PrcDtoPP: " + PurchaseBillValueHolder._PrcDtoPP + "\n";
            aa += "_AplicaRetPro: " + PurchaseBillValueHolder._AplicaRetPro + "\n";

            MessageBox.Show(aa);


            ParentForm.Close();
        }
    }
}
