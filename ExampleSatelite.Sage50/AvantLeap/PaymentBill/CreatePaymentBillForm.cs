using ExampleSatelite.Sage50.AvantLeap.PaymentBill;
using ExampleSatelite.Sage50.AvantLeap.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.PaymentBill
{
    internal class CreatePaymentBillForm : System.Windows.Forms.Form
    {
        public CreatePaymentBillForm()
        {
            this.Text = "Datos para factura de cobro";
            this.Width = EOStyles.FormWidth;
            this.Height = EOStyles.FormHeight;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Font = EOStyles.GlobalFont;
            this.BackColor = EOStyles.c_white;
            this.StartPosition = FormStartPosition.CenterScreen;


            FormHeading formHeading = new FormHeading(this);
            FieldsPanel fieldsPanel = new FieldsPanel(this);
            FormBottom formBottom = new FormBottom(this, fieldsPanel);
        }
    }
}
