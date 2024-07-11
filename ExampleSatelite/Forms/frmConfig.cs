using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ExampleSatelite.Clases;

namespace ExampleSatelite.Forms
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();

            LoadDataConfig();
        }

        private void LoadDataConfig()
        {
            string lsPass = Program._oConfig._sSage50Password;

            lsPass = Program._oConfig._EncriptaB64(lsPass, true);

            this.txtRutaTerminal.Text = Program._oConfig._Sage50Terminal;
            this.txtUsuario.Text = Program._oConfig._Sage50Usuario;
            this.txtPassword.Text = lsPass;
            this.txtEmpresa.Text = Program._oConfig._Sage50Empresa;
        }

        private void SaveDataConfig()
        {
            string lsPass = "", lsUsuario = "", lsTerminal = "", lsEmpresa = "";

            lsTerminal = this.txtRutaTerminal.Text.Trim();
            lsUsuario = this.txtUsuario.Text.Trim();
            lsPass = this.txtPassword.Text.Trim();
            lsEmpresa = this.txtEmpresa.Text.Trim();


            lsTerminal = !string.IsNullOrEmpty(lsTerminal) ? clsFunctions._CheckCorrectFolder(lsTerminal).ToUpper() : lsTerminal;
            lsPass = !string.IsNullOrEmpty(lsPass) ? Program._oConfig._EncriptaB64(lsPass): lsPass;

            Program._oConfig._WriteKey("TERMINAL", lsTerminal, "SAGE50");
            Program._oConfig._WriteKey("USUARIO", lsUsuario, "SAGE50");
            Program._oConfig._WriteKey("PASSWORD", lsPass, "SAGE50");
            Program._oConfig._WriteKey("EMPRESA", lsEmpresa, "SAGE50");

            // Recargamos el config.
            Program._oConfig._LoadConfig();

            Program._CargarCarpetaSage50();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean llOk = (DialogResult.Yes == MessageBox.Show("¿ Está seguro de actualizar la configuración ?", "Confirmar cambios en precios de ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2));

            if (llOk)
            {
                this.SaveDataConfig();
                this.Close();
            }
        }
    }
}
