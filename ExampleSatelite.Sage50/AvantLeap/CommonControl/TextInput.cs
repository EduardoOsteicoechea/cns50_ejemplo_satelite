using ExampleSatelite.Sage50.AvantLeap.Styles;

namespace ExampleSatelite.Sage50.AvantLeap.CommonControl
{
    internal class TextInput : System.Windows.Forms.TextBox
    {
        public TextInput (int variableTop, ControlCollection parentControl) 
        {
            
            this.Location = new System.Drawing.Point(EOStyles.Column1Left * 3, variableTop);
            this.Width = EOStyles.ControlFullWidth;
            this.BackColor = EOStyles.c_white;
            this.Font = EOStyles.GlobalFont5;
            parentControl.Add(this);
        }
    }
}
