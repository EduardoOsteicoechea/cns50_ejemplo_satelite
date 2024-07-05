using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExampleSatelite.Clases
{
    public static class clsFunctions
    {
        static string _Error_Message = "";

        /// <summary>
        /// Método para agregar carpetas al path de busqueda de dll 
        /// </summary>
        /// <param name="tsFolder"></param>
        /// <returns></returns>
        public static Boolean _LoadDllDynamicFromPath(string tsFolder = "")
        {
            Boolean llOk = false, llExiste = false;

            if (!string.IsNullOrEmpty(tsFolder.Trim()))
            {
                var lsPath = new[] { Environment.GetEnvironmentVariable("PATH") ?? string.Empty };

                foreach (string lsTexto in lsPath)
                {
                    if (llExiste == false)
                        llExiste = lsTexto.Contains(tsFolder);
                    else
                        break;
                }

                if (llExiste == false)
                {
                    var lsPathDll = new[] { tsFolder };
                    string lsnewPath = string.Join(Path.PathSeparator.ToString(), lsPath.Concat(lsPathDll));
                    Environment.SetEnvironmentVariable("PATH", lsnewPath);

                }

                llOk = true;
            }

            return llOk;
        }

        /// <summary>
        /// Método para obtener una carpeta temporal
        /// </summary>
        /// <returns></returns>
        public static string _TemporaryFolder()
        {
            string lcTmpFolder = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName()));
            Directory.CreateDirectory(lcTmpFolder);

            return lcTmpFolder;
        }


        /// <summary>
        /// Verifica que la cadena que indica la carpeta , tiene la terminacion "\"
        /// Ejemplo C:\_BORRAR\
        /// </summary>
        /// <param name="tsFolder"></param>
        /// <returns></returns>
        public static string _CheckCorrectFolder(string tsFolder = "")
        {
            if (!String.IsNullOrEmpty(tsFolder))
                if (!tsFolder.EndsWith("\\"))
                    tsFolder = tsFolder.Trim() + "\\";

            return tsFolder;
        }

        /// <summary>
        /// Valida si existe una carpeta(ruta, parametro de creacion) 
        /// </summary>
        /// <param name="tsFolder"></param>
        /// <param name="tbCreate"></param>
        /// <returns></returns>
        public static Boolean _ValidateFolder(string tsFolder = "", Boolean tbCreate = false)
        {
            Boolean llOk = false;
            if (!String.IsNullOrEmpty(tsFolder))
            {
                if (Directory.Exists(tsFolder))
                {
                    llOk = true;
                }
                else
                {
                    if (tbCreate == true)
                    {
                        try
                        {
                            DirectoryInfo di = Directory.CreateDirectory(tsFolder);
                            llOk = true;
                        }
                        catch (Exception e)
                        {
                            _Error_Message = e.ToString();
                        }
                        finally { }
                    }
                }
            }
            return llOk;
        }

        /// <summary>
        /// Retorna un FileInfo[] con el listado de archivos de una carpeta y/o subcarpetas 
        /// tsWildcard = string de comodín para realizar la busqueda de ficheros 
        /// </summary>
        /// <param name="tsFolder"></param>
        /// <param name="tsWildcard"></param>
        /// <param name="tbSubFolder"></param>
        /// <returns></returns>
        public static FileInfo[] _LoadFilesFolder(string tsFolder = "", string tsWildcard = "", Boolean tbSubFolder = false)
        {
            FileInfo[] listfile = null;

            if (!String.IsNullOrEmpty(tsFolder))
            {
                DirectoryInfo di = new DirectoryInfo(tsFolder);

                if (!string.IsNullOrEmpty(tsWildcard.Trim()))
                {
                    if (tbSubFolder)
                    {
                        listfile = di.GetFiles(tsWildcard.Trim(), SearchOption.AllDirectories);
                    }
                    else
                    {
                        listfile = di.GetFiles(tsWildcard.Trim());
                    }
                }
                else
                {
                    if (tbSubFolder)
                    {
                        listfile = di.GetFiles("", SearchOption.AllDirectories);
                    }
                    else
                    {
                        listfile = di.GetFiles();
                    }
                }

            }

            return listfile;
        }

        /// <summary>
        /// Validar si existe un fichero (ruta + fichero)
        /// </summary>
        /// <param name="tsFile"></param>
        /// <returns></returns>
        public static Boolean _ValidateFile(string tsFile = "")
        {
            Boolean llOk = false;

            if (!String.IsNullOrEmpty(tsFile))
            {
                if (File.Exists(tsFile))
                {
                    llOk = true;
                }
            }

            return llOk;
        }

        /// <summary>
        /// Copiar un fichero origen (ruta + fichero) -> destino (ruta + fichero)
        /// </summary>
        /// <param name="tsFromFile"></param>
        /// <param name="tsToFile"></param>
        /// <param name="tbOverWriting"></param>
        /// <returns></returns>
        public static Boolean _CopyFile(string tsFromFile = "", string tsToFile = "", Boolean tbOverWriting = false)
        {
            Boolean llOk = false;

            if (!String.IsNullOrEmpty(tsFromFile) && !String.IsNullOrEmpty(tsToFile))
            {
                File.Copy(tsFromFile, tsToFile, tbOverWriting);

                llOk = _ValidateFile(tsToFile);
            }

            return llOk;
        }

        /// <summary>
        /// Borrar un fichero (ruta + fichero)
        /// </summary>
        /// <param name="tsFile"></param>
        /// <returns></returns>
        public static Boolean _DeleteFile(string tsFile = "")
        {
            Boolean llOk = false;

            if (!String.IsNullOrEmpty(tsFile))
            {
                try
                {
                    File.Delete(tsFile);
                    llOk = true;
                }
                catch (IOException e)
                {
                    _Error_Message = e.Message.Trim();
                }
            }

            return llOk;
        }

        /// <summary>
        /// Crear un fichero (ruta + fichero)
        /// </summary>
        /// <param name="tsFile"></param>
        /// <param name="tsText"></param>
        /// <returns></returns>
        public static Boolean _CreateFile(string tsFile = "", string tsText = "")
        {
            Boolean llOk = false;

            if (!String.IsNullOrEmpty(tsFile))
            {
                try
                {
                    StreamWriter loWriterFile = new StreamWriter(tsFile);

                    if (!String.IsNullOrEmpty(tsText.Trim()))
                    {
                        loWriterFile.WriteLine(tsText.Trim());
                    }
                    else
                    {
                        loWriterFile.WriteLine("");
                    }
                    loWriterFile.Close();

                    llOk = _ValidateFile(tsFile);
                }
                catch (IOException e)
                {
                    _Error_Message = e.Message.Trim();
                }
            }

            return llOk;
        }

        /// <summary>
        /// Obtenemos la extensión de un fichero en minusculas incluido el punto, ejemplo: (.txt, .csv, .xdocx, xlsx, etc)
        /// </summary>
        /// <param name="tsFile"></param>
        /// <returns></returns>
        public static String _FileExtension(string tsFile = "")
        {
            string lsExt = "";

            lsExt = Path.GetExtension(tsFile).ToLower();

            return lsExt;
        }

        /// <summary>
        /// Codificar textos en base64
        /// </summary>
        /// <param name="tstextCode"></param>
        /// <param name="tencoding"></param>
        /// <returns></returns>
        public static String _EncodeBase64(string tstextCode, Encoding tencoding = null)
        {
            if (tstextCode == null) return null;

            tencoding = tencoding ?? Encoding.UTF8;
            var bytes = tencoding.GetBytes(tstextCode);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Decodificar base64 en texto
        /// </summary>
        /// <param name="tsencodedText"></param>
        /// <param name="tencoding"></param>
        /// <returns></returns>
        public static String _DecodeBase64(string tsencodedText, Encoding tencoding = null)
        {
            if (tsencodedText == null) return null;

            tencoding = tencoding ?? Encoding.UTF8;
            var bytes = Convert.FromBase64String(tsencodedText);
            return tencoding.GetString(bytes);
        }


    }
}
