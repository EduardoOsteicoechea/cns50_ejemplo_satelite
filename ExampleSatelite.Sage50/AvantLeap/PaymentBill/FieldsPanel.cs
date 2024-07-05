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

namespace ExampleSatelite.Sage50.AvantLeap.PaymentBill
{
    internal class FieldsPanel : System.Windows.Forms.Panel
    {
        public int VariableTop { get; set; } = Convert.ToInt32(Math.Round((double)(EOStyles.Row1Top * 1.75)));

        public TextInput _Ejercicio { get; set; }
        public NumericUpDownControl _Pendiente { get; set; }
        public NumericUpDownControl _Importe { get; set; }
        public NumericUpDownControl _EntregaDiv { get; set; }
        public CheckBoxControl _LinkForm { get; set; }
        public DateControl _Fecha { get; set; }
        public TextInput _Cuenta { get; set; }
        public TextInput _Divisa { get; set; }
        public NumericUpDownControl _Cambio { get; set; }
        public TextInput _Definicion { get; set; }
        public CheckBoxControl _AsientoPorLinea { get; set; }
        public CheckBoxControl NuevaLinea_Automatico { get; set; }
        public TextInput NuevaLinea_Cuenta { get; set; }
        public TextInput NuevaLinea_DefinicionAsiento { get; set; }
        public TextInput NuevaLinea_Factura { get; set; }
        public NumericUpDownControl NuevaLinea_Orden_Numereb { get; set; }
        public NumericUpDownControl NuevaLinea_Entrega { get; set; }
        public NumericUpDownControl NuevaLinea_Importe { get; set; }
        public DateControl NuevaLinea_Emision { get; set; }
        public CheckBoxControl NuevaLinea_Prevision { get; set; }
        public NumericUpDownControl NuevaLinea_Periodo { get; set; }
        public NumericUpDownControl NuevaLinea_Pendiente { get; set; }
        public DateControl NuevaLinea_Vencimiento { get; set; }
        public TextInput NuevaLinea_Divisa { get; set; }
        public NumericUpDownControl NuevaLinea_CambioPrevision { get; set; }

        public FieldsPanel(System.Windows.Forms.Form parentForm)
        {
            this.Width= Convert.ToInt32(Math.Round((double)(EOStyles.FormWidth * .965)));
            this.Height = Convert.ToInt32(Math.Round((double)(EOStyles.FormHeight * .7)));
            this.Location = new System.Drawing.Point(-2, EOStyles.Row2Top);
            BorderStyle = BorderStyle.Fixed3D;
            this.AutoScroll = true;
            this.BackColor = EOStyles.c_gray_242;


            Label _EjercicioLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _EjercicioLabel.Text = "_Ejercicio";
            _Ejercicio = new TextInput(VariableTop, this.Controls);
            _Ejercicio.Text = PaymentBillValueHolder._Ejercicio;
            VariableTop += EOStyles.NextControlGap;

            Label _PendienteLabel = new InputLabel(VariableTop, this.Controls);
            _PendienteLabel.Text = "_Pendiente";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Pendiente = new NumericUpDownControl(VariableTop, this.Controls);
            _Pendiente.Value = PaymentBillValueHolder._Pendiente;
            VariableTop += EOStyles.NextControlGap;

            Label _ImporteLabel = new InputLabel(VariableTop, this.Controls);
            _ImporteLabel.Text = "_Importe";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Importe = new NumericUpDownControl(VariableTop, this.Controls);
            _Importe.Value = PaymentBillValueHolder._Importe;
            VariableTop += EOStyles.NextControlGap;

            Label _EntregaDivLabel = new InputLabel(VariableTop, this.Controls);
            _EntregaDivLabel.Text = "_EntregaDiv";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _EntregaDiv = new NumericUpDownControl(VariableTop, this.Controls);
            _EntregaDiv.Value = PaymentBillValueHolder._EntregaDiv;
            VariableTop += EOStyles.NextControlGap;

            Label _LinkFormLabel = new InputLabel(VariableTop, this.Controls);
            _LinkFormLabel.Text = "¿_LinkForm?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _LinkForm = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _FechaLabel = new InputLabel(VariableTop, this.Controls);
            _FechaLabel.Text = "_Fecha";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Fecha = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label _CuentaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _CuentaLabel.Text = "_Cuenta";
            _Cuenta = new TextInput(VariableTop, this.Controls);
            _Cuenta.Text = PaymentBillValueHolder._Cuenta;
            VariableTop += EOStyles.NextControlGap;

            Label _DivisaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DivisaLabel.Text = "_Divisa";
            _Divisa = new TextInput(VariableTop, this.Controls);
            _Divisa.Text = PaymentBillValueHolder._Divisa;
            VariableTop += EOStyles.NextControlGap;

            Label _CambioLabel = new InputLabel(VariableTop, this.Controls);
            _CambioLabel.Text = "_Cambio";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Cambio = new NumericUpDownControl(VariableTop, this.Controls);
            _Cambio.Value = PaymentBillValueHolder._Cambio;
            VariableTop += EOStyles.NextControlGap;

            Label _DefinicionLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DefinicionLabel.Text = "_Definicion";
            _Definicion = new TextInput(VariableTop, this.Controls);
            _Definicion.Text = PaymentBillValueHolder._Definicion;
            VariableTop += EOStyles.NextControlGap;

            Label _AsientoPorLineaLabel = new InputLabel(VariableTop, this.Controls);
            _AsientoPorLineaLabel.Text = "¿_AsientoPorLinea?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AsientoPorLinea = new CheckBoxControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_AutomaticoLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_AutomaticoLabel.Text = "¿NuevaLinea_Automatico?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Automatico = new CheckBoxControl(VariableTop, this.Controls);
            NuevaLinea_Automatico.Checked = true;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_CuentaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_CuentaLabel.Text = "NuevaLinea_Cuenta";
            NuevaLinea_Cuenta = new TextInput(VariableTop, this.Controls);
            NuevaLinea_Cuenta.Text = PaymentBillValueHolder.NuevaLinea_Cuenta;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_DefinicionAsientoLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_DefinicionAsientoLabel.Text = "NuevaLinea_DefinicionAsiento";
            NuevaLinea_DefinicionAsiento = new TextInput(VariableTop, this.Controls);
            NuevaLinea_DefinicionAsiento.Text = PaymentBillValueHolder.NuevaLinea_DefinicionAsiento;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_FacturaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_FacturaLabel.Text = "NuevaLinea_Factura";
            NuevaLinea_Factura = new TextInput(VariableTop, this.Controls);
            NuevaLinea_Factura.Text = PaymentBillValueHolder.NuevaLinea_Factura;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_Orden_NumerebLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_Orden_NumerebLabel.Text = "NuevaLinea_Orden_Numereb";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Orden_Numereb = new NumericUpDownControl(VariableTop, this.Controls);
            NuevaLinea_Orden_Numereb.Value = PaymentBillValueHolder.NuevaLinea_Orden_Numereb;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_EntregaLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_EntregaLabel.Text = "NuevaLinea_Entrega";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Entrega = new NumericUpDownControl(VariableTop, this.Controls);
            NuevaLinea_Entrega.Value = PaymentBillValueHolder.NuevaLinea_Entrega;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_ImporteLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_ImporteLabel.Text = "NuevaLinea_Importe";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Importe = new NumericUpDownControl(VariableTop, this.Controls);
            NuevaLinea_Importe.Value = PaymentBillValueHolder.NuevaLinea_Importe;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_EmisionLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_EmisionLabel.Text = "NuevaLinea_Emision";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Emision = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_PrevisionLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_PrevisionLabel.Text = "¿NuevaLinea_Prevision?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Prevision = new CheckBoxControl(VariableTop, this.Controls);
            NuevaLinea_Prevision.Checked = true;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_PeriodoLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_PeriodoLabel.Text = "NuevaLinea_Periodo";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Periodo = new NumericUpDownControl(VariableTop, this.Controls);
            //NuevaLinea_Periodo.Value = PaymentBillValueHolder.NuevaLinea_Periodo;
            NuevaLinea_Periodo.Value = 10;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_PendienteLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_PendienteLabel.Text = "NuevaLinea_Pendiente";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Pendiente = new NumericUpDownControl(VariableTop, this.Controls);
            NuevaLinea_Pendiente.Value = PaymentBillValueHolder.NuevaLinea_Pendiente;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_VencimientoLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_VencimientoLabel.Text = "NuevaLinea_Vencimiento";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_Vencimiento = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_DivisaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_DivisaLabel.Text = "NuevaLinea_Divisa";
            NuevaLinea_Divisa = new TextInput(VariableTop, this.Controls);
            NuevaLinea_Divisa.Text = PaymentBillValueHolder.NuevaLinea_Divisa;
            VariableTop += EOStyles.NextControlGap;

            Label NuevaLinea_CambioPrevisionLabel = new InputLabel(VariableTop, this.Controls);
            NuevaLinea_CambioPrevisionLabel.Text = "NuevaLinea_CambioPrevision";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            NuevaLinea_CambioPrevision = new NumericUpDownControl(VariableTop, this.Controls);
            NuevaLinea_CambioPrevision.Value = PaymentBillValueHolder.NuevaLinea_CambioPrevision;
            VariableTop += EOStyles.NextControlGap;

            Label bottomSpaceLabel = new InputLabel(VariableTop, this.Controls);
            bottomSpaceLabel.Text = "";

            parentForm.Controls.Add(this);
        }
    }
}
