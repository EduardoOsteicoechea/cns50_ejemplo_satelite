using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.DatabaseConnection
{
    internal class ConnectToGestProjectDatabase
    {
        public bool Error { get; set; } = true;
        public ConnectToGestProjectDatabase() 
        {
            SqlConnection connection = new SqlConnection(ValueHolder.ConnectionString);
            ValueHolder.SQLConnection = connection;
            if(ValueHolder.SQLConnection != null) 
            {
                Error = false;
            };


            //connection.Open();
            //string aa = "";

            //using(SqlCommand command = new SqlCommand("SELECT * FROM PARTICIPANTE", connection))
            //{
            //    using(SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while(reader.Read())
            //        {
            //            aa += reader.GetString(0) + "\n";
            //        }
            //    }
            //}

            //MessageBox.Show(aa);

            connection.Close();
        }
    }
}
