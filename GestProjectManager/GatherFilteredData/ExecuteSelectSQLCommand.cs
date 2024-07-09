using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GestProjectManager.Data;

namespace GestProjectManager.GatherFilteredData
{
    internal class ExecuteSelectSQLCommand<T> where T : new()
    {
        public bool Error { get; set; } = true;
        public List<T> ClassList { get; private set; } = new List<T>();
        public ExecuteSelectSQLCommand
        (
            string SqlCommandString,
            Type TypeToBeCreatedAndPopulated
        )
        {
            ValueHolder.SQLConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(SqlCommandString, ValueHolder.SQLConnection);

            using(SqlDataReader reader = sqlCommand.ExecuteReader())
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
                        }
                        else if(reader.GetValue(i).GetType() == typeof(int))
                        {
                            property.SetValue(newObject, reader.GetValue(i) == null ? 0 : reader.GetValue(i));
                        }
                        else if(reader.GetValue(i).GetType() == typeof(DateTime))
                        {
                            property.SetValue(newObject, reader.GetValue(i) == null ? DateTime.Parse("2000-01-01") : reader.GetValue(i));
                        }
                        else if(reader.GetValue(i).GetType() == typeof(decimal))
                        {
                            property.SetValue(newObject, reader.GetValue(i) == null ? 0.0 : reader.GetValue(i));
                        }
                    }
                    ClassList.Add(newObject);
                }
            }

            ValueHolder.SQLConnection.Close();

            Error = false;
        }

    }
}
