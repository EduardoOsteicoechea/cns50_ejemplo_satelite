using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSatelite.Sage50
{
    namespace DataHolders
    {
        public static class DataHolder
        {

            // Get sage50 Clients
             public static DataTable Sage50ClientsTable { get; set; } = new DataTable();
        }
    }
}
