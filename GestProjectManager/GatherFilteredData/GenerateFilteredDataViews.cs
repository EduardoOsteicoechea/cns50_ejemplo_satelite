using GestProjectManager.Data;

namespace GestProjectManager.GatherFilteredData
{
    internal class GenerateFilteredDataViews
    {
        public bool Error { get; set; } = true;
        public GenerateFilteredDataViews() 
        {
            new GenerateFilteredDataView<Cliente>(
                ValueHolder.ClientesSelectCommand,
                ValueHolder.ClienteClassList
            );
            //new GenerateFilteredDataView<Proveedor>(
            //    ValueHolder.ProveedoresSelectCommand,
            //    ValueHolder.ProveedorClassList
            //);
            //new GenerateFilteredDataView<Impuesto>(
            //    ValueHolder.ImpuestosSelectCommand,
            //    ValueHolder.ImpuestoClassList
            //);
            //new GenerateFilteredDataView<Proyecto>(
            //    ValueHolder.ProyectosSelectCommand,
            //    ValueHolder.ProyectoClassList
            //);
            //new GenerateFilteredDataView<FacturaEmitida>(
            //    ValueHolder.FacturasEmitidasSelectCommand,
            //    ValueHolder.FacturaEmitidaClassList
            //);

            Error = false;
        }
    }
}