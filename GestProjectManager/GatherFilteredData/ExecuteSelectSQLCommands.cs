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
    internal class ExecuteSelectSQLCommands
    {
        public bool Error { get; set; } = true;
        public List<Cliente> ClienteClassList { get; set; } = new List<Cliente>();  
        public List<Proveedor> ProveedorClassList { get; set; } = new List<Proveedor>();  
        public List<Impuesto> ImpuestoClassList { get; set; } = new List<Impuesto>();  
        public List<Proyecto> ProyectoClassList { get; set; } = new List<Proyecto>();  
        public List<FacturaEmitida> FacturaEmitidaClassList { get; set; } = new List<FacturaEmitida>();  
        public ExecuteSelectSQLCommands() 
        {
            ValueHolder.ClienteClassList = 
            new ExecuteSelectSQLCommand<Cliente>(ValueHolder.ClientesSelectCommand, new Cliente().GetType()).ClassList;

            ValueHolder.ProveedorClassList = 
            new ExecuteSelectSQLCommand<Proveedor>(ValueHolder.ProveedoresSelectCommand, new Proveedor().GetType()).ClassList;

            ValueHolder.ImpuestoClassList = 
            new ExecuteSelectSQLCommand<Impuesto>(ValueHolder.ImpuestosSelectCommand, new Impuesto().GetType()).ClassList;

            ValueHolder.ProyectoClassList = 
            new ExecuteSelectSQLCommand<Proyecto>(ValueHolder.ProyectosSelectCommand, new Proyecto().GetType()).ClassList;

            ValueHolder.FacturaEmitidaClassList = 
            new ExecuteSelectSQLCommand<FacturaEmitida>(ValueHolder.FacturasEmitidasSelectCommand, new FacturaEmitida().GetType()).ClassList;

            Error = false;
        }
    }
}
