using sage.ew.global;
using sage.ew.global.Diccionarios;
using Sage.ES.S50.NuevoEjercicio;
using System;

namespace ExampleSatelite.Sage50.AvantLeap.PaymentBill
{
    internal static class PaymentBillValueHolder
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
        public static string _Definicion { get; set; } = "COBRO FACTURA";
        public static bool _AsientoPorLinea { get; set; } = false;
        public static bool NuevaLinea_Automatico { get; set; } = true;
        public static string NuevaLinea_Cuenta { get; set; } = "43000002";
        public static string NuevaLinea_DefinicionAsiento { get; set; } = "COBRO FRA. SX1/1";
        public static string NuevaLinea_Factura { get; set; } = "SX       1";
        public static int NuevaLinea_Orden_Numereb { get; set; } = 1;
        public static decimal NuevaLinea_Entrega { get; set; } = 1;
        public static decimal NuevaLinea_Importe { get; set; } = 0;
        public static DateTime NuevaLinea_Emision { get; set; } = DateTime.Now;
        public static bool NuevaLinea_Prevision { get; set; } = true;
        public static int NuevaLinea_Periodo { get; set; } = Convert.ToInt32(_Ejercicio);
        public static int NuevaLinea_Pendiente { get; set; } = _Pendiente;
        public static DateTime NuevaLinea_Vencimiento { get; set; } = DateTime.Now.AddDays(30);
        public static string NuevaLinea_Divisa { get; set; } = "000";
        public static decimal NuevaLinea_CambioPrevision { get; set; } = 1;

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
            _Definicion = "COBRO FACTURA";
            _AsientoPorLinea = false;
            NuevaLinea_Automatico = true;
            NuevaLinea_Cuenta = "43000002";
            NuevaLinea_DefinicionAsiento = "COBRO FRA. SX1/1";
            NuevaLinea_Factura = "SX       1";
            NuevaLinea_Orden_Numereb = 1;
            NuevaLinea_Entrega = 1;
            NuevaLinea_Importe = 0;
            NuevaLinea_Emision = DateTime.Now;
            NuevaLinea_Prevision = true;
            NuevaLinea_Periodo = Convert.ToInt32(_Ejercicio);
            NuevaLinea_Pendiente = _Pendiente;
            NuevaLinea_Vencimiento = DateTime.Now.AddDays(30);
            NuevaLinea_Divisa = "000";
            NuevaLinea_CambioPrevision = 1;
        }
    }
}
