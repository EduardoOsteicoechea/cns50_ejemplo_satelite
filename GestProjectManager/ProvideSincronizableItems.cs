using GestProjectManager.DatabaseConnection;
using GestProjectManager.GatherFilteredData;
using GestProjectManager.ValidateData;
using System.Windows.Forms;

namespace GestProjectManager
{
    public class ProvideSincronizableItems
    {
        static ProvideSincronizableItems()
        {
            if(!new DatabaseConnectionWorkflow().Error)
            {
                if(!new GatherFilteredDataWokflow().Error)
                {
                    new ValidateDataWorkflow();
                };
            };
        }
    }
}
