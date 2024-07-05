using sage.ew.docscompra;
using sage.ew.global;
using sage.ew.global.Diccionarios;
using Sage.ES.S50.NuevoEjercicio;
using System;
using static Sage.ES.S50.S50Update.Classes.S50UpdateLog;

namespace ExampleSatelite.Sage50.AvantLeap.ChargeAction
{
    internal static class ChargeActionValueHolder
    {
        public static string _Error_Message { get; set; } = "";
        public static int _nDigitos { get; set; } = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));
        public static string _Ejercicio { get; set; } = EW_GLOBAL._GetVariable("wc_any").ToString();

        public static int _Pendiente { get; set; } = 0;
        public static decimal _Importe { get; set; } = 100;
        public static decimal _EntregaDiv { get; set; } = 100;

        public static bool _LinkForm { get; set; } = false;
        public static DateTime _Fecha { get; set; } = DateTime.Now;
        public static string _Cuenta { get; set; } = "57200001";
        public static string _Divisa { get; set; } = "000";
        public static decimal _Cambio { get; set; } = 1;
        public static string _Definicion { get; set; } = "COBRO FACTURA ";
        public static bool _AsientoPorLinea { get; set; } = false;

        public static bool loNuevaLinea_Automatico { get; set; } = true;
        public static string loNuevaLinea_Cuenta { get; set; } = "43000002";
        public static string loNuevaLinea_DefinicionAsiento { get; set; } = "COBRO FRA. SX1/1";

        public static string loNuevaLinea_Factura { get; set; } = "SX       1";
        public static int loNuevaLinea_Orden_Numereb { get; set; } = 1;
        public static decimal loNuevaLinea_Entrega { get; set; } = _EntregaDiv;
        public static decimal loNuevaLinea_Importe { get; set; } = _Importe;
        public static DateTime loNuevaLinea_Emision { get; set; } = DateTime.Now;
        public static bool loNuevaLinea_Prevision { get; set; } = true;
        public static int loNuevaLinea_Periodo { get; set; } = Convert.ToInt32(_Ejercicio);
        public static int loNuevaLinea_Pendiente { get; set; } = _Pendiente;
        public static DateTime loNuevaLinea_Vencimiento { get; set; } = DateTime.Now.AddDays(30);

        public static string loNuevaLinea_Divisa { get; set; } = "000";
        public static decimal loNuevaLinea_CambioPrevision { get; set; } = 1;

        public static bool _PresentarAsiento { get; set; } = false;

        public static void ResetVariables()
        {
            _Error_Message = "";
            _nDigitos = Convert.ToInt32(EW_GLOBAL._GetLenCampo(KeyDiccionarioLenCampos.wn_digitos));
            _Ejercicio = EW_GLOBAL._GetVariable("wc_any").ToString();

            _Pendiente = 0;
            _Importe = 100;
            _EntregaDiv = 100;

            _LinkForm = false;
            _Fecha = DateTime.Now;
            _Cuenta = "57200001";
            _Divisa = "000";
            _Cambio = 1;
            _Definicion = "COBRO FACTURA ";
            _AsientoPorLinea = false;

            loNuevaLinea_Automatico = true;
            loNuevaLinea_Cuenta = "43000002";
            loNuevaLinea_DefinicionAsiento = "COBRO FRA. SX1/1";

            loNuevaLinea_Factura = "SX       1";
            loNuevaLinea_Orden_Numereb = 1;
            loNuevaLinea_Entrega = _EntregaDiv;
            loNuevaLinea_Importe = _Importe;
            loNuevaLinea_Emision = DateTime.Now;
            loNuevaLinea_Prevision = true;
            loNuevaLinea_Periodo = Convert.ToInt32(_Ejercicio);
            loNuevaLinea_Pendiente = _Pendiente;
            loNuevaLinea_Vencimiento = DateTime.Now.AddDays(30);

            loNuevaLinea_Divisa = "000";
            loNuevaLinea_CambioPrevision = 1;

            _PresentarAsiento = false;
        }
    }
}
