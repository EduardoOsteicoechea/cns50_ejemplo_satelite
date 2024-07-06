using System.Collections.Generic;

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
}