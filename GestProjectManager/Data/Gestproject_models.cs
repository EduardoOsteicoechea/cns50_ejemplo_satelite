using System;
using System.Collections.Generic;
using System.Reflection;

namespace GestProjectManager.Data
{
    static class ClientesTableData
    {
        public static string Table1Name = "PARTICIPANTE";
        public static string Table2Name = "PAR_TPA";
        public static string Table3Name = "TIPO_PARTICIPANTE";

        public static string DateFilterableField1 = "PAR_FECHA_ALTA";
        public static List<string> FieldsToQuery = new List<string>{
            "PAR_ID",
            "PAR_SUBCTA_CONTABLE",
            "PAR_NOMBRE",
            "PAR_NOMBRE_COMERCIAL",
            "PAR_CIF_NIF",
            "PAR_DIRECCION_1",
            "PAR_CP_1",
            "PAR_LOCALIDAD_1",
            "PAR_PROVINCIA_1",
            "PAR_PAIS_1",
        };
    }
    public class Cliente
    {
        public int PAR_ID { get; set; }
        public string PAR_SUBCTA_CONTABLE { get; set; }
        public string PAR_NOMBRE { get; set; }
        public string PAR_NOMBRE_COMERCIAL { get; set; }
        public string PAR_CIF_NIF { get; set; }
        public string PAR_DIRECCION_1 { get; set; }
        public string PAR_CP_1 { get; set; }
        public string PAR_LOCALIDAD_1 { get; set; }
        public string PAR_PROVINCIA_1 { get; set; }
        public string PAR_PAIS_1 { get; set; }
        public DateTime PAR_FECHA_ALTA { get; set; }
        public void FillProperties(List<string> values)
        {
            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                properties[i].SetValue(this, values[i]);
            };
        }
    }



    static class ProveedoresTableData
    {
        public static string Table1Name = "PARTICIPANTE";
        public static string Table2Name = "PAR_TPA";
        public static string Table3Name = "TIPO_PARTICIPANTE";

        public static string DateFilterableField1 = "PAR_FECHA_ALTA";
        public static List<string> FieldsToQuery = new List<string>{
            "PAR_ID",
            "PAR_SUBCTA_CONTABLE_2",
            "PAR_NOMBRE",
            "PAR_NOMBRE_COMERCIAL",
            "PAR_CIF_NIF",
            "PAR_DIRECCION_1",
            "PAR_CP_1",
            "PAR_LOCALIDAD_1",
            "PAR_PROVINCIA_1",
            "PAR_PAIS_1",
        };
    }
    public class Proveedor
    {
        public int PAR_ID { get; set; }
        public string PAR_SUBCTA_CONTABLE_2 { get; set; }
        public string PAR_NOMBRE { get; set; }
        public string PAR_NOMBRE_COMERCIAL { get; set; }
        public string PAR_CIF_NIF { get; set; }
        public string PAR_DIRECCION_1 { get; set; }
        public string PAR_CP_1 { get; set; }
        public string PAR_LOCALIDAD_1 { get; set; }
        public string PAR_PROVINCIA_1 { get; set; }
        public string PAR_PAIS_1 { get; set; }
        public DateTime PAR_FECHA_ALTA { get; set; }
    }


    static class ImpuestosTableData
    {
        public static string Table1Name = "IMPUESTO_CONFIG";

        public static string NameFilterableField1 = "IMP_TIPO";
        public static string DateFilterableField1 = null;
        public static List<string> FieldsToQuery = new List<string>{
            "IMP_ID",
            "IMP_TIPO",
            "IMP_NOMBRE",
            "IMP_VALOR",
            "IMP_SUBCTA_CONTABLE",
            "IMP_SUBCTA_CONTABLE_2",
        };
    }
    public class Impuesto
    {
        public int IMP_ID { get; set; }
        public string IMP_TIPO { get; set; }
        public string IMP_NOMBRE { get; set; }
        public decimal IMP_VALOR { get; set; }
        public string IMP_SUBCTA_CONTABLE { get; set; }
        public string IMP_SUBCTA_CONTABLE_2 { get; set; }
    }



    static class ProyectosTableData
    {
        public static string Table1Name = "PROYECTO";

        public static string DateFilterableField1 = "PRY_FECHA_INICIO";
        public static List<string> FieldsToQuery = new List<string>{
            "PRY_ID",
            "PRY_CODIGO",
            "PRY_NOMBRE",
            "PRY_DIRECCION",
            "PRY_LOCALIDAD",
            "PRY_PROVINCIA",
            "PRY_CP",
            "PRY_FECHA_INICIO",
        };
    }
    public class Proyecto
    {
        public int PRY_ID { get; set; }
        public string PRY_CODIGO { get; set; }
        public string PRY_NOMBRE { get; set; }
        public string PRY_DIRECCION { get; set; }
        public string PRY_LOCALIDAD { get; set; }
        public string PRY_PROVINCIA { get; set; }
        public string PRY_CP { get; set; }
        public DateTime PRY_FECHA_INICIO { get; set; }
    }



    static class FacturasEmitidasTableData
    {
        public static string Table1Name = "FACTURA_EMITIDA";

        public static string DateFilterableField1 = "FCE_FECHA";
        public static List<string> FieldsToQuery = new List<string>{
            "FCE_ID",
            "PAR_DAO_ID",
            "FCE_REFERENCIA",
            "FCE_NUM_FACTURA",
            "FCE_FECHA",
            "PAR_CLI_ID",
            "FCE_BASE_IMPONIBLE",
            "FCE_VALOR_IVA",
            "FCE_IVA",
            "FCE_VALOR_IRPF",
            "FCE_IRPF",
            "FCE_TOTAL_SUPLIDO",
            "FCE_TOTAL_FACTURA",
            "FCE_OBSERVACIONES",
        };
    }
    public class FacturaEmitida
    {
        public int FCE_ID { get; set; }
        public int PAR_DAO_ID { get; set; }
        public string FCE_REFERENCIA { get; set; }
        public int FCE_NUM_FACTURA { get; set; }
        public DateTime FCE_FECHA { get; set; }
        public int PAR_CLI_ID { get; set; }
        public decimal FCE_BASE_IMPONIBLE { get; set; }
        public decimal FCE_VALOR_IVA { get; set; }
        public decimal FCE_IVA { get; set; }
        public decimal FCE_VALOR_IRPF { get; set; }
        public decimal FCE_IRPF { get; set; }
        public decimal FCE_TOTAL_SUPLIDO { get; set; }
        public decimal FCE_TOTAL_FACTURA { get; set; }
        public string FCE_OBSERVACIONES { get; set; }
    }
}