using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProjectManager.ValidateData
{
    internal class CienteSynchronizer
    {   
        bool ESTADO {  get; set; }
        int ID {  get; set; }
        int ID_GP {  get; set; }
        string CUENTA_CONTABLE {  get; set; }
        string NOMBRE {  get; set; }
        string NOMBRE_COMERCIAL {  get; set; }
        string NIF {  get; set; }
        string DIRECCION {  get; set; }
        string CP {  get; set; }
        string LOCATIDAD {  get; set; }
        string PROVINCIA {  get; set; }
        string PAIS {  get; set; }
    }
}
