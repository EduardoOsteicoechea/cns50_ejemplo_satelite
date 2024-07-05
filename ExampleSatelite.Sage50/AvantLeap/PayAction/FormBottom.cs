using ExampleSatelite.Sage50.AvantLeap.Styles;
using Sage.ES.S50.NuevoEjercicio;
using sage.ew.ewbase;
using System;
using System.Windows.Forms;
using static Sage.ES.S50.S50Update.Classes.S50UpdateLog;

namespace ExampleSatelite.Sage50.AvantLeap.PayAction
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
            PayActionValueHolder._Pendiente = Convert.ToInt32(Math.Round(FieldsPanel._Pendiente.Value));
            PayActionValueHolder._Importe = FieldsPanel._Importe.Value;
            PayActionValueHolder._EntregaDiv = FieldsPanel._EntregaDiv.Value;

            PayActionValueHolder._LinkForm = FieldsPanel._LinkForm.Checked;
            PayActionValueHolder._Fecha = FieldsPanel._Fecha.Value;
            PayActionValueHolder._Cuenta = FieldsPanel._Cuenta.Text;
            PayActionValueHolder._Divisa = FieldsPanel._Divisa.Text;
            PayActionValueHolder._Cambio = FieldsPanel._Cambio.Value;
            PayActionValueHolder._Definicion = FieldsPanel._Definicion.Text;
            PayActionValueHolder._AsientoPorLinea = FieldsPanel._AsientoPorLinea.Checked;

            PayActionValueHolder.loNuevaLinea_Automatico = FieldsPanel.loNuevaLinea_Automatico.Checked;
            PayActionValueHolder.loNuevaLinea_Cuenta = FieldsPanel.loNuevaLinea_Cuenta.Text;
            PayActionValueHolder.loNuevaLinea_DefinicionAsiento = FieldsPanel.loNuevaLinea_DefinicionAsiento.Text;

            PayActionValueHolder.loNuevaLinea_Factura = FieldsPanel.loNuevaLinea_Factura.Text;
            PayActionValueHolder.loNuevaLinea_Orden_Numereb = Convert.ToInt32(Math.Round(FieldsPanel.loNuevaLinea_Orden_Numereb.Value));
            PayActionValueHolder.loNuevaLinea_Entrega = FieldsPanel.loNuevaLinea_Entrega.Value;
            PayActionValueHolder.loNuevaLinea_Importe = FieldsPanel.loNuevaLinea_Importe.Value;
            PayActionValueHolder.loNuevaLinea_Emision = FieldsPanel.loNuevaLinea_Emision.Value;
            PayActionValueHolder.loNuevaLinea_Prevision = FieldsPanel.loNuevaLinea_Prevision.Checked;
            PayActionValueHolder.loNuevaLinea_Periodo = Convert.ToInt32(Math.Round(FieldsPanel.loNuevaLinea_Periodo.Value));
            PayActionValueHolder.loNuevaLinea_Pendiente = Convert.ToInt32(Math.Round(FieldsPanel.loNuevaLinea_Pendiente.Value));
            PayActionValueHolder.loNuevaLinea_Vencimiento = FieldsPanel.loNuevaLinea_Vencimiento.Value;

            PayActionValueHolder.loNuevaLinea_Divisa = FieldsPanel.loNuevaLinea_Divisa.Text;
            PayActionValueHolder.loNuevaLinea_CambioPrevision = FieldsPanel.loNuevaLinea_CambioPrevision.Value;

            PayActionValueHolder._PresentarAsiento = FieldsPanel._PresentarAsiento.Checked;

            string aa = "";

            aa += "_Error_Message: " + PayActionValueHolder._Error_Message + "\n";
            aa += "_nDigitos: " + PayActionValueHolder._nDigitos + "\n";
            aa += "_Ejercicio: " + PayActionValueHolder._Ejercicio + "\n";

            aa += "_Pendiente: " + PayActionValueHolder._Pendiente + "\n";
            aa += "_Importe: " + PayActionValueHolder._Importe + "\n";
            aa += "_EntregaDiv: " + PayActionValueHolder._EntregaDiv + "\n";

            aa += "_LinkForm: " + PayActionValueHolder._LinkForm + "\n";
            aa += "_Fecha: " + PayActionValueHolder._Fecha + "\n";
            aa += "_Cuenta: " + PayActionValueHolder._Cuenta + "\n";
            aa += "_Divisa: " + PayActionValueHolder._Divisa + "\n";
            aa += "_Cambio: " + PayActionValueHolder._Cambio + "\n";
            aa += "_Definicion: " + PayActionValueHolder._Definicion + "\n";
            aa += "_AsientoPorLinea: " + PayActionValueHolder._AsientoPorLinea + "\n";

            aa += "loNuevaLinea_Automatico: " + PayActionValueHolder.loNuevaLinea_Automatico + "\n";
            aa += "loNuevaLinea_Cuenta: " + PayActionValueHolder.loNuevaLinea_Cuenta + "\n";
            aa += "loNuevaLinea_DefinicionAsiento: " + PayActionValueHolder.loNuevaLinea_DefinicionAsiento + "\n";

            aa += "loNuevaLinea_Factura: " + PayActionValueHolder.loNuevaLinea_Factura + "\n";
            aa += "loNuevaLinea_Orden_Numereb: " + PayActionValueHolder.loNuevaLinea_Orden_Numereb + "\n";
            aa += "loNuevaLinea_Entrega: " + PayActionValueHolder.loNuevaLinea_Entrega + "\n";
            aa += "loNuevaLinea_Importe: " + PayActionValueHolder.loNuevaLinea_Importe + "\n";
            aa += "loNuevaLinea_Emision: " + PayActionValueHolder.loNuevaLinea_Emision + "\n";
            aa += "loNuevaLinea_Prevision: " + PayActionValueHolder.loNuevaLinea_Prevision + "\n";
            aa += "loNuevaLinea_Periodo: " + PayActionValueHolder.loNuevaLinea_Periodo + "\n";
            aa += "loNuevaLinea_Pendiente: " + PayActionValueHolder.loNuevaLinea_Pendiente + "\n";
            aa += "loNuevaLinea_Vencimiento: " + PayActionValueHolder.loNuevaLinea_Vencimiento + "\n";

            aa += "loNuevaLinea_Divisa: " + PayActionValueHolder.loNuevaLinea_Divisa + "\n";
            aa += "loNuevaLinea_CambioPrevision: " + PayActionValueHolder.loNuevaLinea_CambioPrevision + "\n";

            aa += "_PresentarAsiento: " + PayActionValueHolder._PresentarAsiento + "\n";

            MessageBox.Show(aa);


            ParentForm.Close();
        }
    }
}
