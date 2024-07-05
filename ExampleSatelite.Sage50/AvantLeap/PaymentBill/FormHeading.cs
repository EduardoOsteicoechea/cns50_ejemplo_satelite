using ExampleSatelite.Sage50.AvantLeap.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSatelite.Sage50.AvantLeap.PaymentBill
{
    internal class FormHeading : System.Windows.Forms.Panel
    {
        public int VariableTop { get; set; } = Convert.ToInt32(Math.Round((double)(EOStyles.Row1Top * .75)));

        public FormHeading(System.Windows.Forms.Form parentForm)
        {

            this.Width = Convert.ToInt32(Math.Round((double)(EOStyles.FormWidth * .965)));
            this.Height = Convert.ToInt32(Math.Round((double)(EOStyles.FormHeight * .12)));
            this.Location = new System.Drawing.Point(-2, 0);
            this.AutoScroll = true;
            this.BackColor = EOStyles.c_transparent;

            System.Windows.Forms.Label HeadingLabel = new System.Windows.Forms.Label();
            HeadingLabel.Text = "Provea los datos de la factura de Cobro";
            HeadingLabel.Width = EOStyles.ControlFullWidth;
            HeadingLabel.Height = 40;
            HeadingLabel.Location = new System.Drawing.Point(EOStyles.Column1Left, 20);
            HeadingLabel.Font = EOStyles.GlobalFont4;
            HeadingLabel.BackColor = EOStyles.c_transparent;
            this.Controls.Add(HeadingLabel);


            parentForm.Controls.Add(this);
        }
    }
}
