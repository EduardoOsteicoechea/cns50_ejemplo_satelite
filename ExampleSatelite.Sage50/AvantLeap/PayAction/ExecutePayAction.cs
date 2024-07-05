using sage.ew.contabilidad;
using sage.ew.global.Diccionarios;
using sage.ew.global;
using System;
using Sage.ES.S50.NuevoEjercicio;
using static Sage.ES.S50.S50Update.Classes.S50UpdateLog;

namespace ExampleSatelite.Sage50.AvantLeap.PayAction
{
    internal class ExecutePayAction
    {
        public ExecutePayAction()
        {
            EW_GLOBAL._GetAllVariable();
            AsientosPagosGeneradorLinea loNuevaLinea = null;
            AsientosPagosGenerador loPago = new AsientosPagosGenerador();

            loPago._LinkForm = PayActionValueHolder._LinkForm;
            loPago._Fecha = PayActionValueHolder._Fecha;
            loPago._Cuenta = PayActionValueHolder._Cuenta;
            loPago._Divisa = PayActionValueHolder._Divisa;
            loPago._Cambio = PayActionValueHolder._Cambio;
            loPago._Definicion = PayActionValueHolder._Definicion;
            loPago._AsientoPorLinea = PayActionValueHolder._AsientoPorLinea;

            loNuevaLinea = new AsientosPagosGeneradorLinea(loPago);

            loNuevaLinea._Automatico = PayActionValueHolder.loNuevaLinea_Automatico;
            loNuevaLinea._Cuenta = PayActionValueHolder.loNuevaLinea_Cuenta;
            loNuevaLinea._DefinicionAsiento = PayActionValueHolder.loNuevaLinea_DefinicionAsiento;

            loNuevaLinea._Factura = PayActionValueHolder.loNuevaLinea_Factura;
            ;
            loNuevaLinea._Orden_Numereb = PayActionValueHolder.loNuevaLinea_Orden_Numereb;
            loNuevaLinea._Entrega = PayActionValueHolder.loNuevaLinea_Entrega;
            loNuevaLinea._Importe = PayActionValueHolder.loNuevaLinea_Importe;
            loNuevaLinea._Emision = PayActionValueHolder.loNuevaLinea_Emision;
            loNuevaLinea._Prevision = PayActionValueHolder.loNuevaLinea_Prevision;
            loNuevaLinea._Periodo = PayActionValueHolder.loNuevaLinea_Periodo;
            loNuevaLinea._Pendiente = PayActionValueHolder.loNuevaLinea_Pendiente;
            loNuevaLinea._Vencimiento = PayActionValueHolder.loNuevaLinea_Vencimiento;

            loNuevaLinea._Divisa = PayActionValueHolder._Divisa;
            loNuevaLinea._CambioPrevision = PayActionValueHolder.loNuevaLinea_CambioPrevision;

            loPago._Detalle.Add(loNuevaLinea);

            loPago._PresentarAsiento = PayActionValueHolder._PresentarAsiento;

            bool llOk = loPago._Generar_Asiento();
            if(!llOk)
                PayActionValueHolder._Error_Message = loPago._Error_Message.Trim();
        }
    }
}
