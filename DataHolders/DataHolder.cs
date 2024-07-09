using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHolders
{
    public static class DataHolder
    {
        // DatabaseConnection
        // DatabaseConnection
        // DatabaseConnection
        // DatabaseConnection
        public static string WindowsIdentityDomainName { get; set; } = null;
        public static string WindowsIdentityUserName { get; set; } = null;
        public static List<string> GestprojectVersionNames { get; set; } = null;
        public static string GestprojectVersionName { get; set; } = null;

        internal static string ConnectionString { get; set; } = null;
        internal static SqlConnection SQLConnection { get; set; } = null;

        // DataFilters
        // DataFilters
        // DataFilters
        // DataFilters

        internal static string FilterDatesType { get; set; } = null;
        internal static DateTime? FilterStartDate { get; set; } = null;
        internal static DateTime? FilterEndDate { get; set; } = null;

        // SelectSqlCommand
        // SelectSqlCommand
        // SelectSqlCommand
        // SelectSqlCommand
        internal static string ClientesSelectCommand { get; set; } = null;
        internal static string ProveedoresSelectCommand { get; set; } = null;
        internal static string ImpuestosSelectCommand { get; set; } = null;
        internal static string ProyectosSelectCommand { get; set; } = null;
        internal static string FacturasEmitidasSelectCommand { get; set; } = null;

        // ExecuteSelecSQLCommand
        // ExecuteSelecSQLCommand
        // ExecuteSelecSQLCommand
        // ExecuteSelecSQLCommand
        // ExecuteSelecSQLCommand


        internal static List<Cliente> ClienteClassList { get; set; } = new List<Cliente>();
        internal static List<Proveedor> ProveedorClassList { get; set; } = new List<Proveedor>();
        internal static List<Impuesto> ImpuestoClassList { get; set; } = new List<Impuesto>();
        internal static List<Proyecto> ProyectoClassList { get; set; } = new List<Proyecto>();
        internal static List<FacturaEmitida> FacturaEmitidaClassList { get; set; } = new List<FacturaEmitida>();
    }
}
