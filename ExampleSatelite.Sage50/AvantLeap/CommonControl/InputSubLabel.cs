using ExampleSatelite.Sage50.AvantLeap.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.CommonControl
{
    internal class InputSubLabel : System.Windows.Forms.Label
    {
        public InputSubLabel(int variableTop, ControlCollection parentControl) 
        {
            this.Height = 20;
            this.Location = new System.Drawing.Point(EOStyles.Column1Left * 3, variableTop);
            this.Width = EOStyles.ControlFullWidth;
            this.ForeColor = EOStyles.c_gray_75;
            parentControl.Add(this);
        }

    }
}
