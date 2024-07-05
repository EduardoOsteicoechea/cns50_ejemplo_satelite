using sage.ew.contabilidad;
using sage.ew.global.Diccionarios;
using sage.ew.global;
using System;

namespace ExampleSatelite.Sage50.AvantLeap.PurchaseBill
{
    internal class CreatePurchaseBill
    {
        public CreatePurchaseBill()
        {
            EW_GLOBAL._GetAllVariable();
            ParamGenFactCompra toCfgGenFactCompra = new ParamGenFactCompra();

            toCfgGenFactCompra._Proveedor = PurchaseBillValueHolder._Proveedor;
            toCfgGenFactCompra._FechaAsiento = PurchaseBillValueHolder._FechaAsiento;
            toCfgGenFactCompra._FechaFactura = PurchaseBillValueHolder._FechaFactura;

            toCfgGenFactCompra._Factura = PurchaseBillValueHolder._Factura;
            toCfgGenFactCompra._Factura = toCfgGenFactCompra._Factura.Trim().PadLeft(PurchaseBillValueHolder._LongFactCompra, ' ');
            toCfgGenFactCompra._Divisa = PurchaseBillValueHolder._Divisa;
            toCfgGenFactCompra._Cambio = PurchaseBillValueHolder._Cambio;

            toCfgGenFactCompra._IvaIncluido = PurchaseBillValueHolder._IvaIncluido;

            toCfgGenFactCompra._AnadirTipoIva(PurchaseBillValueHolder._AnadirTipoIvaTipo, PurchaseBillValueHolder._AnadirTipoIvaMontoDePartida);

            toCfgGenFactCompra._AnadirContrapartida(
                PurchaseBillValueHolder._AnadirContrapartidaTcCuenta, 
                PurchaseBillValueHolder._AnadirContrapartidaTnImporte,
                PurchaseBillValueHolder._AnadirContrapartidaTlEsUnSuplido
            );

            toCfgGenFactCompra._DefinicionDebe = PurchaseBillValueHolder._DefinicionDebe;
            toCfgGenFactCompra._DefinicionHaber = PurchaseBillValueHolder._DefinicionHaber;

            toCfgGenFactCompra._PresentarVencimientos = PurchaseBillValueHolder._PresentarVencimientos;
            toCfgGenFactCompra._ContabilizarPago = PurchaseBillValueHolder._ContabilizarPago;
            toCfgGenFactCompra._PresentarFechaBancoPago = PurchaseBillValueHolder._PresentarFechaBancoPago;
            toCfgGenFactCompra._PresentarAsiento = PurchaseBillValueHolder._PresentarAsiento;

            toCfgGenFactCompra._CuentaBancoPago = PurchaseBillValueHolder._CuentaBancoPago;
            toCfgGenFactCompra._FechaPago = PurchaseBillValueHolder._FechaPago;
            toCfgGenFactCompra._PrcDtoPP = PurchaseBillValueHolder._PrcDtoPP;
            toCfgGenFactCompra._AplicaRetPro = PurchaseBillValueHolder._AplicaRetPro;

            AsientosFacturasCompraGenerador loGenAsiFacComp = new AsientosFacturasCompraGenerador();
            bool llOk = loGenAsiFacComp._GenerarFacturaRapida(toCfgGenFactCompra);

            if(!llOk) PurchaseBillValueHolder._Error_Message = loGenAsiFacComp._Error_Message.Trim();
        }
    }
}
