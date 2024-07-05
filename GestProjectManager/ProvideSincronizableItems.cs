using GestProjectManager.DatabaseConnection;
using GestProjectManager.DataFilters;
using System.Windows.Forms;

namespace GestProjectManager
{
    public class ProvideSincronizableItems
    {
        static ProvideSincronizableItems()
        {
            if(!new DatabaseConnectionWorkflow().Error)
            {
                if(!new GatherDataFiltersWokflow().Error)
                {
                    //if(!new GatherFilteredDataWokflow().Error)
                    //{
                    //    if(!new ValidateDataWokflow().Error)
                    //    {
                    //        if(!new StoreNonConformantDataWokflow().Error)
                    //        {
                    //            if(!new IndicateNonConformantDataWokflow().Error)
                    //            {
                    //                if(!new StoreConformantDataWokflow().Error)
                    //                {
                    //                    if(!new PrepareConformantDataForSincronizationWokflow().Error)
                    //                    {
                    //                        //new GatherDataFiltersWokflow();
                    //                    };
                    //                };
                    //            };
                    //        };
                    //    };
                    //};
                };
            };
        }
    }
}
