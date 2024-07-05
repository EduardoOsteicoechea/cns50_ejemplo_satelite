using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using ExampleSatelite.Sage50.Negocio;
using ExampleSatelite.Sage50.Visual.Forms;

namespace ExampleSatelite.Forms
{
    public partial class frmMain : Form
    {
        LinkSage50 _oLinkS50 = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConfig loForm = new frmConfig();
            loForm.ShowDialog();
            loForm = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntConectarSage50_Click(object sender, EventArgs e)
        {
            string lsPass = "", lsEmpresa = "";

            if (_oLinkS50 == null)
                _oLinkS50 = new LinkSage50(Program._oConfig._Sage50Terminal);

            if (_oLinkS50._Loaded_Ok && !_oLinkS50._connected)
            {
                lsPass = Program._oConfig._EncriptaB64(Program._oConfig._Sage50Password, true);
                lsEmpresa = Program._oConfig._Sage50Empresa;

                // Conectamos con Sage50, pasamos el terminal, usuario y pass, la empresa es opcional.
                if (_oLinkS50._Connect(Program._oConfig._Sage50Usuario, lsPass, lsEmpresa))
                {
                    // Cargamos todas las variables que necesita Sage50
                    _oLinkS50._LoadGlobalVariables(lsEmpresa);

                    //
                    frmMainExmaple50 loMainS50c = new frmMainExmaple50();
                    loMainS50c.ShowDialog();
                    loMainS50c = null;

                    _oLinkS50._Disconnect();
                    _oLinkS50 = null;

                }
                else
                {
                    _oLinkS50._Disconnect();
                    _oLinkS50 = null;
                }
            }

        }


    }
}
