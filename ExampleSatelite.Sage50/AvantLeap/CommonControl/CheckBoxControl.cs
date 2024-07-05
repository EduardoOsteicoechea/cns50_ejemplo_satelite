using ExampleSatelite.Sage50.AvantLeap.Styles;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.CommonControl
{
    internal class CheckBoxControl : System.Windows.Forms.CheckBox
    {
        public CheckBoxControl (int variableTop, ControlCollection parentControl) 
        {

            this.TextAlign = ContentAlignment.MiddleRight;
            this.Location = new System.Drawing.Point(EOStyles.Column1Left * 3, variableTop);
            this.Width = EOStyles.ControlFullWidth;
            this.Font = EOStyles.GlobalFont5;
            this.ClientSize = new System.Drawing.Size(EOStyles.ControlFullWidth, 40);
            this.Size = new System.Drawing.Size(20,20);
            parentControl.Add(this);
        }
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = false; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int h = this.ClientSize.Height - 2;
            Rectangle rc = new Rectangle(new Point(0, 1), new Size(h, h));
            ControlPaint.DrawCheckBox(e.Graphics, rc, this.Checked ? ButtonState.Checked : ButtonState.Normal);
        }
    }
}
