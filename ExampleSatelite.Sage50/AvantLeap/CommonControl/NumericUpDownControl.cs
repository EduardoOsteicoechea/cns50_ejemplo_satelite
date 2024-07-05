using ExampleSatelite.Sage50.AvantLeap.Styles;

namespace ExampleSatelite.Sage50.AvantLeap.CommonControl
{
    internal class NumericUpDownControl : System.Windows.Forms.NumericUpDown
    {
        public NumericUpDownControl(int variableTop, ControlCollection parentControl)
        {
            this.Location = new System.Drawing.Point(EOStyles.Column1Left * 3, variableTop);
            this.Width = EOStyles.ControlFullWidth;
            this.BackColor = EOStyles.c_white;
            this.Font = EOStyles.GlobalFont5;
            this.DecimalPlaces = 2; // Display 2 decimal places
            this.ThousandsSeparator = true;
            this.Maximum = 10000;
            parentControl.Add(this);
        }
    }
}
