using sage.ew.global;
using sage.ew.global.Diccionarios;
using Sage.ES.S50.NuevoEjercicio;
using System;

namespace ExampleSatelite.Sage50.AvantLeap.PurchaseBill
{
    internal static class PurchaseBillValueHolder
    {
        public static string _Error_Message { get; set; } = "";
        public static int _nDigitos { get; set; } = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));
        public static string _Ejercicio { get; set; } = EW_GLOBAL._GetVariable("wc_any").ToString();
        public static int _LongFactCompra { get; set; } = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_factcompra));

        public static string _Proveedor { get; set; } = "40000001";
        public static DateTime _FechaAsiento { get; set; } = DateTime.Now;
        public static DateTime _FechaFactura { get; set; } = DateTime.Now;
        public static string _Factura { get; set; } = "FCXYZ1000";
        public static string _Divisa { get; set; } = "000";
        public static decimal _Cambio { get; set; } = 1;

        public static bool _IvaIncluido { get; set; } = false;

        public static string _AnadirTipoIvaTipo { get; set; } = "03";
        public static decimal _AnadirTipoIvaMontoDePartida { get; set; } = 900;

        public static string _AnadirContrapartidaTcCuenta { get; set; } = "60000001";
        public static decimal _AnadirContrapartidaTnImporte { get; set; } = 1500;
        public static bool _AnadirContrapartidaTlEsUnSuplido { get; set; } = false;

        public static string _DefinicionDebe { get; set; } = "";
        public static string _DefinicionHaber { get; set; } = "43000002";

        public static bool _PresentarVencimientos { get; set; } = false;
        public static bool _ContabilizarPago { get; set; } = false;
        public static bool _PresentarFechaBancoPago { get; set; } = false;
        public static bool _PresentarAsiento { get; set; } = false;

        public static string _CuentaBancoPago { get; set; } = "";
        public static DateTime? _FechaPago { get; set; } = null;
        public static decimal _PrcDtoPP { get; set; } = 0.0M;
        public static bool _AplicaRetPro { get; set; } = false;

        public static void ResetVariables() 
        {
            _Error_Message = "";
            _nDigitos = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));
            _Ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();
            _LongFactCompra = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_factcompra));

            _Proveedor = "40000001";
            _FechaAsiento = DateTime.Now;
            _FechaFactura = DateTime.Now;
            _Factura = "FCXYZ1000";
            _Divisa = "000";
            _Cambio = 1;

            _IvaIncluido = false;

            _AnadirTipoIvaTipo = "03";
            _AnadirTipoIvaMontoDePartida = 900;

            _AnadirContrapartidaTcCuenta = "60000001";
            _AnadirContrapartidaTnImporte = 1500;
            _AnadirContrapartidaTlEsUnSuplido = false;

            _DefinicionDebe = "";
            _DefinicionHaber = "43000002";

            _PresentarVencimientos = false;
            _ContabilizarPago = false;
            _PresentarFechaBancoPago = false;
            _PresentarAsiento = false;

            _CuentaBancoPago = "";
            _FechaPago = null;
            _PrcDtoPP = 0.0M;
            _AplicaRetPro = false;
        }
    }
}
