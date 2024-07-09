using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProjectManager.Data
{
    public enum ParticipanteTipos
    {
        Cliente,
        Proveedor
    }

    public enum Fuentes
    {
        GestProject,
        Sage50
    }

    public enum SyncStatus
    {
        Identical, // Verde
        Different, // Amarillo
        UniqueToLeft, // Azul
        UniqueToRight // Rojo
    }

    public interface IIdentifiable<T>
    {
        string ID { get; }
        Fuentes Fuente { get; }
        SyncStatus compareTo(T other);
        string MatchingKey { get; }
    }

    public class SyncItem<T>
    {
        public SyncStatus SyncStatus { get; set; }
        public T LeftItem { get; set; }
        public T RightItem { get; set; }
        public T Display { get; set; }
    }

    public class Sage50_Cliente
    {
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string NOMBRE2 { get; set; }
        public string CIF { get; set; }
        public string DIRECCION { get; set; }
        public string CODPOST { get; set; }
        public string POBLACION { get; set; }
        public string PROVINCIA { get; set; }
        public string PAIS { get; set; }
        public string HTTP { get; set; }
        public string EMAIL { get; set; }
        public string CODIGO_TIPO
        {
            get
            {
                return CODIGO.Substring(0, 4);
            }
        }
        public int CODIGO_NUMERO
        {
            get
            {
                return int.Parse(CODIGO.Substring(4));
            }
        }
    }


    public class Sage50_Proveedor
    {
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string NOMBRE2 { get; set; }
        public string CIF { get; set; }
        public string DIRECCION { get; set; }
        public string CODPOST { get; set; }
        public string POBLACION { get; set; }
        public string PROVINCIA { get; set; }
        public string PAIS { get; set; }
        public string HTTP { get; set; }
        public string EMAIL { get; set; }
        public string CODIGO_TIPO
        {
            get
            {
                return CODIGO.Substring(0, 4);
            }
        }
        public int CODIGO_NUMERO
        {
            get
            {
                return int.Parse(CODIGO.Substring(4));
            }
        }
        public Sage50_Participante ToCommon()
        {
            return new Sage50_Participante {
                ID = this.CODIGO.Trim(),
                Fuente = Fuentes.Sage50,
                Tipos = new List<string> { "Proveedor" },

                CIF = this.CIF.Trim(),
                Nombre = this.NOMBRE,

                Direccion = this.DIRECCION,
                CodigoPostal = this.CODPOST,
                Poblacion = this.POBLACION,
                Provincia = this.PROVINCIA,
                Pais = this.PAIS,

                Email = this.EMAIL,
                PaginaWeb = this.HTTP,
            };
        }

        public static Sage50_Cliente FromCommon(Sage50_Participante common)
        {
            return new Sage50_Cliente {
                CODIGO = common.ID.Trim(),
                CIF = common.CIF.Trim(),
                NOMBRE = common.Nombre,

                DIRECCION = common.Direccion,
                CODPOST = common.CodigoPostal,
                POBLACION = common.Poblacion,
                PROVINCIA = common.Provincia,
                PAIS = common.Pais.Trim(),

                EMAIL = common.Email,
                HTTP = common.PaginaWeb
            };
        }
    }

    public class Sage50_Participante : IIdentifiable<Sage50_Participante>
    {
        public string ID { get; set; }
        public Fuentes Fuente { get; set; }
        public string MatchingKey { get => this.CIF; }
        public SyncStatus compareTo(Sage50_Participante other)
        {
            bool isIdentical =
        this.Nombre.Trim().Equals(other.Nombre.Trim(), StringComparison.OrdinalIgnoreCase)
        && this.Direccion == other.Direccion;

            return isIdentical ? SyncStatus.Identical : SyncStatus.Different;
        }
        public List<string> Tipos { get; set; }

        public string CIF { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string PaginaWeb { get; set; }
        public string Email { get; set; }

    }


    public class Sage50_IVA
    {
        public string GUID_ID { get; set; }
        public float IVA { get; set; }
        public string NOMBRE { get; set; }
        public string CODIGO { get; set; }
        public float RECARG { get; set; }
        public string CTA_IV_SOP { get; set; }
        public string CTA_IV_REP { get; set; }

        public Sage50_Impuesto ToCommon()
        {
            return new Sage50_Impuesto {
                ID = "IVA-" + this.CODIGO,
                Fuente = Fuentes.Sage50,
                Tipo = "IVA",
                Nombre = this.NOMBRE,
                Descripcion = "",
                ValorPrimario = this.IVA,
                ValorSecundario = this.RECARG,
                CuentaContable_Repercutido = this.CTA_IV_REP,
                CuentaContable_Soportado = this.CTA_IV_SOP
            };
        }

        public static Sage50_IVA FromCommon(Sage50_Impuesto common)
        {
            return new Sage50_IVA {
                CODIGO = common.ID.Split('-')[1],
                NOMBRE = common.Nombre,
                IVA = common.ValorPrimario,
                RECARG = (float)common.ValorSecundario,
                CTA_IV_REP = common.CuentaContable_Repercutido,
                CTA_IV_SOP = common.CuentaContable_Soportado
            };
        }
    }

    public class Sage50_Retenciones // IRPF
    {
        public string GUID_ID { get; set; }
        public string IRPF { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public float RETENCION { get; set; }
        public string CTA_RE_SOP { get; set; }
        public string CTA_RE_REP { get; set; }

        public Sage50_Impuesto ToCommon()
        {
            return new Sage50_Impuesto {
                ID = "IRPF-" + this.CODIGO,
                Fuente = Fuentes.Sage50,
                Tipo = "IRPF",
                Nombre = this.NOMBRE,
                Descripcion = "",
                ValorPrimario = this.RETENCION,
                CuentaContable_Repercutido = this.CTA_RE_REP,
                CuentaContable_Soportado = this.CTA_RE_SOP
            };
        }

        public static Sage50_Retenciones FromCommon(Sage50_Impuesto common)
        {
            return new Sage50_Retenciones {
                CODIGO = common.ID.Split('-')[1],
                NOMBRE = common.Nombre,
                RETENCION = common.ValorPrimario,
                CTA_RE_REP = common.CuentaContable_Repercutido,
                CTA_RE_SOP = common.CuentaContable_Soportado
            };
        }
    }

    public class Sage50_Impuesto : IIdentifiable<Sage50_Impuesto> // IVA e IRPF
    {
        public string ID { get; set; }
        public Fuentes Fuente { get; set; }

        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float ValorPrimario { get; set; }
        public float? ValorSecundario { get; set; }
        public string CuentaContable_Repercutido { get; set; }
        public string CuentaContable_Soportado { get; set; }

        public string MatchingKey { get => this.CuentaContable_Repercutido; }
        public SyncStatus compareTo(Sage50_Impuesto other)
        {
            bool isIdentical =
                    this.Nombre.Trim().Equals(other.Nombre.Trim(), StringComparison.OrdinalIgnoreCase)
                    && this.ValorPrimario == other.ValorPrimario
                    && (this.CuentaContable_Repercutido?.Trim().Equals(other.CuentaContable_Repercutido?.Trim(), StringComparison.OrdinalIgnoreCase) ?? false)
                    && (this.CuentaContable_Soportado?.Trim().Equals(other.CuentaContable_Soportado?.Trim(), StringComparison.OrdinalIgnoreCase) ?? false)
                    && this.Tipo.Equals(other.Tipo, StringComparison.OrdinalIgnoreCase);

            return isIdentical ? SyncStatus.Identical : SyncStatus.Different;
        }
    }




    public class Sage50_FacturaEmitida
    {
        public string GUID_ID { get; set; }
        public string USUARIO { get; set; }
        public string EMPRESA { get; set; }
        public string LETRA { get; set; }
        public string NUMERO { get; set; }
        public DateTime FECHA { get; set; }
        public string CLIENTE { get; set; }
        public string ALMACEN { get; set; }
        public string VENDEDOR { get; set; }
        public string FPAG { get; set; }
        public string OBSERVACIO { get; set; }
        public string FACTURA { get; set; }
        public DateTime FECHA_FAC { get; set; }
        public string ASI { get; set; }
        public float IMPORTE { get; set; }
        public float IMPDIVISA { get; set; }
        public float TOTALDOC { get; set; }

        public Sage50_FacturaEmitida_Model ToCommon()
        {
            return new Sage50_FacturaEmitida_Model {
                ID = this.GUID_ID,
                Fuente = Fuentes.Sage50,
                Serie = this.LETRA,
                Numero = this.NUMERO,
                Fecha = this.FECHA,
            };
        }

        public static Sage50_FacturaEmitida FromCommon(Sage50_FacturaEmitida_Model common)
        {
            return new Sage50_FacturaEmitida {
                GUID_ID = common.ID,
                USUARIO = "",
                EMPRESA = "",
                LETRA = common.Serie,
                NUMERO = common.Numero,
                FECHA = common.Fecha,
                CLIENTE = common.Emisor,
                ALMACEN = "",
                VENDEDOR = "",
                FPAG = "",
                OBSERVACIO = "",
                IMPORTE = common.BaseImponible,
                IMPDIVISA = common.SumaImpuestos,
                TOTALDOC = common.TotalFactura

            };
        }
    }

    public class Sage50_FacturaEmitidaDetalle
    {
        public string GUID_ID { get; set; }
        public string LETRA { get; set; }
        public string NUMERO { get; set; }


        public string ARTICULO { get; set; } = "";
        public string DEFINICION { get; set; } = "";
        public decimal PRECIO { get; set; } = 0;
        public decimal UNIDADES { get; set; } = 0;
        public float IMPORTE { get; set; }
        public float DTO1 { get; set; }
        public float DTO2 { get; set; }
        public string TIPO_IVA { get; set; } = "";
        public float PRECIOIVA { get; set; }
        public float IMPORTEIVA { get; set; }
        public float PRECIODIV { get; set; }
        public float IMPORTEDIV { get; set; }
        public float IMPDIVIVA { get; set; }
        public float PREDIVIVA { get; set; }


        public Sage50_FacturaEmitidaDetalle_Model ToCommon()
        {
            return new Sage50_FacturaEmitidaDetalle_Model {
                FacturaID = this.GUID_ID,
                ID = this.NUMERO,
                Concepto = this.DEFINICION,
                PrecioUnitario = this.PRECIO,
                Unidades = this.UNIDADES,
                TIPO_IVA = this.TIPO_IVA
            };
        }

        public static Sage50_FacturaEmitidaDetalle FromCommon(Sage50_FacturaEmitidaDetalle_Model common)
        {
            return new Sage50_FacturaEmitidaDetalle {
                NUMERO = common.FacturaID,
                GUID_ID = common.ID,
                DEFINICION = common.Concepto,
                PRECIO = common.PrecioUnitario,
                UNIDADES = common.Unidades,
                TIPO_IVA = common.TIPO_IVA
            };
        }

    }


    public class Sage50_FacturaEmitida_Model : IIdentifiable<Sage50_FacturaEmitida_Model>
    {
        public string ID { get; set; }
        public Fuentes Fuente { get; set; }
        public string MatchingKey { get => this.Serie + this.Numero; }
        public SyncStatus compareTo(Sage50_FacturaEmitida_Model other)
        {
            // TODO

            return SyncStatus.Different;
        }

        public int EmisorID { get; set; }
        public string Emisor { get; set; }

        public string Serie { get; set; }
        public string Numero { get; set; }

        public string Referencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Ejercicio { get; set; }
        public string Departamento { get; set; }
        public string Adjunto { get; set; }
        public float BaseImponible { get; set; }
        public float SumaImpuestos { get; set; } //(Suma de Impuestos de detalles)
        public float ADeducir { get; set; }  // (suma de A deducir)
        public float Suplido { get; set; }
        public float TotalFactura { get; set; } // (suma de Bases imponibles+Impuestos-Adeducir+Suplidos)
        public float Cobrado { get; set; }
        public float PendientePago { get; set; }
        public string Concepto { get; set; }
        public string Observaciones { get; set; }
        public bool Rectificada { get; set; }
        public List<Sage50_FacturaEmitidaDetalle_Model> Detalles { get; set; } = new List<Sage50_FacturaEmitidaDetalle_Model>();
    }

    public class Sage50_FacturaEmitidaDetalle_Model
    {
        public string FacturaID { get; set; }
        public string ID { get; set; }
        public string TIPO_IVA { get; set; } = "";
        public string Concepto { get; set; } = "";
        public decimal PrecioUnitario { get; set; } = 0;
        public decimal Unidades { get; set; } = 0;
    }
}
