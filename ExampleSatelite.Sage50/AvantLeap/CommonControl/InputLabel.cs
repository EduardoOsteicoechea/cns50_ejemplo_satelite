using ExampleSatelite.Sage50.AvantLeap.Styles;

namespace ExampleSatelite.Sage50.AvantLeap.CommonControl
{
    internal class InputLabel : System.Windows.Forms.Label
    {
        public InputLabel(int variableTop, ControlCollection parentControl) 
        {
            this.Height = 20;
            this.Location = new System.Drawing.Point(EOStyles.Column1Left, variableTop);
            this.Width = EOStyles.ControlFullWidth;
            this.ForeColor = EOStyles.c_gray_75;
            parentControl.Add(this);
        }
    }
}


