using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.GatherFilteredData
{
    internal class GenerateFilteredDataView<T> where T : new ()
    {
        public GenerateFilteredDataView
        (
            string sqlCommandString,
            List<T> classList
        ) 
        {
            System.Windows.Forms.Form cc = new System.Windows.Forms.Form();
            cc.Text = classList[0].GetType().ToString() + " Data";
            cc.StartPosition = FormStartPosition.Manual;
            cc.Height = Screen.GetWorkingArea(cc.Location).Height;
            cc.Width = Screen.GetWorkingArea(cc.Location).Width;
            cc.WindowState = FormWindowState.Maximized;

            System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
            richTextBox.Location = new System.Drawing.Point(25, 25);
            richTextBox.Text = sqlCommandString;
            richTextBox.Height = 75;
            richTextBox.Width = cc.Width - 50;

            DataGridView dataGridView = new DataGridView();
            dataGridView.ColumnCount = classList.Count;
            dataGridView.Location = new System.Drawing.Point(25, 110);
            dataGridView.Height = (cc.Height - 50) - (richTextBox.Height) - 10 - 50;
            dataGridView.Width = cc.Width - 50;
            dataGridView.BorderStyle = BorderStyle.None;

            for(int i = 0; i < classList.Count; i++)
            {
                T currentClass = classList[i];
                PropertyInfo[] properties = currentClass.GetType().GetProperties();
                int dataGridViewRowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[dataGridViewRowIndex].HeaderCell.Value = dataGridViewRowIndex + 1 + "";

                for(int j = 0; j < properties.Length; j++)
                {
                    PropertyInfo property = properties[j];
                    if(i == 0)
                    { 
                        dataGridView.Columns[j].Name = property.Name;
                    };

                    DataGridViewCell dataGridViewCell = dataGridView.Rows[dataGridViewRowIndex].Cells[j];
                    object propertyValue = property.GetValue(currentClass);
                    dataGridViewCell.Value = propertyValue;
                }
            };

            cc.Controls.Add(richTextBox);
            cc.Controls.Add(dataGridView);
            cc.ShowDialog();
        }
    }
}
