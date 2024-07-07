using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.Data
{
    internal class ExecuteSelectSQLCommand<T> where T : new()
    {
        public SqlCommand SqlCommand { get; }
        public bool Error { get; set; } = true;
        public List<T> ClassList { get; private set; } = new List<T>();
        public ExecuteSelectSQLCommand
        (
            string SqlCommandString,
            Type TypeToBeCreatedAndPopulated
        )
        {
            ValueHolder.SQLConnection.Open();

            SqlCommand = new SqlCommand(SqlCommandString, ValueHolder.SQLConnection);

            string aa = "";

            using(SqlDataReader reader = SqlCommand.ExecuteReader())
            {
                int fieldCount = reader.FieldCount;

                while(reader.Read())
                {
                    T newObject = new T();

                    PropertyInfo[] properties = TypeToBeCreatedAndPopulated.GetProperties();

                    for(int i = 0; i < fieldCount; i++)
                    {
                        PropertyInfo property = properties[i];

                        if(reader.GetValue(i).GetType() == typeof(string))
                        {
                            property.SetValue(newObject, reader.GetValue(i) == null ? "" : reader.GetValue(i));
                            aa += reader.GetValue(i) + "\n";
                        }
                        else if(reader.GetValue(i).GetType() == typeof(int))
                        {
                            property.SetValue(newObject, reader.GetValue(i) == null ? 0 : reader.GetValue(i));
                            aa += reader.GetValue(i) + "\n";
                        }
                        else if(reader.GetValue(i).GetType() == typeof(DateTime))
                        {
                            property.SetValue(newObject, reader.GetValue(i) == null ? DateTime.Parse("2000-01-01") : reader.GetValue(i));
                            aa += reader.GetValue(i) + "\n";
                        }
                        else if(reader.GetValue(i).GetType() == typeof(decimal))
                        {
                            property.SetValue(newObject, reader.GetValue(i) == null ? 0.0 : reader.GetValue(i));
                            aa += reader.GetValue(i) + "\n";
                        }
                    }
                    aa += "------------------------" + "\n\n";

                    //PrintClassProperties.Print(newObject);

                    ClassList.Add(newObject);
                }

                MessageBox.Show("ClassList.Count" + ClassList.Count);


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

            ValueHolder.SQLConnection.Close();

            Error = false;
        }

    }
}
