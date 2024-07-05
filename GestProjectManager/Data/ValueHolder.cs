using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProjectManager.Data
{
    public static class ValueHolder
    {
        // DatabaseConnection
        // DatabaseConnection
        // DatabaseConnection
        // DatabaseConnection
        public static string WindowsIdentityDomainName { get; set; } = null;
        public static string WindowsIdentityUserName { get; set; } = null;
        public static List<string> GestprojectVersionNames { get; set; } = null;
        public static string GestprojectVersionName { get; set; } = null;

        internal static string ConnectionString { get; set;  } = null;
        internal static SqlConnection SQLConnection { get; set;  } = null;

        // DataFilters
        // DataFilters
        // DataFilters
        // DataFilters

        internal static string FilterDatesType { get; set; } = null;
        internal static DateTime? FilterStartDate { get; set; } = null;
        internal static DateTime? FilterEndDate { get; set; } = null;
    }
}
