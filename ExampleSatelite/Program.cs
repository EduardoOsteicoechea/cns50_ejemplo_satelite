using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

//
using ExampleSatelite.Clases;
using ExampleSatelite.Forms;
using ExampleSatelite.Sage50.AvantLeap.SalesBill;
using GestProjectManager;

//using ExampleSatelite.Sage50;

namespace ExampleSatelite
{
    static class Program
    {

        public static string _sdirectoryPath = "";
        public static string _sfileConfig = "";
        public static bool _bAutomatic = false;
        public static bool _bDebug = false;

        public static clsConfig _oConfig = null;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// static void Main(string[] args)
        [STAThread]
        static void Main(string[] args)
        {

            new ProvideSincronizableItems();

            //Boolean llOkAuto = false;

            //// Establecemos la clase de configuración
            //_oConfig = new clsConfig();

            ////// control para saber si, se está ejecutando el programa más de una vez.
            ////Process[] processes = Process.GetProcessesByName("ExampleSatelite");
            ////bool _benEjecucion = (processes.Length > 1);

            //_sfileConfig = "examplesatelite.ini";
            //_sdirectoryPath = Application.StartupPath;

            //_oConfig._FileConfig = _sfileConfig;
            //_oConfig._PathConfig = _sdirectoryPath;
            //_oConfig._LoadConfig();

            //// Carpeta del terminal de Sage50
            //_CargarCarpetaSage50();

            //llOkAuto = _ObtenerParametros(args);

            //// Se debe ejecutar visualmente
            //if(llOkAuto == false)
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);

            //    // cargamos el formulario de menú principal
            //    Application.Run(new frmMain());
            //}
            //else
            //{
            //    // ejecutar procesos automáticos
            //}

            //_oConfig = null;

        }



        /// <summary>
        /// Método para obtener los posibles parámetros en el arranque automático
        /// Dependerá de lo que necesite ejecutar o controlar la aplicación de forma automática
        /// </summary>
        /// <param name="tcArgs"></param>
        private static bool _ObtenerParametros(string[] tcArgs)
        {
            bool lbParamValid = false;

            if(tcArgs != null && tcArgs.Count() > 0)
            {
                // Ahora tenemos todos los parámetros juntos separados por '|'
                string lcParams = tcArgs[0].Trim().Substring(1);

                // Obtener parámetros por separado y recorrerlos para cargar sus valores.
                string[] lcArgs = lcParams.Split('|');

                if(lcArgs.Count() > 2)
                {
                    lbParamValid = true;

                    //int lnArg = 0;
                    //foreach (string lcArg in lcArgs)
                    //{
                    //    // Los 3 primeros parámetros serán USUARIO, PASSWORD y FORMULARIO
                    //    switch (lnArg)
                    //    {
                    //        case 0:
                    //            _cUserEurowin = lcArgs[0];
                    //            break;

                    //        case 1:
                    //            _cPasswordEurowin = lcArgs[1];
                    //            break;

                    //        case 2:
                    //            _cFormEurowin = lcArgs[2];
                    //            break;
                    //    }

                    //    // El resto de parámetros serán los posibles parámetros del FORMULARIO a ejecutar
                    //    if (lnArg >= 3)
                    //    {
                    //        if (!string.IsNullOrWhiteSpace(_cParamsFormEurowin) && lcArg == "ACCESODIRECTO")
                    //            _cParamsFormEurowin += "*";

                    //        _cParamsFormEurowin += lcArg;
                    //    }

                    //    lnArg++;
                    //}
                }
            }

            return lbParamValid;
        }

        /// <summary>
        /// Cargamos las carpeta donde se encuentra el terminal de Sage50
        /// Para tener visibilidad del exe y dlls
        /// </summary>
        public static void _CargarCarpetaSage50()
        {
            // Rutas validas de Sage50
            if(!string.IsNullOrEmpty(_oConfig._Sage50Terminal))
            {
                // 1. terminal de sage50
                clsFunctions._LoadDllDynamicFromPath(_oConfig._Sage50Terminal);

                // 2. terminal de sage50\Librerias
                clsFunctions._LoadDllDynamicFromPath(Path.Combine(_oConfig._Sage50Terminal, "Librerias\\"));

            }

        }

    }
}
