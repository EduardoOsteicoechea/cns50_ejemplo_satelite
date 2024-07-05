using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProjectManager.ConfigureDatabaseConnection
{
    public static class GestprojectDataValueHolder
    {
        public static string WindowsIdentityDomainName { get; set; } = null;
        public static string WindowsIdentityUserName { get; set; } = null;
        public static List<string> GestprojectVersionNames { get; set; } = null;
        public static string GestprojectVersionName { get; set; } = null;

        internal static string ConnectionString { get; set;  } = null;
        internal static SqlConnection SQLConnection { get; set;  } = null;
    }
}
