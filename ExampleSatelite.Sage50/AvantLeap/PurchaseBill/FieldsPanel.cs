using ExampleSatelite.Sage50.AvantLeap.Styles;
using sage.ew.ewbase;
using Sage.ES.S50.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleSatelite.Sage50.AvantLeap.CommonControl;

namespace ExampleSatelite.Sage50.AvantLeap.PurchaseBill
{
    internal class FieldsPanel : System.Windows.Forms.Panel
    {
        public int VariableTop { get; set; } = Convert.ToInt32(Math.Round((double)(EOStyles.Row1Top * 1.75)));

        public TextInput _Error_Message { get; set; }
        public int _nDigitos { get; set; }
        public TextInput _Ejercicio { get; set; }
        public int _LongFactCompra { get; set; }

        public TextInput _Proveedor { get; set; }
        public DateControl _FechaAsiento { get; set; }
        public DateControl _FechaFactura { get; set; }
        public TextInput _Factura { get; set; }
        public TextInput _Divisa { get; set; }
        public NumericUpDownControl _Cambio { get; set; }

        public CheckBoxControl _IvaIncluido { get; set; }

        public TextInput _AnadirTipoIvaTipo { get; set; }
        public NumericUpDownControl _AnadirTipoIvaMontoDePartida { get; set; }

        public TextInput _AnadirContrapartidaTcCuenta { get; set; }
        public NumericUpDownControl _AnadirContrapartidaTnImporte { get; set; }
        public CheckBoxControl _AnadirContrapartidaTlEsUnSuplido { get; set; }

        public TextInput _DefinicionDebe { get; set; }
        public TextInput _DefinicionHaber { get; set; }

        public CheckBoxControl _PresentarVencimientos { get; set; }
        public CheckBoxControl _ContabilizarPago { get; set; }
        public CheckBoxControl _PresentarFechaBancoPago { get; set; }
        public CheckBoxControl _PresentarAsiento { get; set; }

        public TextInput _CuentaBancoPago { get; set; }
        public DateControl _FechaPago { get; set; }
        public NumericUpDownControl _PrcDtoPP { get; set; }
        public CheckBoxControl _AplicaRetPro { get; set; }


        public FieldsPanel(System.Windows.Forms.Form parentForm)
        {
            this.Width= Convert.ToInt32(Math.Round((double)(EOStyles.FormWidth * .965)));
            this.Height = Convert.ToInt32(Math.Round((double)(EOStyles.FormHeight * .7)));
            this.Location = new System.Drawing.Point(-2, EOStyles.Row2Top);
            BorderStyle = BorderStyle.Fixed3D;
            this.AutoScroll = true;
            this.BackColor = EOStyles.c_gray_242;


            Label _ProveedorLabel = new InputLabel(VariableTop, this.Controls);
            _ProveedorLabel.Text = "_Proveedor";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Proveedor = new TextInput(VariableTop, this.Controls);
            _Proveedor.Text = PurchaseBillValueHolder._Proveedor;
            VariableTop += EOStyles.NextControlGap;

            Label _FechaAsientoLabel = new InputLabel(VariableTop, this.Controls);
            _FechaAsientoLabel.Text = "_FechaAsiento";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _FechaAsiento = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _FechaFacturaLabel = new InputLabel(VariableTop, this.Controls);
            _FechaFacturaLabel.Text = "_FechaFactura";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _FechaFactura = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _FacturaLabel = new InputLabel(VariableTop, this.Controls);
            _FacturaLabel.Text = "_Factura";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Factura = new TextInput(VariableTop, this.Controls);
            _Factura.Text = PurchaseBillValueHolder._Factura;
            VariableTop += EOStyles.NextControlGap;

            Label _DivisaLabel = new InputLabel(VariableTop, this.Controls);
            _DivisaLabel.Text = "_Divisa";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Divisa = new TextInput(VariableTop, this.Controls);
            _Divisa.Text = PurchaseBillValueHolder._Divisa;
            VariableTop += EOStyles.NextControlGap;

            Label _CambioLabel = new InputLabel(VariableTop, this.Controls);
            _CambioLabel.Text = "_Cambio";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Cambio = new NumericUpDownControl(VariableTop, this.Controls);
            _Cambio.Value = PurchaseBillValueHolder._Cambio;
            VariableTop += EOStyles.NextControlGap;

            Label _IvaIncluidoLabel = new InputLabel(VariableTop, this.Controls);
            _IvaIncluidoLabel.Text = "¿_IvaIncluido?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _IvaIncluido = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirTipoIvaTipoLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirTipoIvaTipoLabel.Text = "_AnadirTipoIvaTipo";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirTipoIvaTipo = new TextInput(VariableTop, this.Controls);
            _AnadirTipoIvaTipo.Text = PurchaseBillValueHolder._AnadirTipoIvaTipo;
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirTipoIvaMontoDePartidaLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirTipoIvaMontoDePartidaLabel.Text = "_AnadirTipoIvaMontoDePartida";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirTipoIvaMontoDePartida = new NumericUpDownControl(VariableTop, this.Controls);
            _AnadirTipoIvaMontoDePartida.Value = PurchaseBillValueHolder._AnadirTipoIvaMontoDePartida;
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirContrapartidaTcCuentaLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirContrapartidaTcCuentaLabel.Text = "_AnadirContrapartidaTcCuenta";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirContrapartidaTcCuenta = new TextInput(VariableTop, this.Controls);
            _AnadirContrapartidaTcCuenta.Text = PurchaseBillValueHolder._AnadirContrapartidaTcCuenta;
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirContrapartidaTnImporteLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirContrapartidaTnImporteLabel.Text = "_AnadirContrapartidaTnImporte";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirContrapartidaTnImporte = new NumericUpDownControl(VariableTop, this.Controls);
            _AnadirContrapartidaTnImporte.Value = PurchaseBillValueHolder._AnadirContrapartidaTnImporte;
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirContrapartidaTlEsUnSuplidoLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirContrapartidaTlEsUnSuplidoLabel.Text = "¿_AnadirContrapartidaTlEsUnSuplido?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirContrapartidaTlEsUnSuplido = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _DefinicionDebeLabel = new InputLabel(VariableTop, this.Controls);
            _DefinicionDebeLabel.Text = "_DefinicionDebe";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DefinicionDebe = new TextInput(VariableTop, this.Controls);
            _DefinicionDebe.Text = PurchaseBillValueHolder._DefinicionDebe;
            VariableTop += EOStyles.NextControlGap;

            Label _DefinicionHaberLabel = new InputLabel(VariableTop, this.Controls);
            _DefinicionHaberLabel.Text = "_DefinicionHaber";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DefinicionHaber = new TextInput(VariableTop, this.Controls);
            _DefinicionHaber.Text = PurchaseBillValueHolder._DefinicionHaber;
            VariableTop += EOStyles.NextControlGap;

            Label _PresentarVencimientosLabel = new InputLabel(VariableTop, this.Controls);
            _PresentarVencimientosLabel.Text = "¿_PresentarVencimientos?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PresentarVencimientos = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _ContabilizarPagoLabel = new InputLabel(VariableTop, this.Controls);
            _ContabilizarPagoLabel.Text = "¿_ContabilizarPago?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _ContabilizarPago = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _PresentarFechaBancoPagoLabel = new InputLabel(VariableTop, this.Controls);
            _PresentarFechaBancoPagoLabel.Text = "¿_PresentarFechaBancoPago?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PresentarFechaBancoPago = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _PresentarAsientoLabel = new InputLabel(VariableTop, this.Controls);
            _PresentarAsientoLabel.Text = "¿_PresentarAsiento?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PresentarAsiento = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _CuentaBancoPagoLabel = new InputLabel(VariableTop, this.Controls);
            _CuentaBancoPagoLabel.Text = "_CuentaBancoPago";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _CuentaBancoPago = new TextInput(VariableTop, this.Controls);
            _CuentaBancoPago.Text = PurchaseBillValueHolder._CuentaBancoPago;
            VariableTop += EOStyles.NextControlGap;

            Label _FechaPagoLabel = new InputLabel(VariableTop, this.Controls);
            _FechaPagoLabel.Text = "_FechaPago";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _FechaPago = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _PrcDtoPPLabel = new InputLabel(VariableTop, this.Controls);
            _PrcDtoPPLabel.Text = "_PrcDtoPP";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PrcDtoPP = new NumericUpDownControl(VariableTop, this.Controls);
            _PrcDtoPP.Value = PurchaseBillValueHolder._PrcDtoPP;
            VariableTop += EOStyles.NextControlGap;

            Label _AplicaRetProLabel = new InputLabel(VariableTop, this.Controls);
            _AplicaRetProLabel.Text = "¿_AplicaRetPro?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AplicaRetPro = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;







            Label bottomSpaceLabel = new InputLabel(VariableTop, this.Controls);
            bottomSpaceLabel.Text = "";

            parentForm.Controls.Add(this);
        }
    }
}
