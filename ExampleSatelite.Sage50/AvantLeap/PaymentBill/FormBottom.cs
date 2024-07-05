using ExampleSatelite.Sage50.AvantLeap.Styles;
using sage.ew.ewbase;
using sage.ew.global.Diccionarios;
using sage.ew.global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.PaymentBill
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
            PaymentBillValueHolder._Pendiente = Convert.ToInt32(Math.Round(FieldsPanel._Pendiente.Value));
            PaymentBillValueHolder._Importe = FieldsPanel._Importe.Value;
            PaymentBillValueHolder._EntregaDiv = FieldsPanel._EntregaDiv.Value;

            PaymentBillValueHolder._LinkForm = FieldsPanel._LinkForm.Checked;
            PaymentBillValueHolder._Fecha = FieldsPanel._Fecha.Value;
            PaymentBillValueHolder._Cuenta = FieldsPanel._Cuenta.Text;
            PaymentBillValueHolder._Divisa = FieldsPanel._Divisa.Text;
            PaymentBillValueHolder._Cambio = FieldsPanel._Cambio.Value;
            PaymentBillValueHolder._Definicion = FieldsPanel._Definicion.Text;
            PaymentBillValueHolder._AsientoPorLinea = FieldsPanel._AsientoPorLinea.Checked;

            PaymentBillValueHolder.NuevaLinea_Automatico = FieldsPanel.NuevaLinea_Automatico.Checked;
            PaymentBillValueHolder.NuevaLinea_Cuenta = FieldsPanel.NuevaLinea_Cuenta.Text;
            PaymentBillValueHolder.NuevaLinea_DefinicionAsiento = FieldsPanel.NuevaLinea_DefinicionAsiento.Text;
            PaymentBillValueHolder.NuevaLinea_Factura = FieldsPanel.NuevaLinea_Factura.Text;
            PaymentBillValueHolder.NuevaLinea_Orden_Numereb = Convert.ToInt32(Math.Round(FieldsPanel.NuevaLinea_Orden_Numereb.Value));
            PaymentBillValueHolder.NuevaLinea_Entrega = FieldsPanel.NuevaLinea_Entrega.Value;
            PaymentBillValueHolder.NuevaLinea_Importe = FieldsPanel.NuevaLinea_Importe.Value;
            PaymentBillValueHolder.NuevaLinea_Emision = FieldsPanel.NuevaLinea_Emision.Value;
            PaymentBillValueHolder.NuevaLinea_Prevision = FieldsPanel.NuevaLinea_Prevision.Checked;
            PaymentBillValueHolder.NuevaLinea_Periodo = Convert.ToInt32(Math.Round(FieldsPanel.NuevaLinea_Periodo.Value));
            PaymentBillValueHolder.NuevaLinea_Pendiente = Convert.ToInt32(Math.Round(FieldsPanel.NuevaLinea_Pendiente.Value));
            PaymentBillValueHolder.NuevaLinea_Vencimiento = FieldsPanel.NuevaLinea_Vencimiento.Value;
            PaymentBillValueHolder.NuevaLinea_Divisa = FieldsPanel.NuevaLinea_Divisa.Text;
            PaymentBillValueHolder.NuevaLinea_CambioPrevision = FieldsPanel.NuevaLinea_CambioPrevision.Value;

            string aa = "";

            aa += "_Error_Message: " + PaymentBillValueHolder._Error_Message + "\n";
            aa += "_nDigitos: " + PaymentBillValueHolder._nDigitos + "\n";
            aa += "_Ejercicio: " + PaymentBillValueHolder._Ejercicio + "\n";

            aa += "_Pendiente: " + PaymentBillValueHolder._Pendiente + "\n";
            aa += "_Importe: " + PaymentBillValueHolder._Importe + "\n";
            aa += "_EntregaDiv: " + PaymentBillValueHolder._EntregaDiv + "\n";

            aa += "_LinkForm: " + PaymentBillValueHolder._LinkForm + "\n";
            aa += "_Fecha: " + PaymentBillValueHolder._Fecha + "\n";
            aa += "_Cuenta: " + PaymentBillValueHolder._Cuenta + "\n";
            aa += "_Divisa: " + PaymentBillValueHolder._Divisa + "\n";
            aa += "_Cambio: " + PaymentBillValueHolder._Cambio + "\n";
            aa += "_Definicion: " + PaymentBillValueHolder._Definicion + "\n";
            aa += "_AsientoPorLinea: " + PaymentBillValueHolder._AsientoPorLinea + "\n";

            aa += "NuevaLinea_Automatico: " + PaymentBillValueHolder.NuevaLinea_Automatico + "\n";
            aa += "NuevaLinea_Cuenta: " + PaymentBillValueHolder.NuevaLinea_Cuenta + "\n";
            aa += "NuevaLinea_DefinicionAsiento: " + PaymentBillValueHolder.NuevaLinea_DefinicionAsiento + "\n";
            aa += "NuevaLinea_Factura: " + PaymentBillValueHolder.NuevaLinea_Factura + "\n";
            aa += "NuevaLinea_Orden_Numereb: " + PaymentBillValueHolder.NuevaLinea_Orden_Numereb + "\n";
            aa += "NuevaLinea_Entrega: " + PaymentBillValueHolder.NuevaLinea_Entrega + "\n";
            aa += "NuevaLinea_Importe: " + PaymentBillValueHolder.NuevaLinea_Importe + "\n";
            aa += "NuevaLinea_Emision: " + PaymentBillValueHolder.NuevaLinea_Emision + "\n";
            aa += "NuevaLinea_Prevision: " + PaymentBillValueHolder.NuevaLinea_Prevision + "\n";
            aa += "NuevaLinea_Periodo: " + PaymentBillValueHolder.NuevaLinea_Periodo + "\n";
            aa += "NuevaLinea_Pendiente: " + PaymentBillValueHolder.NuevaLinea_Pendiente + "\n";
            aa += "NuevaLinea_Vencimiento: " + PaymentBillValueHolder.NuevaLinea_Vencimiento + "\n";
            aa += "NuevaLinea_Divisa: " + PaymentBillValueHolder.NuevaLinea_Divisa + "\n";
            aa += "NuevaLinea_CambioPrevision: " + PaymentBillValueHolder.NuevaLinea_CambioPrevision + "\n";

            MessageBox.Show(aa);

            ParentForm.Close();
        }
    }
}
