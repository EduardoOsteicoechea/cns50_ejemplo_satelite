using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleSatelite.Clases
{
    public class clsConfig
    {

        #region propiedades
        internal _FicheroIni _oFileIni = new _FicheroIni();
        internal string _sSage50Terminal = "";
        internal string _sSage50Usuario = "";
        internal string _sSage50Password = "";
        internal string _sSage50Empresa = "";

        public string _Error_Message = "";
        public string _PathConfig = "";
        public string _FileConfig = "";

        public string _Sage50Terminal
        {
            get { return _sSage50Terminal.Trim(); }
        }

        public string _Sage50Usuario
        {
            get { return _sSage50Usuario.Trim(); }
        }

        public string _Sage50Password
        {
            get { return _sSage50Password.Trim(); }
        }

        public string _Sage50Empresa
        {
            get { return _sSage50Empresa.Trim(); }
        }
        #endregion propiedades

        #region consrtuctor
        public clsConfig()
        { }
        #endregion consrtuctor

        public bool _LoadConfig()
        {
            bool llOk = false;
            string lsFile = Path.Combine(_PathConfig, _FileConfig);

            if (string.IsNullOrEmpty(lsFile))
            {
                this._Error_Message = "No se ha indicado el nombre del fichero de configuración";
            }
            else
            {
                _oFileIni._File = lsFile;

                if (!clsFunctions._ValidateFile(lsFile))
                {
                    if (clsFunctions._CreateFile(lsFile))
                    {
                        _sSage50Usuario = "SUPERVISOR";

                        _WriteKey("TERMINAL", "", "SAGE50");
                        _WriteKey("USUARIO", _sSage50Usuario, "SAGE50");
                        _WriteKey("PASSWORD", "", "SAGE50");
                        _WriteKey("EMPRESA", "", "SAGE50");
                        _WriteKey("DEBUG", "False", "APPLICATION");

                    }
                }
                else
                {
                    _sSage50Terminal = _ReadKey("TERMINAL", "SAGE50");
                    _sSage50Usuario = _ReadKey("USUARIO", "SAGE50");
                    _sSage50Password = _ReadKey("PASSWORD", "SAGE50");
                    _sSage50Empresa = _ReadKey("EMPRESA", "SAGE50");

                    _sSage50Terminal = clsFunctions._CheckCorrectFolder(_sSage50Terminal).ToUpper();
                }

                llOk = true;
            }

            return llOk;

        }

        public string _ReadKey(string Key, string Section = null)
        {
            return _oFileIni.Read(Key, Section);
        }

        public void _WriteKey(string Key, string Value, string Section = null)
        {
            _oFileIni.Write(Key, Value, Section);
        }

        public void _DeleteKey(string Key, string Section = null)
        {
            _oFileIni.DeleteKey(Key, Section);
        }

        public string _EncriptaB64(string Text, bool Decode = false)
        {
            string lsText = "";

            if (!string.IsNullOrEmpty(Text.Trim()))
            {
                if (Decode)
                    lsText = clsFunctions._DecodeBase64(Text);
                else
                    lsText = clsFunctions._EncodeBase64(Text);
            }

            return lsText.Trim();
        }



    }

    //Clase para gestión ficheros .INI con secciones y claves
    internal class _FicheroIni
    {

        public string _File = "";

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, _File);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section, Key, Value, _File);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }

    }

}
