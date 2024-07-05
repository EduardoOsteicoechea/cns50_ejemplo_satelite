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
using Sage.ES.S50.NuevoEjercicio;

namespace ExampleSatelite.Sage50.AvantLeap.ChargeAction
{
    internal class FieldsPanel : System.Windows.Forms.Panel
    {
        public int VariableTop { get; set; } = Convert.ToInt32(Math.Round((double)(EOStyles.Row1Top * 1.75)));

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

        public CheckBoxControl loNuevaLinea_Automatico { get; set; }
        public TextInput loNuevaLinea_Cuenta { get; set; }
        public TextInput loNuevaLinea_DefinicionAsiento { get; set; }

        public TextInput loNuevaLinea_Factura { get; set; }
        public NumericUpDownControl loNuevaLinea_Orden_Numereb { get; set; }
        public NumericUpDownControl loNuevaLinea_Entrega { get; set; }
        public NumericUpDownControl loNuevaLinea_Importe { get; set; }
        public DateControl loNuevaLinea_Emision { get; set; }
        public CheckBoxControl loNuevaLinea_Prevision { get; set; }
        public NumericUpDownControl loNuevaLinea_Periodo { get; set; }
        public NumericUpDownControl loNuevaLinea_Pendiente { get; set; }
        public DateControl loNuevaLinea_Vencimiento { get; set; }

        public TextInput loNuevaLinea_Divisa { get; set; }
        public NumericUpDownControl loNuevaLinea_CambioPrevision { get; set; }

        public CheckBoxControl _PresentarAsiento { get; set; }

        public FieldsPanel(System.Windows.Forms.Form parentForm)
        {
            this.Width= Convert.ToInt32(Math.Round((double)(EOStyles.FormWidth * .965)));
            this.Height = Convert.ToInt32(Math.Round((double)(EOStyles.FormHeight * .7)));
            this.Location = new System.Drawing.Point(-2, EOStyles.Row2Top);
            BorderStyle = BorderStyle.Fixed3D;
            this.AutoScroll = true;
            this.BackColor = EOStyles.c_gray_242;



            Label _PendienteLabel = new InputLabel(VariableTop, this.Controls);
            _PendienteLabel.Text = "_Pendiente";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Pendiente = new NumericUpDownControl(VariableTop, this.Controls);
            _Pendiente.Value = ChargeActionValueHolder._Pendiente;
            VariableTop += EOStyles.NextControlGap;

            Label _ImporteLabel = new InputLabel(VariableTop, this.Controls);
            _ImporteLabel.Text = "_Importe";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Importe = new NumericUpDownControl(VariableTop, this.Controls);
            _Importe.Value = ChargeActionValueHolder._Importe;
            VariableTop += EOStyles.NextControlGap;

            Label _EntregaDivLabel = new InputLabel(VariableTop, this.Controls);
            _EntregaDivLabel.Text = "_EntregaDiv";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _EntregaDiv = new NumericUpDownControl(VariableTop, this.Controls);
            _EntregaDiv.Value = ChargeActionValueHolder._EntregaDiv;
            VariableTop += EOStyles.NextControlGap;






            Label _LinkFormLabel = new InputLabel(VariableTop, this.Controls);
            _LinkFormLabel.Text = "¿_LinkForm?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _LinkForm = new CheckBoxControl(VariableTop, this.Controls);
            _LinkForm.Checked = ChargeActionValueHolder._LinkForm;
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
            _Cuenta.Text = ChargeActionValueHolder._Cuenta;
            VariableTop += EOStyles.NextControlGap;

            Label _DivisaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DivisaLabel.Text = "_Divisa";
            _Divisa = new TextInput(VariableTop, this.Controls);
            _Divisa.Text = ChargeActionValueHolder._Divisa;
            VariableTop += EOStyles.NextControlGap;

            Label _CambioLabel = new InputLabel(VariableTop, this.Controls);
            _CambioLabel.Text = "_Cambio";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _Cambio = new NumericUpDownControl(VariableTop, this.Controls);
            _Cambio.Value = ChargeActionValueHolder._Cambio;
            VariableTop += EOStyles.NextControlGap;

            Label _DefinicionLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _DefinicionLabel.Text = "_Definicion";
            _Definicion = new TextInput(VariableTop, this.Controls);
            _Definicion.Text = ChargeActionValueHolder._Definicion;
            VariableTop += EOStyles.NextControlGap;

            Label _AsientoPorLineaLabel = new InputLabel(VariableTop, this.Controls);
            _AsientoPorLineaLabel.Text = "¿_AsientoPorLinea?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _AsientoPorLinea = new CheckBoxControl(VariableTop, this.Controls);
            _AsientoPorLinea.Checked = ChargeActionValueHolder._AsientoPorLinea;
            VariableTop += EOStyles.NextControlGap;






            Label loNuevaLinea_AutomaticoLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_AutomaticoLabel.Text = "¿loNuevaLinea_Automatico?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Automatico = new CheckBoxControl(VariableTop, this.Controls);
            loNuevaLinea_Automatico.Checked = ChargeActionValueHolder.loNuevaLinea_Automatico;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_CuentaLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_CuentaLabel.Text = "loNuevaLinea_Cuenta";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Cuenta = new TextInput(VariableTop, this.Controls);
            loNuevaLinea_Cuenta.Text = ChargeActionValueHolder.loNuevaLinea_Cuenta;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_DefinicionAsientoLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_DefinicionAsientoLabel.Text = "loNuevaLinea_DefinicionAsiento";
            loNuevaLinea_DefinicionAsiento = new TextInput(VariableTop, this.Controls);
            loNuevaLinea_DefinicionAsiento.Text = ChargeActionValueHolder.loNuevaLinea_DefinicionAsiento;
            VariableTop += EOStyles.NextControlGap;






            Label loNuevaLinea_FacturaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_FacturaLabel.Text = "loNuevaLinea_Factura";
            loNuevaLinea_Factura = new TextInput(VariableTop, this.Controls);
            loNuevaLinea_Factura.Text = ChargeActionValueHolder.loNuevaLinea_Factura;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_Orden_NumerebLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_Orden_NumerebLabel.Text = "loNuevaLinea_Orden_Numereb";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Orden_Numereb = new NumericUpDownControl(VariableTop, this.Controls);
            loNuevaLinea_Orden_Numereb.Value = ChargeActionValueHolder.loNuevaLinea_Orden_Numereb;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_EntregaLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_EntregaLabel.Text = "loNuevaLinea_Entrega";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Entrega = new NumericUpDownControl(VariableTop, this.Controls);
            loNuevaLinea_Entrega.Value = ChargeActionValueHolder.loNuevaLinea_Entrega;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_ImporteLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_ImporteLabel.Text = "loNuevaLinea_Importe";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Importe = new NumericUpDownControl(VariableTop, this.Controls);
            loNuevaLinea_Importe.Value = ChargeActionValueHolder.loNuevaLinea_Importe;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_EmisionLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_EmisionLabel.Text = "loNuevaLinea_Emision";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Emision = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_PrevisionLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_PrevisionLabel.Text = "¿loNuevaLinea_Prevision?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Prevision = new CheckBoxControl(VariableTop, this.Controls);
            loNuevaLinea_Prevision.Checked = ChargeActionValueHolder.loNuevaLinea_Prevision;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_PeriodoLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_PeriodoLabel.Text = "loNuevaLinea_Periodo";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Periodo = new NumericUpDownControl(VariableTop, this.Controls);
            loNuevaLinea_Periodo.Value = ChargeActionValueHolder.loNuevaLinea_Periodo;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_PendienteLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_PendienteLabel.Text = "loNuevaLinea_Pendiente";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Pendiente = new NumericUpDownControl(VariableTop, this.Controls);
            loNuevaLinea_Pendiente.Value = ChargeActionValueHolder.loNuevaLinea_Pendiente;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_VencimientoLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_VencimientoLabel.Text = "loNuevaLinea_Vencimiento";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_Vencimiento = new DateControl(VariableTop, this.Controls);
            VariableTop += EOStyles.NextControlGap;






            Label loNuevaLinea_DivisaLabel = new InputLabel(VariableTop, this.Controls);
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_DivisaLabel.Text = "loNuevaLinea_Divisa";
            loNuevaLinea_Divisa = new TextInput(VariableTop, this.Controls);
            loNuevaLinea_Divisa.Text = ChargeActionValueHolder._Ejercicio;
            VariableTop += EOStyles.NextControlGap;

            Label loNuevaLinea_CambioPrevisionLabel = new InputLabel(VariableTop, this.Controls);
            loNuevaLinea_CambioPrevisionLabel.Text = "loNuevaLinea_CambioPrevision";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            loNuevaLinea_CambioPrevision = new NumericUpDownControl(VariableTop, this.Controls);
            loNuevaLinea_CambioPrevision.Value = ChargeActionValueHolder.loNuevaLinea_CambioPrevision;
            VariableTop += EOStyles.NextControlGap;



            Label _PresentarAsientoLabel = new InputLabel(VariableTop, this.Controls);
            _PresentarAsientoLabel.Text = "¿_PresentarAsiento?";
            VariableTop += EOStyles.SiblingControlGapFromLabel;
            _PresentarAsiento = new CheckBoxControl(VariableTop, this.Controls);
            _PresentarAsiento.Checked = ChargeActionValueHolder._PresentarAsiento;
            VariableTop += EOStyles.NextControlGap;








            Label bottomSpaceLabel = new InputLabel(VariableTop, this.Controls);
            bottomSpaceLabel.Text = "";

            parentForm.Controls.Add(this);
        }
    }
}
