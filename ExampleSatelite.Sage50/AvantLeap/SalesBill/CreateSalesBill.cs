using sage.ew.contabilidad;
using sage.ew.global.Diccionarios;
using sage.ew.global;
using System;
using System.Windows.Forms;

namespace ExampleSatelite.Sage50.AvantLeap.SalesBill
{
    internal class CreateSalesBill
    {
        public CreateSalesBill()
        {
            EW_GLOBAL._GetAllVariable();
            ParamGenFactVenta toCfgGenFactVenta = new ParamGenFactVenta();

            toCfgGenFactVenta._Cliente = SalesBillValueHolder._Cliente;
            toCfgGenFactVenta._SerieFra = SalesBillValueHolder._SerieFra;
            toCfgGenFactVenta._Factura = SalesBillValueHolder._Factura;
            toCfgGenFactVenta._TipoFactura = SalesBillValueHolder._TipoFactura;
            toCfgGenFactVenta._FechaAsiento = SalesBillValueHolder._FechaAsiento;
            toCfgGenFactVenta._FechaFactura = SalesBillValueHolder._FechaFactura;
            toCfgGenFactVenta._PresentarVencimientos = SalesBillValueHolder._PresentarVencimientos;
            toCfgGenFactVenta._ContabilizarCobro = SalesBillValueHolder._ContabilizarCobro;
            toCfgGenFactVenta._PresentarAsiento = SalesBillValueHolder._PresentarAsiento;

            toCfgGenFactVenta._AnadirTipoIva(
            SalesBillValueHolder._AnadirTipoIva1TcCodigo, 
            SalesBillValueHolder._AnadirTipoIva1TnImporte
            );

            toCfgGenFactVenta._AnadirContrapartida(
                SalesBillValueHolder._AnadirContrapartida1TcCuenta,
                SalesBillValueHolder._AnadirContrapartida1TnImporte,
                SalesBillValueHolder._AnadirContrapartida1TlEsUnSuplido
            );

            toCfgGenFactVenta._DefinicionDebe = SalesBillValueHolder._DefinicionDebe;
            toCfgGenFactVenta._DefinicionHaber = SalesBillValueHolder._DefinicionHaber;
            toCfgGenFactVenta._Divisa = SalesBillValueHolder._Divisa;
            toCfgGenFactVenta._Cambio = SalesBillValueHolder._Cambio;
            toCfgGenFactVenta._PrcDtoPP = SalesBillValueHolder._PrcDtoPP;
            toCfgGenFactVenta._PrcRecFinan = SalesBillValueHolder._PrcRecFinan;
            toCfgGenFactVenta._Recc = SalesBillValueHolder._Recc;
            toCfgGenFactVenta._IvaIncluido = SalesBillValueHolder._IvaIncluido;
            toCfgGenFactVenta._RecEquiv = SalesBillValueHolder._RecEquiv;

            if(SalesBillValueHolder.llretencion)
            {
                RetencionGenFact cfgRetencion = toCfgGenFactVenta._ConfiguracionParaRetencion.Value;
                cfgRetencion._Retencion_Codigo = SalesBillValueHolder.cfgRetencion_Retencion_Codigo;
                cfgRetencion._Retencion_Cuenta = SalesBillValueHolder.cfgRetencion_Retencion_Cuenta;
                cfgRetencion._RetencionSobreBase = SalesBillValueHolder.cfgRetencion_RetencionSobreBase;
                cfgRetencion._RetencionSobreTotal = SalesBillValueHolder.cfgRetencion_RetencionSobreTotal;
                cfgRetencion._PrcRetencion = SalesBillValueHolder.cfgRetencion_PrcRetencion;
            }
            AsientosFacturasVentaGenerador loGenAsiFacVen = new AsientosFacturasVentaGenerador();
            bool llOk = loGenAsiFacVen._GenerarFacturaRapida(toCfgGenFactVenta);
            if(!llOk)
                SalesBillValueHolder._Error_Message = loGenAsiFacVen._Error_Message.Trim();

            string aa = "";
            aa += "_Error_Message: " + SalesBillValueHolder._Error_Message + "\n";
            aa += "_nDigitos: " + SalesBillValueHolder._nDigitos + "\n";
            aa += "_Ejercicio: " + SalesBillValueHolder._Ejercicio + "\n";

            aa += "llretencion: " + SalesBillValueHolder.llretencion + "\n";
            aa += "llSerFact: " + SalesBillValueHolder.llSerFact + "\n";

            aa += "_Cliente: " + SalesBillValueHolder._Cliente + "\n";

            aa += "_SerieFra: " + SalesBillValueHolder._SerieFra + "\n";

            aa += "_Factura: " + SalesBillValueHolder._Factura + "\n";

            aa += "_TipoFactura: " + SalesBillValueHolder._TipoFactura + "\n";
            aa += "_FechaAsiento: " + SalesBillValueHolder._FechaAsiento + "\n";
            aa += "_FechaFactura: " + SalesBillValueHolder._FechaFactura + "\n";
            aa += "_PresentarVencimientos: " + SalesBillValueHolder._PresentarVencimientos + "\n";
            aa += "_ContabilizarCobro: " + SalesBillValueHolder._ContabilizarCobro + "\n";
            aa += "_PresentarAsiento: " + SalesBillValueHolder._PresentarAsiento + "\n";

            aa += "_AnadirTipoIva1TcCodigo: " + SalesBillValueHolder._AnadirTipoIva1TcCodigo + "\n";
            aa += "_AnadirTipoIva1TnImporte: " + SalesBillValueHolder._AnadirTipoIva1TnImporte + "\n";

            aa += "_AnadirContrapartida1TcCuenta: " + SalesBillValueHolder._AnadirContrapartida1TcCuenta + "\n";
            aa += "_AnadirContrapartida1TnImporte: " + SalesBillValueHolder._AnadirContrapartida1TnImporte + "\n";
            aa += "_AnadirContrapartida1TlEsUnSuplido: " + SalesBillValueHolder._AnadirContrapartida1TlEsUnSuplido + "\n";

            aa += "_DefinicionDebe: " + SalesBillValueHolder._DefinicionDebe + "\n";
            aa += "_DefinicionHaber: " + SalesBillValueHolder._DefinicionHaber + "\n";

            aa += "_Divisa: " + SalesBillValueHolder._Divisa + "\n";
            aa += "_Cambio: " + SalesBillValueHolder._Cambio + "\n";

            aa += "_PrcDtoPP: " + SalesBillValueHolder._PrcDtoPP + "\n";

            aa += "_PrcRecFinan: " + SalesBillValueHolder._PrcRecFinan + "\n";

            aa += "_Recc: " + SalesBillValueHolder._Recc + "\n";

            aa += "_IvaIncluido: " + SalesBillValueHolder._IvaIncluido + "\n";

            aa += "_RecEquiv: " + SalesBillValueHolder._RecEquiv + "\n";

            aa += "cfgRetencion_Retencion_Codigo: " + SalesBillValueHolder.cfgRetencion_Retencion_Codigo + "\n";
            aa += "cfgRetencion_Retencion_Cuenta: " + SalesBillValueHolder.cfgRetencion_Retencion_Cuenta + "\n";
            aa += "cfgRetencion_RetencionSobreBase: " + SalesBillValueHolder.cfgRetencion_RetencionSobreBase + "\n";
            aa += "cfgRetencion_RetencionSobreTotal: " + SalesBillValueHolder.cfgRetencion_RetencionSobreTotal + "\n";
            aa += "cfgRetencion_PrcRetencion: " + SalesBillValueHolder.cfgRetencion_PrcRetencion + "\n";
            MessageBox.Show(aa);

        }
    }
}
