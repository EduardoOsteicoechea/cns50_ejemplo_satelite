using ExampleSatelite.Sage50.Datos;
using sage.ew.ewbase;
using sage.ew.global;
using sage.ew.global.Diccionarios;
using System;

namespace ExampleSatelite.Sage50.AvantLeap.SalesBill
{
    internal static class SalesBillValueHolder
    {
        public static string _Error_Message { get; set; } = "";
        public static int _nDigitos { get; set; } = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));
        public static string _Ejercicio { get; set; } = EW_GLOBAL._GetVariable("wc_any").ToString();

        public static bool llretencion = false;
        public static bool llSerFact = true;

        public static string _Cliente = "43000002";

        public static string _SerieFra = "SX";

        public static string _Factura = "SX       1";

        public static int _TipoFactura = 0;
        public static DateTime _FechaAsiento = DateTime.Now;
        public static DateTime _FechaFactura = DateTime.Now;
        public static bool _PresentarVencimientos = false;
        public static bool _ContabilizarCobro = false;
        public static bool _PresentarAsiento = false;

        public static string _AnadirTipoIva1TcCodigo ="03";
        public static decimal _AnadirTipoIva1TnImporte = 1000;

        public static string _AnadirContrapartida1TcCuenta = "70000001";
        public static decimal _AnadirContrapartida1TnImporte = 1500;
        public static bool _AnadirContrapartida1TlEsUnSuplido = false;

        public static string _DefinicionDebe = "";
        public static string _DefinicionHaber = "";

        public static string _Divisa = "000";
        public static decimal _Cambio = 1;

        public static decimal _PrcDtoPP = 0;

        public static decimal _PrcRecFinan = 0;

        public static bool _Recc = false;

        public static bool _IvaIncluido = false;

        public static bool _RecEquiv = false;

        public static string cfgRetencion_Retencion_Codigo = "01";
        public static string cfgRetencion_Retencion_Cuenta = "";
        public static bool cfgRetencion_RetencionSobreBase = false;
        public static bool cfgRetencion_RetencionSobreTotal = true;
        public static decimal cfgRetencion_PrcRetencion = 5;

        public static void ResetVariables()
        {
            _Error_Message = "";
            _nDigitos = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));
            _Ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();

            llretencion = false;
            llSerFact = true;

            _Cliente = "43000002";

            _SerieFra = "SX";

            _Factura = "SX       1";

            _TipoFactura = 0;
            _FechaAsiento = DateTime.Now;
            _FechaFactura = DateTime.Now;
            _PresentarVencimientos = false;
            _ContabilizarCobro = false;
            _PresentarAsiento = false;

            _AnadirTipoIva1TcCodigo = "03";
            _AnadirTipoIva1TnImporte = 1000;

            _AnadirContrapartida1TcCuenta = "70000001";
            _AnadirContrapartida1TnImporte = 1500;
            _AnadirContrapartida1TlEsUnSuplido = false;

            _DefinicionDebe = "";
            _DefinicionHaber = "";

            _Divisa = "000";
            _Cambio = 1;

            _PrcDtoPP = 0;

            _PrcRecFinan = 0;

            _Recc = false;

            _IvaIncluido = false;

            _RecEquiv = false;

            cfgRetencion_Retencion_Codigo = "01";
            cfgRetencion_Retencion_Cuenta = "";
            cfgRetencion_RetencionSobreBase = false;
            cfgRetencion_RetencionSobreTotal = true;
            cfgRetencion_PrcRetencion = 5;
        }
    }
}
