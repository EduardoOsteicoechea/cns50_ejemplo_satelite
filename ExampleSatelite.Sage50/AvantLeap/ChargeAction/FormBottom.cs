using ExampleSatelite.Sage50.AvantLeap.Styles;
using Sage.ES.S50.NuevoEjercicio;
using sage.ew.ewbase;
using System;
using System.Windows.Forms;
using static Sage.ES.S50.S50Update.Classes.S50UpdateLog;

namespace ExampleSatelite.Sage50.AvantLeap.ChargeAction
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
            CreateBillButton.Text = "Ejecutar acción de pago";
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
            ChargeActionValueHolder._Pendiente = Convert.ToInt32(Math.Round(FieldsPanel._Pendiente.Value));
            ChargeActionValueHolder._Importe = FieldsPanel._Importe.Value;
            ChargeActionValueHolder._EntregaDiv = FieldsPanel._EntregaDiv.Value;

            ChargeActionValueHolder._LinkForm = FieldsPanel._LinkForm.Checked;
            ChargeActionValueHolder._Fecha = FieldsPanel._Fecha.Value;
            ChargeActionValueHolder._Cuenta = FieldsPanel._Cuenta.Text;
            ChargeActionValueHolder._Divisa = FieldsPanel._Divisa.Text;
            ChargeActionValueHolder._Cambio = FieldsPanel._Cambio.Value;
            ChargeActionValueHolder._Definicion = FieldsPanel._Definicion.Text;
            ChargeActionValueHolder._AsientoPorLinea = FieldsPanel._AsientoPorLinea.Checked;

            ChargeActionValueHolder.loNuevaLinea_Automatico = FieldsPanel.loNuevaLinea_Automatico.Checked;
            ChargeActionValueHolder.loNuevaLinea_Cuenta = FieldsPanel.loNuevaLinea_Cuenta.Text;
            ChargeActionValueHolder.loNuevaLinea_DefinicionAsiento = FieldsPanel.loNuevaLinea_DefinicionAsiento.Text;

            ChargeActionValueHolder.loNuevaLinea_Factura = FieldsPanel.loNuevaLinea_Factura.Text;
            ChargeActionValueHolder.loNuevaLinea_Orden_Numereb = Convert.ToInt32(Math.Round(FieldsPanel.loNuevaLinea_Orden_Numereb.Value));
            ChargeActionValueHolder.loNuevaLinea_Entrega = FieldsPanel.loNuevaLinea_Entrega.Value;
            ChargeActionValueHolder.loNuevaLinea_Importe = FieldsPanel.loNuevaLinea_Importe.Value;
            ChargeActionValueHolder.loNuevaLinea_Emision = FieldsPanel.loNuevaLinea_Emision.Value;
            ChargeActionValueHolder.loNuevaLinea_Prevision = FieldsPanel.loNuevaLinea_Prevision.Checked;
            ChargeActionValueHolder.loNuevaLinea_Periodo = Convert.ToInt32(Math.Round(FieldsPanel.loNuevaLinea_Periodo.Value));
            ChargeActionValueHolder.loNuevaLinea_Pendiente = Convert.ToInt32(Math.Round(FieldsPanel.loNuevaLinea_Pendiente.Value));
            ChargeActionValueHolder.loNuevaLinea_Vencimiento = FieldsPanel.loNuevaLinea_Vencimiento.Value;

            ChargeActionValueHolder.loNuevaLinea_Divisa = FieldsPanel.loNuevaLinea_Divisa.Text;
            ChargeActionValueHolder.loNuevaLinea_CambioPrevision = FieldsPanel.loNuevaLinea_CambioPrevision.Value;

            ChargeActionValueHolder._PresentarAsiento = FieldsPanel._PresentarAsiento.Checked;

            string aa = "";

            aa += "_Error_Message: " + ChargeActionValueHolder._Error_Message + "\n";
            aa += "_nDigitos: " + ChargeActionValueHolder._nDigitos + "\n";
            aa += "_Ejercicio: " + ChargeActionValueHolder._Ejercicio + "\n";

            aa += "_Pendiente: " + ChargeActionValueHolder._Pendiente + "\n";
            aa += "_Importe: " + ChargeActionValueHolder._Importe + "\n";
            aa += "_EntregaDiv: " + ChargeActionValueHolder._EntregaDiv + "\n";

            aa += "_LinkForm: " + ChargeActionValueHolder._LinkForm + "\n";
            aa += "_Fecha: " + ChargeActionValueHolder._Fecha + "\n";
            aa += "_Cuenta: " + ChargeActionValueHolder._Cuenta + "\n";
            aa += "_Divisa: " + ChargeActionValueHolder._Divisa + "\n";
            aa += "_Cambio: " + ChargeActionValueHolder._Cambio + "\n";
            aa += "_Definicion: " + ChargeActionValueHolder._Definicion + "\n";
            aa += "_AsientoPorLinea: " + ChargeActionValueHolder._AsientoPorLinea + "\n";

            aa += "loNuevaLinea_Automatico: " + ChargeActionValueHolder.loNuevaLinea_Automatico + "\n";
            aa += "loNuevaLinea_Cuenta: " + ChargeActionValueHolder.loNuevaLinea_Cuenta + "\n";
            aa += "loNuevaLinea_DefinicionAsiento: " + ChargeActionValueHolder.loNuevaLinea_DefinicionAsiento + "\n";

            aa += "loNuevaLinea_Factura: " + ChargeActionValueHolder.loNuevaLinea_Factura + "\n";
            aa += "loNuevaLinea_Orden_Numereb: " + ChargeActionValueHolder.loNuevaLinea_Orden_Numereb + "\n";
            aa += "loNuevaLinea_Entrega: " + ChargeActionValueHolder.loNuevaLinea_Entrega + "\n";
            aa += "loNuevaLinea_Importe: " + ChargeActionValueHolder.loNuevaLinea_Importe + "\n";
            aa += "loNuevaLinea_Emision: " + ChargeActionValueHolder.loNuevaLinea_Emision + "\n";
            aa += "loNuevaLinea_Prevision: " + ChargeActionValueHolder.loNuevaLinea_Prevision + "\n";
            aa += "loNuevaLinea_Periodo: " + ChargeActionValueHolder.loNuevaLinea_Periodo + "\n";
            aa += "loNuevaLinea_Pendiente: " + ChargeActionValueHolder.loNuevaLinea_Pendiente + "\n";
            aa += "loNuevaLinea_Vencimiento: " + ChargeActionValueHolder.loNuevaLinea_Vencimiento + "\n";

            aa += "loNuevaLinea_Divisa: " + ChargeActionValueHolder.loNuevaLinea_Divisa + "\n";
            aa += "loNuevaLinea_CambioPrevision: " + ChargeActionValueHolder.loNuevaLinea_CambioPrevision + "\n";

            aa += "_PresentarAsiento: " + ChargeActionValueHolder._PresentarAsiento + "\n";

            MessageBox.Show(aa);


            ParentForm.Close();
        }
    }
}
