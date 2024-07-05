using GestProjectManager.Data;
using GestProjectManager.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.DataFilters
{
    internal class PromptForDates : System.Windows.Forms.Form
    {   
        public bool Error {  get; set; } = true;
        public int VariableHeight { get; set; } = EOStyles.Row1Top;

        public Panel ControlsPanel { get; set; } = new Panel();

        public Label AllDatesCheckBoxLabel { get; set; } = new Label();
        public CheckBox AllDatesCheckBox { get; set; } = new CheckBox();

        public Label StartDateDateTimePickerLabel { get; set; } = new Label();
        public DateTimePicker StartDateDateTimePicker { get; set; } = new DateTimePicker();

        public Label EndDateDateTimePickerLabel { get; set; } = new Label();
        public DateTimePicker EndDateDateTimePicker { get; set; } = new DateTimePicker();

        public Button AcceptDatesButton { get; set; } = new Button();

        public PromptForDates() 
        {
            this.Text = "Seleccione las fechas en las que desea sincronizar datos";

            ControlsPanel.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            ControlsPanel.BorderStyle = BorderStyle.FixedSingle;
            ControlsPanel.Height = 200;
            ControlsPanel.Width = 250;
            ControlsPanel.AutoScroll = true;

            AllDatesCheckBoxLabel.Text = "Todas las fechas";
            AllDatesCheckBoxLabel.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            VariableHeight += EOStyles.LabelControlVerticalDistance;

            AllDatesCheckBox.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            AllDatesCheckBox.CheckedChanged += AllDatesCheckBox_CheckedChanged;
            VariableHeight += EOStyles.DiferentControlsVerticalDistance;



            StartDateDateTimePickerLabel.Text = "Fecha inicial";
            StartDateDateTimePickerLabel.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            VariableHeight += EOStyles.LabelControlVerticalDistance;

            StartDateDateTimePicker.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            StartDateDateTimePicker.Format = DateTimePickerFormat.Short;
            StartDateDateTimePicker.CustomFormat = "";
            StartDateDateTimePicker.ValueChanged += StartDateDateTimePicker_ValueChanged;
            VariableHeight += EOStyles.DiferentControlsVerticalDistance;



            EndDateDateTimePickerLabel.Text = "Fecha final";
            EndDateDateTimePickerLabel.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            VariableHeight += EOStyles.LabelControlVerticalDistance;

            EndDateDateTimePicker.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            EndDateDateTimePicker.Format = DateTimePickerFormat.Short;
            EndDateDateTimePicker.CustomFormat = "";
            EndDateDateTimePicker.ValueChanged += EndDateDateTimePicker_ValueChanged;
            VariableHeight += EOStyles.PanelControlVerticalDistance;



            AcceptDatesButton.Text = "Aceptar";
            AcceptDatesButton.Location = new System.Drawing.Point(EOStyles.Column1Left, VariableHeight);
            AcceptDatesButton.Enabled = false;
            AcceptDatesButton.Click += AcceptDatesButton_Click; 
            VariableHeight += EOStyles.DiferentControlsVerticalDistance;



            ControlsPanel.Controls.Add(AllDatesCheckBoxLabel);
            ControlsPanel.Controls.Add(AllDatesCheckBox);
            ControlsPanel.Controls.Add(StartDateDateTimePickerLabel);
            ControlsPanel.Controls.Add(StartDateDateTimePicker);
            ControlsPanel.Controls.Add(EndDateDateTimePickerLabel);
            ControlsPanel.Controls.Add(EndDateDateTimePicker);
            this.Controls.Add(AcceptDatesButton);
            this.Controls.Add(ControlsPanel);

            this.ShowDialog();
        }

        private void AllDatesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(AllDatesCheckBox.Checked)
            {
                StartDateDateTimePicker.Enabled = false;
                EndDateDateTimePicker.Enabled = false;
                AcceptDatesButton.Enabled = true;
            }
            else
            {
                StartDateDateTimePicker.Enabled = true;
                EndDateDateTimePicker.Enabled = true;
                AcceptDatesButton.Enabled = false;
            }
        }

        private void StartDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDateDateTimePicker.Enabled = true;
        }

        private void EndDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AcceptDatesButton.Enabled = true;
        }

        private void AcceptDatesButton_Click(object sender, EventArgs e)
        {
            if(AllDatesCheckBox.Checked)
            {
                ValueHolder.FilterDatesType = "AllDates";
            } 
            else
            {
                ValueHolder.FilterDatesType = "StarEndDate";
            };

            if (ValueHolder.FilterDatesType == "StarEndDate") 
            {
                ValueHolder.FilterStartDate = StartDateDateTimePicker.Value;
                ValueHolder.FilterEndDate = EndDateDateTimePicker.Value;
            };

            MessageBox.Show(ValueHolder.FilterDatesType + "\n" + ValueHolder.FilterStartDate + "\n" + ValueHolder.FilterEndDate);

            this.Close();
        }
    }
}
