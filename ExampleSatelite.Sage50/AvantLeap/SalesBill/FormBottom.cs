using ExampleSatelite.Sage50.AvantLeap.Styles;
using Sage.ES.S50.Modelos.Clases;
using System;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.SalesBill
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
            this.AutoScroll = true;
            this.BackColor = EOStyles.c_transparent;

            System.Windows.Forms.Button CreateBillButton = new System.Windows.Forms.Button();
            CreateBillButton.Text = "Crear factura de venta";
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
            SalesBillValueHolder.llretencion = FieldsPanel.llretencion.Checked;
            SalesBillValueHolder.llSerFact = FieldsPanel.llSerFact.Checked;

            SalesBillValueHolder._Cliente = FieldsPanel._Cliente.Text;

            SalesBillValueHolder._SerieFra = FieldsPanel._SerieFra.Text;

            SalesBillValueHolder._Factura = FieldsPanel._Factura.Text;

            SalesBillValueHolder._TipoFactura = Convert.ToInt32(Math.Round(FieldsPanel._TipoFactura.Value));
            SalesBillValueHolder._FechaAsiento = FieldsPanel._FechaAsiento.Value;
            SalesBillValueHolder._FechaFactura = FieldsPanel._FechaFactura.Value;
            SalesBillValueHolder._PresentarVencimientos = FieldsPanel._PresentarVencimientos.Checked;
            SalesBillValueHolder._ContabilizarCobro = FieldsPanel._ContabilizarCobro.Checked;
            SalesBillValueHolder._PresentarAsiento = FieldsPanel._PresentarAsiento.Checked;

            SalesBillValueHolder._AnadirTipoIva1TcCodigo = FieldsPanel._AnadirTipoIva1TcCodigo.Text;
            SalesBillValueHolder._AnadirTipoIva1TnImporte = FieldsPanel._AnadirTipoIva1TnImporte.Value;

            SalesBillValueHolder._AnadirContrapartida1TcCuenta = FieldsPanel._AnadirContrapartida1TcCuenta.Text;
            SalesBillValueHolder._AnadirContrapartida1TnImporte = FieldsPanel._AnadirContrapartida1TnImporte.Value;
            SalesBillValueHolder._AnadirContrapartida1TlEsUnSuplido = FieldsPanel._AnadirContrapartida1TlEsUnSuplido.Checked;

            SalesBillValueHolder._DefinicionDebe = FieldsPanel._DefinicionDebe.Text;
            SalesBillValueHolder._DefinicionHaber = FieldsPanel._DefinicionHaber.Text;

            SalesBillValueHolder._Divisa = FieldsPanel._Divisa.Text;
            SalesBillValueHolder._Cambio = FieldsPanel._Cambio.Value;

            SalesBillValueHolder._PrcDtoPP = FieldsPanel._PrcDtoPP.Value;

            SalesBillValueHolder._PrcRecFinan = FieldsPanel._PrcRecFinan.Value;

            SalesBillValueHolder._Recc = FieldsPanel._Recc.Checked;

            SalesBillValueHolder._IvaIncluido = FieldsPanel._IvaIncluido.Checked;

            SalesBillValueHolder._RecEquiv = FieldsPanel._RecEquiv.Checked;

            SalesBillValueHolder.cfgRetencion_Retencion_Codigo = FieldsPanel.cfgRetencion_Retencion_Codigo.Text;
            SalesBillValueHolder.cfgRetencion_Retencion_Cuenta = FieldsPanel.cfgRetencion_Retencion_Cuenta.Text;
            SalesBillValueHolder.cfgRetencion_RetencionSobreBase = FieldsPanel.cfgRetencion_RetencionSobreBase.Checked;
            SalesBillValueHolder.cfgRetencion_RetencionSobreTotal = FieldsPanel.cfgRetencion_RetencionSobreTotal.Checked;
            SalesBillValueHolder.cfgRetencion_PrcRetencion = FieldsPanel.cfgRetencion_PrcRetencion.Value;

            string aa = "";
            aa += "_Error_Message: " + SalesBillValueHolder._Error_Message + "\n";
            aa += "_nDigitos: " + SalesBillValueHolder._nDigitos + "\n";
            aa += "_Ejercicio: " + SalesBillValueHolder._Ejercicio + "\n";

            aa += "llretencion: " + SalesBillValueHolder.llretencion + "\n";
            aa += "llSerFact: " + SalesBillValueHolder.llSerFact + "\n";

            aa += "_Cliente: " + SalesBillValueHolder._Cliente + "\n";

            aa += "_SerieFra: " + SalesBillValueHolder._SerieFra + "\n";

            aa += "_Factura: " + SalesBillValueHolder._Factura + "\n";

            aa += "_TipoFactura: " + SalesBillValueHolder._TipoFactura + "\n";
            aa += "_FechaAsiento: " + SalesBillValueHolder._FechaAsiento + "\n";
            aa += "_FechaFactura: " + SalesBillValueHolder._FechaFactura + "\n";
            aa += "_PresentarVencimientos: " + SalesBillValueHolder._PresentarVencimientos + "\n";
            aa += "_ContabilizarCobro: " + SalesBillValueHolder._ContabilizarCobro + "\n";
            aa += "_PresentarAsiento: " + SalesBillValueHolder._PresentarAsiento + "\n";

            aa += "_AnadirTipoIva1TcCodigo: " + SalesBillValueHolder._AnadirTipoIva1TcCodigo + "\n";
            aa += "_AnadirTipoIva1TnImporte: " + SalesBillValueHolder._AnadirTipoIva1TnImporte + "\n";

            aa += "_AnadirContrapartida1TcCuenta: " + SalesBillValueHolder._AnadirContrapartida1TcCuenta + "\n";
            aa += "_AnadirContrapartida1TnImporte: " + SalesBillValueHolder._AnadirContrapartida1TnImporte + "\n";
            aa += "_AnadirContrapartida1TlEsUnSuplido: " + SalesBillValueHolder._AnadirContrapartida1TlEsUnSuplido + "\n";

            aa += "_DefinicionDebe: " + SalesBillValueHolder._DefinicionDebe + "\n";
            aa += "_DefinicionHaber: " + SalesBillValueHolder._DefinicionHaber + "\n";

            aa += "_Divisa: " + SalesBillValueHolder._Divisa + "\n";
            aa += "_Cambio: " + SalesBillValueHolder._Cambio + "\n";

            aa += "_PrcDtoPP: " + SalesBillValueHolder._PrcDtoPP + "\n";

            aa += "_PrcRecFinan: " + SalesBillValueHolder._PrcRecFinan + "\n";

            aa += "_Recc: " + SalesBillValueHolder._Recc + "\n";

            aa += "_IvaIncluido: " + SalesBillValueHolder._IvaIncluido + "\n";

            aa += "_RecEquiv: " + SalesBillValueHolder._RecEquiv + "\n";

            aa += "cfgRetencion_Retencion_Codigo: " + SalesBillValueHolder.cfgRetencion_Retencion_Codigo + "\n";
            aa += "cfgRetencion_Retencion_Cuenta: " + SalesBillValueHolder.cfgRetencion_Retencion_Cuenta + "\n";
            aa += "cfgRetencion_RetencionSobreBase: " + SalesBillValueHolder.cfgRetencion_RetencionSobreBase + "\n";
            aa += "cfgRetencion_RetencionSobreTotal: " + SalesBillValueHolder.cfgRetencion_RetencionSobreTotal + "\n";
            aa += "cfgRetencion_PrcRetencion: " + SalesBillValueHolder.cfgRetencion_PrcRetencion + "\n";
            MessageBox.Show(aa);

            ParentForm.Close();
        }
    }
}
