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

namespace GestProjectManager.DataFilters
{
    internal class CreateSQLCommandConditional
    {
        public bool Error { get; set; } = true;
        public CreateSQLCommandConditional() 
        {
            
            ValueHolder.SQLConnection.Open();

            new CreateParameterizedSelectSQLCommand(
                ClientesTableData.FieldsToQuery,
                ClientesTableData.DateFilterableField1,
                ClientesTableData.Table1Name,
                ValueHolder.FilterDatesType
            );

            new CreateParameterizedSelectSQLCommand(
                ProveedoresTableData.FieldsToQuery,
                ProveedoresTableData.DateFilterableField1,
                ProveedoresTableData.Table1Name,
                ValueHolder.FilterDatesType
            );

            new CreateParameterizedSelectSQLCommand(
                ImpuestosTableData.FieldsToQuery,
                ImpuestosTableData.DateFilterableField1,
                ImpuestosTableData.Table1Name,
                ValueHolder.FilterDatesType
            );

            new CreateParameterizedSelectSQLCommand(
                ProyectosTableData.FieldsToQuery,
                ProyectosTableData.DateFilterableField1,
                ProyectosTableData.Table1Name,
                ValueHolder.FilterDatesType
            );

            new CreateParameterizedSelectSQLCommand(
                FacturasEmitidasTableData.FieldsToQuery,
                FacturasEmitidasTableData.DateFilterableField1,
                FacturasEmitidasTableData.Table1Name,
                ValueHolder.FilterDatesType
            );

            ValueHolder.SQLConnection.Close();    
        }
    }
}
