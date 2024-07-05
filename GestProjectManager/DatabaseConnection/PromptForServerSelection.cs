using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.DatabaseConnection
{
    internal class PromptForServerSelection : System.Windows.Forms.Form
    {
        public ComboBox ServersComboBox { get; set; }
        public Button AcceptServerButton { get; set; }
        public bool Error { get; set; } = true;
        public PromptForServerSelection()
        {
            this.Text = "Seleccione el servidor de Gestproject a emplear";

            ServersComboBox = new ComboBox();
            ServersComboBox.Location = new System.Drawing.Point(20, 20);
            ServersComboBox.Items.AddRange(ValueHolder.GestprojectVersionNames.ToArray());
            ServersComboBox.SelectedIndexChanged += ServersComboBox_SelectedIndexChanged;
            this.Controls.Add(ServersComboBox);

            AcceptServerButton = new Button();
            AcceptServerButton.Text = "Aceptar";
            AcceptServerButton.Enabled = false;
            AcceptServerButton.Location = new System.Drawing.Point(20, 50);
            AcceptServerButton.Click += AcceptServerButton_Click;
            this.Controls.Add(AcceptServerButton);

            this.ShowDialog();
        }

        private void AcceptServerButton_Click(object sender, EventArgs e)
        {
            ValueHolder.GestprojectVersionName = ServersComboBox.Text;
            Error = false;
            this.Close();
        }

        private void ServersComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            AcceptServerButton.Enabled = true;
        }
    }
}
