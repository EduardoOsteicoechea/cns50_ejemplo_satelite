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
using sage.ew.cliente;

namespace ExampleSatelite.Sage50.AvantLeap.SalesBill
{
    internal class FieldsPanel : System.Windows.Forms.Panel
    {
        public int VariableTop { get; set; } = Convert.ToInt32(Math.Round((double)(EOStyles.Row1Top * 1.75)));

        public CheckBoxControl llretencion { get; set; }
        public CheckBoxControl llSerFact { get; set; }

        public TextInput _Cliente { get; set; }
        public TextInput _SerieFra { get; set; }
        public TextInput _Factura { get; set; }

        public NumericUpDownControl _TipoFactura { get; set; }
        public DateControl _FechaAsiento { get; set; }
        public DateControl _FechaFactura { get; set; }

        public CheckBoxControl _PresentarVencimientos { get; set; }
        public CheckBoxControl _ContabilizarCobro { get; set; }
        public CheckBoxControl _PresentarAsiento { get; set; }

        public TextInput _AnadirTipoIva1TcCodigo { get; set; }
        public NumericUpDownControl _AnadirTipoIva1TnImporte { get; set; }


        public TextInput _AnadirContrapartida1TcCuenta { get; set; }
        public NumericUpDownControl _AnadirContrapartida1TnImporte { get; set; }
        public CheckBoxControl _AnadirContrapartida1TlEsUnSuplido { get; set; }


        public TextInput _DefinicionDebe { get; set; }
        public TextInput _DefinicionHaber { get; set; }

        public TextInput _Divisa { get; set; }
        public NumericUpDownControl _Cambio { get; set; }
        public NumericUpDownControl _PrcDtoPP { get; set; }
        public NumericUpDownControl _PrcRecFinan { get; set; }
        public CheckBoxControl _Recc { get; set; }
        public CheckBoxControl _IvaIncluido { get; set; }
        public CheckBoxControl _RecEquiv { get; set; }

        public TextInput cfgRetencion_Retencion_Codigo { get; set; }
        public TextInput cfgRetencion_Retencion_Cuenta { get; set; }
        public CheckBoxControl cfgRetencion_RetencionSobreBase { get; set; }
        public CheckBoxControl cfgRetencion_RetencionSobreTotal { get; set; }
        public NumericUpDownControl cfgRetencion_PrcRetencion { get; set; }

        public FieldsPanel(System.Windows.Forms.Form parentForm)
        {
            this.Width= Convert.ToInt32(Math.Round((double)(EOStyles.FormWidth * .965)));
            this.Height = Convert.ToInt32(Math.Round((double)(EOStyles.FormHeight * .7)));
            this.Location = new System.Drawing.Point(-2, EOStyles.Row2Top);
            BorderStyle = BorderStyle.Fixed3D;
            this.AutoScroll = true;
            this.BackColor = EOStyles.c_gray_242;



            Label llretencionLabel = new InputLabel(VariableTop, this.Controls);
            llretencionLabel.Text = "¿llretencion?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            llretencion = new CheckBoxControl(VariableTop, this.Controls);
            llretencion.Checked = SalesBillValueHolder.llretencion;
            VariableTop += EOStyles.NextControlGap;

            Label llSerFactLabel = new InputLabel(VariableTop, this.Controls);
            llSerFactLabel.Text = "¿llSerFact?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            llSerFact = new CheckBoxControl(VariableTop, this.Controls);
            llSerFact.Checked = SalesBillValueHolder.llretencion;
            VariableTop += EOStyles.NextControlGap;





            Label _ClienteLabel = new InputLabel(VariableTop, this.Controls);
            _ClienteLabel.Text = "_Cliente";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Cliente = new TextInput(VariableTop, this.Controls);
            _Cliente.Text = SalesBillValueHolder._Cliente;
            VariableTop += EOStyles.NextControlGap;

            Label _SerieFraLabel = new InputLabel(VariableTop, this.Controls);
            _SerieFraLabel.Text = "SerieFra";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _SerieFra = new TextInput(VariableTop, this.Controls);
            _SerieFra.Text = SalesBillValueHolder._SerieFra;
            VariableTop += EOStyles.NextControlGap;

            Label _FacturaLabel = new InputLabel(VariableTop, this.Controls);
            _FacturaLabel.Text = "Factura";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Factura = new TextInput(VariableTop, this.Controls);
            _Factura.Text = SalesBillValueHolder._Factura;
            VariableTop += EOStyles.NextControlGap;




            Label _TipoFacturaLabel = new InputLabel(VariableTop, this.Controls);
            _TipoFacturaLabel.Text = "Tipo de factura";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _TipoFactura = new NumericUpDownControl(VariableTop, this.Controls);
            _TipoFactura.Value = SalesBillValueHolder._TipoFactura;
            VariableTop += EOStyles.NextControlGap;

            Label _FechaAsientoLabel = new InputLabel(VariableTop, this.Controls);
            _FechaAsientoLabel.Text = "Fecha de asiento";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _FechaAsiento = new DateControl(VariableTop, this.Controls);
            _FechaAsiento.Value = SalesBillValueHolder._FechaAsiento;
            VariableTop += EOStyles.NextControlGap;

            Label _FechaFacturaLabel = new InputLabel(VariableTop, this.Controls);
            _FechaFacturaLabel.Text = "Fecha de factura";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _FechaFactura = new DateControl(VariableTop, this.Controls);
            _FechaFactura.Value = SalesBillValueHolder._FechaFactura;
            VariableTop += EOStyles.NextControlGap;



            Label _PresentarVencimientosLabel = new InputLabel(VariableTop, this.Controls);
            _PresentarVencimientosLabel.Text = "¿Presentar Vencimientos?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PresentarVencimientos = new CheckBoxControl(VariableTop, this.Controls);
            _PresentarVencimientos.Checked = SalesBillValueHolder._PresentarVencimientos;
            VariableTop += EOStyles.NextControlGap;

            Label _ContabilizarCobroLabel = new InputLabel(VariableTop, this.Controls);
            _ContabilizarCobroLabel.Text = "¿Contabilizar cobro?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _ContabilizarCobro = new CheckBoxControl(VariableTop, this.Controls);
            _ContabilizarCobro.Checked = SalesBillValueHolder._ContabilizarCobro;
            VariableTop += EOStyles.NextControlGap;

            Label _PresentarAsientoLabel = new InputLabel(VariableTop, this.Controls);
            _PresentarAsientoLabel.Text = "¿Presentar asiento?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PresentarAsiento = new CheckBoxControl(VariableTop, this.Controls);
            _PresentarAsiento.Checked = SalesBillValueHolder._PresentarAsiento;
            VariableTop += EOStyles.NextControlGap;


            Label _AnadirTipoIva1TcCodigoLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirTipoIva1TcCodigoLabel.Text = "_AnadirTipoIva1TcCodigo";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirTipoIva1TcCodigo = new TextInput(VariableTop, this.Controls);
            _AnadirTipoIva1TcCodigo.Text = SalesBillValueHolder._AnadirTipoIva1TcCodigo;
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirTipoIva1TnImporteLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirTipoIva1TnImporteLabel.Text = "_AnadirTipoIva1TnImporte";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirTipoIva1TnImporte = new NumericUpDownControl(VariableTop, this.Controls);
            _AnadirTipoIva1TnImporte.Value = SalesBillValueHolder._AnadirTipoIva1TnImporte;
            VariableTop += EOStyles.NextControlGap;


            Label _AnadirContrapartida1TcCuentaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirContrapartida1TcCuentaLabel.Text = "_AnadirContrapartida1TcCuenta";
            _AnadirContrapartida1TcCuenta = new TextInput(VariableTop, this.Controls);
            _AnadirContrapartida1TcCuenta.Text = SalesBillValueHolder._AnadirContrapartida1TcCuenta;
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirContrapartida1TnImporteLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirContrapartida1TnImporteLabel.Text = "_AnadirContrapartida1TnImporte";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirContrapartida1TnImporte = new NumericUpDownControl(VariableTop, this.Controls);
            _AnadirContrapartida1TnImporte.Value = SalesBillValueHolder._AnadirContrapartida1TnImporte;
            VariableTop += EOStyles.NextControlGap;

            Label _AnadirContrapartida1TlEsUnSuplidoLabel = new InputLabel(VariableTop, this.Controls);
            _AnadirContrapartida1TlEsUnSuplidoLabel.Text = "¿_AnadirContrapartida1TlEsUnSuplido?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AnadirContrapartida1TlEsUnSuplido = new CheckBoxControl(VariableTop, this.Controls);
            _AnadirContrapartida1TlEsUnSuplido.Checked = SalesBillValueHolder._AnadirContrapartida1TlEsUnSuplido;
            VariableTop += EOStyles.NextControlGap;


            Label _DefinicionDebeLabel = new InputLabel(VariableTop, this.Controls);
            _DefinicionDebeLabel.Text = "DefinicionDebe";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DefinicionDebe = new TextInput(VariableTop, this.Controls);
            _DefinicionDebe.Text = SalesBillValueHolder._DefinicionDebe;
            VariableTop += EOStyles.NextControlGap;

            Label _DefinicionHaberLabel = new InputLabel(VariableTop, this.Controls);
            _DefinicionHaberLabel.Text = "DefinicionHaber";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DefinicionHaber = new TextInput(VariableTop, this.Controls);
            _DefinicionHaber.Text = SalesBillValueHolder._DefinicionHaber;
            VariableTop += EOStyles.NextControlGap;


            Label _DivisaLabel = new InputLabel(VariableTop, this.Controls);
            _DivisaLabel.Text = "Divisa";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Divisa = new TextInput(VariableTop, this.Controls);
            _Divisa.Text = SalesBillValueHolder._Divisa;
            VariableTop += EOStyles.NextControlGap;

            Label _CambioLabel = new InputLabel(VariableTop, this.Controls);
            _CambioLabel.Text = "Cambio";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Cambio = new NumericUpDownControl(VariableTop, this.Controls);
            _Cambio.Value = SalesBillValueHolder._Cambio;
            VariableTop += EOStyles.NextControlGap;

            Label _PrcDtoPPLabel = new InputLabel(VariableTop, this.Controls);
            _PrcDtoPPLabel.Text = "PrcDtoPP";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PrcDtoPP = new NumericUpDownControl(VariableTop, this.Controls);
            _PrcDtoPP.Value = SalesBillValueHolder._PrcDtoPP;
            VariableTop += EOStyles.NextControlGap;

            Label _PrcRecFinanLabel = new InputLabel(VariableTop, this.Controls);
            _PrcRecFinanLabel.Text = "PrcRecFinan";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PrcRecFinan = new NumericUpDownControl(VariableTop, this.Controls);
            _PrcRecFinan.Value = SalesBillValueHolder._PrcRecFinan;
            VariableTop += EOStyles.NextControlGap;

            Label _ReccLabel = new InputLabel(VariableTop, this.Controls);
            _ReccLabel.Text = "¿Recc?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Recc = new CheckBoxControl(VariableTop, this.Controls);
            _Recc.Checked = SalesBillValueHolder._Recc;
            VariableTop += EOStyles.NextControlGap;

            Label _IvaIncluidoLabel = new InputLabel(VariableTop, this.Controls);
            _IvaIncluidoLabel.Text = "¿IvaIncluido?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _IvaIncluido = new CheckBoxControl(VariableTop, this.Controls);
            _IvaIncluido.Checked = SalesBillValueHolder._IvaIncluido;
            VariableTop += EOStyles.NextControlGap;

            Label _RecEquivLabel = new InputLabel(VariableTop, this.Controls);
            _RecEquivLabel.Text = "¿RecEquiv?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _RecEquiv = new CheckBoxControl(VariableTop, this.Controls);
            _RecEquiv.Checked = SalesBillValueHolder._RecEquiv;
            VariableTop += EOStyles.NextControlGap;


            Label cfgRetencion_Retencion_CodigoLabel = new InputLabel(VariableTop, this.Controls);
            cfgRetencion_Retencion_CodigoLabel.Text = "Retencion codigo";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            cfgRetencion_Retencion_Codigo = new TextInput(VariableTop, this.Controls);
            cfgRetencion_Retencion_Codigo.Text = SalesBillValueHolder.cfgRetencion_Retencion_Codigo;
            VariableTop += EOStyles.NextControlGap;

            Label cfgRetencion_Retencion_CuentaLabel = new InputLabel(VariableTop, this.Controls);
            cfgRetencion_Retencion_CuentaLabel.Text = "Retencion cuenta";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            cfgRetencion_Retencion_Cuenta = new TextInput(VariableTop, this.Controls);
            cfgRetencion_Retencion_Cuenta.Text = SalesBillValueHolder.cfgRetencion_Retencion_Cuenta;
            VariableTop += EOStyles.NextControlGap;

            Label cfgRetencion_RetencionSobreBaseLabel = new InputLabel(VariableTop, this.Controls);
            cfgRetencion_RetencionSobreBaseLabel.Text = "¿RetencionSobreBase?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            cfgRetencion_RetencionSobreBase = new CheckBoxControl(VariableTop, this.Controls);
            cfgRetencion_RetencionSobreBase.Checked = SalesBillValueHolder.cfgRetencion_RetencionSobreBase;
            VariableTop += EOStyles.NextControlGap;

            Label cfgRetencion_RetencionSobreTotalLabel = new InputLabel(VariableTop, this.Controls);
            cfgRetencion_RetencionSobreTotalLabel.Text = "¿RetencionSobreTotal?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            cfgRetencion_RetencionSobreTotal = new CheckBoxControl(VariableTop, this.Controls);
            cfgRetencion_RetencionSobreTotal.Checked = SalesBillValueHolder.cfgRetencion_RetencionSobreTotal;
            VariableTop += EOStyles.NextControlGap;

            Label cfgRetencion_PrcRetencionLabel = new InputLabel(VariableTop, this.Controls);
            cfgRetencion_PrcRetencionLabel.Text = "PrcRetencion";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            cfgRetencion_PrcRetencion = new NumericUpDownControl(VariableTop, this.Controls);
            cfgRetencion_PrcRetencion.Value = SalesBillValueHolder.cfgRetencion_PrcRetencion;
            VariableTop += EOStyles.NextControlGap;





            Label bottomSpaceLabel = new InputLabel(VariableTop, this.Controls);
            bottomSpaceLabel.Text = "";

            parentForm.Controls.Add(this);
        }
    }
}
