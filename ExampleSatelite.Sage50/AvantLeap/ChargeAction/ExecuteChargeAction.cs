using sage.ew.contabilidad;
using sage.ew.global.Diccionarios;
using sage.ew.global;
using System;

namespace ExampleSatelite.Sage50.AvantLeap.ChargeAction
{
    internal class ExecuteChargeAction
    {
        public ExecuteChargeAction()
        {
            EW_GLOBAL._GetAllVariable();
            AsientosCobrosGeneradorLinea loNuevaLinea = null;
            AsientosCobrosGenerador loCobro = new AsientosCobrosGenerador();

            loCobro._LinkForm = ChargeActionValueHolder._LinkForm;
            loCobro._Fecha = ChargeActionValueHolder._Fecha;
            loCobro._Cuenta = ChargeActionValueHolder._Cuenta;
            loCobro._Divisa = ChargeActionValueHolder._Divisa;
            loCobro._Cambio = ChargeActionValueHolder._Cambio;
            loCobro._Definicion = ChargeActionValueHolder._Definicion;
            loCobro._AsientoPorLinea = ChargeActionValueHolder._AsientoPorLinea;

            loNuevaLinea = new AsientosCobrosGeneradorLinea(loCobro);

            loNuevaLinea._Automatico = ChargeActionValueHolder.loNuevaLinea_Automatico;
            loNuevaLinea._Cuenta = ChargeActionValueHolder.loNuevaLinea_Cuenta;
            loNuevaLinea._DefinicionAsiento = ChargeActionValueHolder.loNuevaLinea_DefinicionAsiento;

            loNuevaLinea._Factura = ChargeActionValueHolder.loNuevaLinea_Factura;
            loNuevaLinea._Orden_Numereb = ChargeActionValueHolder.loNuevaLinea_Orden_Numereb;
            loNuevaLinea._Entrega = ChargeActionValueHolder.loNuevaLinea_Entrega;
            loNuevaLinea._Importe = ChargeActionValueHolder.loNuevaLinea_Importe;
            loNuevaLinea._Emision = ChargeActionValueHolder.loNuevaLinea_Emision;
            loNuevaLinea._Prevision = ChargeActionValueHolder.loNuevaLinea_Prevision;
            loNuevaLinea._Periodo = ChargeActionValueHolder.loNuevaLinea_Periodo;
            loNuevaLinea._Pendiente = ChargeActionValueHolder.loNuevaLinea_Pendiente;
            loNuevaLinea._Vencimiento = ChargeActionValueHolder.loNuevaLinea_Vencimiento;

            loNuevaLinea._Divisa = ChargeActionValueHolder.loNuevaLinea_Divisa;
            loNuevaLinea._CambioPrevision = ChargeActionValueHolder.loNuevaLinea_CambioPrevision;

            loCobro._Detalle.Add(loNuevaLinea);

            loCobro._PresentarAsiento = ChargeActionValueHolder._PresentarAsiento;

            bool llOk = loCobro._Generar_Asiento();
            if(!llOk) ChargeActionValueHolder._Error_Message = loCobro._Error_Message.Trim();
        }
    }
}
