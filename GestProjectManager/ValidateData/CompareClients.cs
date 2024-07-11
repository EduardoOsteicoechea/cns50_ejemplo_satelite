
using ExampleSatelite.Sage50.Datos;
using ExampleSatelite.Sage50;
using GestProjectManager.Data;
using sage.ew.cliente;
using sage.ew.db;
using sage.ew.global.Diccionarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sage.ew.db.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ExampleSatelite.Sage50.Negocio;
using System.Data;

namespace GestProjectManager.ValidateData
{
    internal class CompareClients
    {
        public dynamic _oEntidad;

        private bool EditandoFicha = false;
        private bool NuevaFicha = false;

        private int _nDigitos = Convert.ToInt32(sage.ew.global.EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));

        private string _codigo = string.Empty;
        public bool Error { get; set; } = true;
        public CompareClients()
        {
            //MessageBox.Show(
            //    ValueHolder.ClienteClassList.Where(element => 
            //        element.PAR_NOMBRE.Contains("David") && 
            //        element.PAR_CIF_NIF == "999999999"
            //    ).FirstOrDefault().PAR_CIF_NIF
            //);

            int counter = 6;
            for(int i = 0; i < ValueHolder.ClienteClassList.Count; i++)
            //for (int i = 0; i < ValueHolder.ProveedorClassList.Count; i++)
            {
                //GestProjectManager.Data.Proveedor currentClient = ValueHolder.ProveedorClassList[i];
                GestProjectManager.Data.Cliente currentClient = ValueHolder.ClienteClassList[i];
                Customer customer = new Customer();
                //Sage50ProviderSampleClass customer = new Sage50ProviderSampleClass();
                //clsEntityProvider clsEntityCustomerInstance = new clsEntityProvider();
                clsEntityCustomer clsEntityCustomerInstance = new clsEntityCustomer();

                //if(counter < 10)
                //{
                //    clsEntityCustomerInstance.codigo = "4000000" + counter;
                //}
                //else if(counter < 100)
                //{
                //    clsEntityCustomerInstance.codigo = "400000" + counter;
                //}
                //else
                //{
                //    clsEntityCustomerInstance.codigo = "40000" + counter;
                //};

                if(counter < 10)
                {
                    clsEntityCustomerInstance.codigo = "4400000" + counter;
                }
                else if(counter < 100)
                {
                    clsEntityCustomerInstance.codigo = "440000" + counter;
                }
                else
                {
                    clsEntityCustomerInstance.codigo = "44000" + counter;
                };

                //clsEntityCustomerInstance.telefono = "4147281033";
                clsEntityCustomerInstance.nombre = currentClient.PAR_NOMBRE;
                clsEntityCustomerInstance.direccion = currentClient.PAR_DIRECCION_1;
                clsEntityCustomerInstance.codpos = currentClient.PAR_CP_1;
                clsEntityCustomerInstance.tipo_iva = "03";
                clsEntityCustomerInstance.cif = currentClient.PAR_CIF_NIF;
                //customer._Create(clsEntityCustomerInstance);
                //customer._Update(clsEntityCustomerInstance);
                customer._Delete(clsEntityCustomerInstance);

                counter++;
            };

            //ValueHolder.Sage50ClientsTable = new ExampleSatelite.Sage50.Negocio.Sage50ProviderSampleClass()._LoadTable("");
            //ValueHolder.Sage50ClientsTable = new ExampleSatelite.Sage50.Negocio.Customer()._LoadTable("");

            //for(int i = 0; i < ValueHolder.Sage50ClientsTable.Rows.Count; i++)
            //{
            //    MessageBox.Show(
            //        "Cliente " + (i + 1) + ":" + "\n" +
            //        ValueHolder.Sage50ClientsTable.Rows[i].ItemArray[0] + "\n" +
            //        ValueHolder.Sage50ClientsTable.Rows[i].ItemArray[2] + "\n"
            //    );
            //};

            Error = false;
        }
    }
}




//sage.ew.cliente.Cliente ccc = new sage.ew.cliente.Cliente();
//MessageBox.Show(ccc.ToString());

////DB.Conexion = $"Server=EDUARDO\\SQLSAGE50_7;Database={DB.SQLDatabase("GESTION")};Trusted_Connection=true";
//DB.Conexion = $"Server=EDUARDO\\SQLSAGE50_7;Database=2024HA;Trusted_Connection=true";

//MessageBox.Show(
//    new sage.ew.db.DB._TableInformationSchema("2024HA", "clientes")._TipoCampo("CODIGO")
//    //new sage.ew.db.DB._TableInformationSchema("GESTION", "clientes")._TipoCampo("CODIGO")
//);

//if(DB.SQLExec($"SELECT * FROM clientes"))
//{
//    MessageBox.Show(DB.SQLREGValor("clientes", "","codigo").Count + "");
//    MessageBox.Show("\"DB.SQLExec($\"SELECT * FROM {DB.SQLExisteTabla(\"CLIENTES\")}\")");
//    //MessageBox.Show("\"DB.SQLExec($\"SELECT * FROM {DB.SQLExisteTabla(\"CLIENTES\")}\")");
//};

//clsEntityCustomer _oEntidad = new clsEntityCustomer();

//MessageBox.Show(_oEntidad.ToString());
