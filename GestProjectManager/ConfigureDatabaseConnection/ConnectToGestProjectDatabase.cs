using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.ConfigureDatabaseConnection
{
    internal class ConnectToGestProjectDatabase
    {
        public bool Error { get; set; } = true;
        public ConnectToGestProjectDatabase() 
        {
            SqlConnection connection = new SqlConnection(GestprojectDataValueHolder.ConnectionString);
            GestprojectDataValueHolder.SQLConnection = connection;
            if(GestprojectDataValueHolder.SQLConnection != null) 
            {
                Error = false;
            }

            //using(SqlConnection connection = new SqlConnection(GestprojectDataValueHolder.ConnectionString))
            //{
            //    connection.Open();

            //    using(SqlCommand command = new SqlCommand(SQLString, connection))
            //    {
            //        using(SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while(reader.Read())
            //            {
            //                LastClientId += reader.GetString(0) + "|";
            //            }
            //        }
            //    }
            //    connection.Close();
            //}
        }
    }
}
