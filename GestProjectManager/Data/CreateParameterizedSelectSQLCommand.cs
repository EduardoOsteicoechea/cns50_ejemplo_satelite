using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.Data
{
    internal class CreateParameterizedSelectSQLCommand
    {
        public SqlCommand SqlCommand { get; }
        public string SqlCommandString { get; set; }
        public CreateParameterizedSelectSQLCommand(List<string> columnNames, string filterValueColumn = null, string tableName = "", string FilterMode = "")
        {
            string parameterList = string.Join(", ", columnNames);

            if(FilterMode == "AllDates" || filterValueColumn == null)
            {
                SqlCommandString = $"SELECT {parameterList} FROM {tableName}";
            } 
            else
            {
                SqlCommandString = $"SELECT * FROM {tableName} WHERE({filterValueColumn} >= {ValueHolder.FilterStartDate.ToString().Split(' ')[0]} AND {filterValueColumn} <= {ValueHolder.FilterEndDate.ToString().Split(' ')[0]}) OR {filterValueColumn} IS NULL";
            };

            SqlCommand = new SqlCommand(SqlCommandString, ValueHolder.SQLConnection);

            string aa = "";

            using(SqlDataReader reader = SqlCommand.ExecuteReader())
            {
                int fieldCount = reader.FieldCount;

                while(reader.Read())
                {
                    for(int i = 0; i < fieldCount; i++)
                    {
                        aa += reader.GetValue(i) + "\n";
                    }
                    aa += "------------------------" + "\n";
                }

                System.Windows.Forms.Form cc = new System.Windows.Forms.Form();
                cc.StartPosition = FormStartPosition.Manual;
                cc.Height = 600;
                cc.Width = 400;
                System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
                richTextBox.Location = new System.Drawing.Point(0,0);
                richTextBox.Text = SqlCommandString;
                richTextBox.Height = 100;
                richTextBox.Width = 350;
                cc.Controls.Add(richTextBox);

                System.Windows.Forms.RichTextBox richTextBox2 = new System.Windows.Forms.RichTextBox();
                richTextBox2.Location = new System.Drawing.Point(0, 110);
                richTextBox2.Text = aa;
                richTextBox2.Height = 400;
                richTextBox2.Width = 350;
                cc.Controls.Add(richTextBox2);

                cc.ShowDialog();
            }
        }
    }
}
