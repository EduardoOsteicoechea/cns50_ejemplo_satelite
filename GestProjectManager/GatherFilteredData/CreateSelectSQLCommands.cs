using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.GatherFilteredData
{
    internal class CreateSelectSQLCommands
    {
        public bool Error { get; set; } = true;
        public CreateSelectSQLCommands() 
        {
            ValueHolder.ClientesSelectCommand = new CreateSelectSQLCommandString(
                ClientesTableData.FieldsToQuery,
                ClientesTableData.DateFilterableField1,
                ClientesTableData.Table1Name,
                ValueHolder.FilterDatesType
            ).CommandString;

            ValueHolder.ProveedoresSelectCommand = new CreateSelectSQLCommandString(
                ProveedoresTableData.FieldsToQuery,
                ProveedoresTableData.DateFilterableField1,
                ProveedoresTableData.Table1Name,
                ValueHolder.FilterDatesType
            ).CommandString;

            ValueHolder.ImpuestosSelectCommand = new CreateSelectSQLCommandString(
                ImpuestosTableData.FieldsToQuery,
                ImpuestosTableData.DateFilterableField1,
                ImpuestosTableData.Table1Name,
                ValueHolder.FilterDatesType
            ).CommandString;

            ValueHolder.ProyectosSelectCommand = new CreateSelectSQLCommandString(
                ProyectosTableData.FieldsToQuery,
                ProyectosTableData.DateFilterableField1,
                ProyectosTableData.Table1Name,
                ValueHolder.FilterDatesType
            ).CommandString;

            ValueHolder.FacturasEmitidasSelectCommand = new CreateSelectSQLCommandString(
                FacturasEmitidasTableData.FieldsToQuery,
                FacturasEmitidasTableData.DateFilterableField1,
                FacturasEmitidasTableData.Table1Name,
                ValueHolder.FilterDatesType
            ).CommandString;

            Error = false;
        }
    }
}
