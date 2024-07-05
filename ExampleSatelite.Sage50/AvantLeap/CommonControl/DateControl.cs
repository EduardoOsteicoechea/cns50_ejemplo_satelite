using ExampleSatelite.Sage50.AvantLeap.Styles;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.CommonControl
{
    internal class DateControl : DateTimePicker
    {
        public DateControl(int variableTop, ControlCollection parentControl)
        {
            this.Location = new System.Drawing.Point(EOStyles.Column1Left * 3, variableTop);
            this.Width = EOStyles.ControlFullWidth;
            this.BackColor = EOStyles.c_white;
            this.Font = EOStyles.GlobalFont5;
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "dd/MM/yyyy";
            this.CalendarTrailingForeColor = EOStyles.c_white;
            this.CalendarMonthBackground = EOStyles.c_white;
            this.CalendarTitleBackColor = EOStyles.c_white;
            this.CalendarForeColor = EOStyles.c_gray_75;
            this.ClientSize = new System.Drawing.Size(EOStyles.ControlFullWidth, 40);
            parentControl.Add(this);
        }
    }
}
