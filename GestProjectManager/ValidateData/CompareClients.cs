
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

            Customer _oCustomer = new Customer();
            clsEntityCustomer clsEntityCustomerInstance = new clsEntityCustomer();
            clsEntityCustomerInstance.codigo = "00000222";

            _oCustomer._Create(clsEntityCustomerInstance);


            for(int i = 0; i < ValueHolder.Sage50ClientsTable.Rows.Count; i++)
            {
                MessageBox.Show(
                    "Cliente " + (i + 1) + ":" + "\n" +
                    ValueHolder.Sage50ClientsTable.Rows[i].ItemArray[0] + "\n" +
                    ValueHolder.Sage50ClientsTable.Rows[i].ItemArray[2] + "\n"
                );
            };


            //ValueHolder.Sage50ClientForm.



            //for (int i = 0; i < ValueHolder.ClienteClassList.Count; i++)
            //{
            //    Data.Cliente currentClient = ValueHolder.ClienteClassList[i];
            //    MessageBox.Show(
            //        currentClient.PAR_NOMBRE + "\n" +
            //        currentClient.PAR_NOMBRE_COMERCIAL + "\n" +
            //        currentClient.PAR_CIF_NIF + "\n" +
            //        currentClient.PAR_DIRECCION_1 + "\n" +
            //        currentClient.PAR_PROVINCIA_1 + "\n" +
            //        currentClient.PAR_PAIS_1 + "\n"
            //    );
            //}



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
