using sage.ew.contabilidad;
using sage.ew.global.Diccionarios;
using sage.ew.global;
using System;

namespace ExampleSatelite.Sage50.AvantLeap.PaymentBill
{
    internal class CreatePayBill
    {
        public CreatePayBill()
        {
            EW_GLOBAL._GetAllVariable();

            int _Pendiente = PaymentBillValueHolder._Pendiente;
            decimal _Importe = PaymentBillValueHolder._Importe;
            decimal _EntregaDiv = PaymentBillValueHolder._EntregaDiv;

            AsientosCobrosGeneradorLinea loNuevaLinea = null;

            AsientosCobrosGenerador loCobro = new AsientosCobrosGenerador();

            loCobro._LinkForm = PaymentBillValueHolder._LinkForm;
            loCobro._Fecha = PaymentBillValueHolder._Fecha;
            loCobro._Cuenta = PaymentBillValueHolder._Cuenta;
            loCobro._Divisa = PaymentBillValueHolder._Divisa;
            loCobro._Cambio = PaymentBillValueHolder._Cambio;
            loCobro._Definicion = PaymentBillValueHolder._Definicion;
            loCobro._AsientoPorLinea = PaymentBillValueHolder._AsientoPorLinea;

            loNuevaLinea = new AsientosCobrosGeneradorLinea(loCobro);
            loNuevaLinea._Automatico = PaymentBillValueHolder.NuevaLinea_Automatico;
            loNuevaLinea._Cuenta = PaymentBillValueHolder.NuevaLinea_Cuenta;
            loNuevaLinea._DefinicionAsiento = PaymentBillValueHolder.NuevaLinea_DefinicionAsiento;
            loNuevaLinea._Factura = PaymentBillValueHolder.NuevaLinea_Factura;
            loNuevaLinea._Orden_Numereb = PaymentBillValueHolder.NuevaLinea_Orden_Numereb;
            loNuevaLinea._Entrega = PaymentBillValueHolder.NuevaLinea_Entrega;
            loNuevaLinea._Importe = PaymentBillValueHolder.NuevaLinea_Importe;
            loNuevaLinea._Emision = PaymentBillValueHolder.NuevaLinea_Emision;
            loNuevaLinea._Prevision = PaymentBillValueHolder.NuevaLinea_Prevision;
            loNuevaLinea._Periodo = PaymentBillValueHolder.NuevaLinea_Periodo;
            loNuevaLinea._Pendiente = PaymentBillValueHolder.NuevaLinea_Pendiente;
            loNuevaLinea._Vencimiento = PaymentBillValueHolder.NuevaLinea_Vencimiento;
            loNuevaLinea._Divisa = PaymentBillValueHolder.NuevaLinea_Divisa;
            loNuevaLinea._CambioPrevision = PaymentBillValueHolder.NuevaLinea_CambioPrevision;

            loCobro._Detalle.Add(loNuevaLinea);
            loCobro._PresentarAsiento = false;
            bool llOk = loCobro._Generar_Asiento();
            if(!llOk) PaymentBillValueHolder._Error_Message = loCobro._Error_Message.Trim();
        }
    }
}
