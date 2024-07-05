using GestProjectManager.ConfigureDatabaseConnection;
using System.Windows.Forms;

namespace GestProjectManager
{
    public class ProvideSincronizableItems
    {
        static ProvideSincronizableItems()
        {
            
            GetUserDeviceData userDeviceData = new GetUserDeviceData();
            if(!userDeviceData.Error)
            {
                GetUserDeviceSQLServerInstances userDeviceSQLServerInstances = new GetUserDeviceSQLServerInstances();
                if(!userDeviceSQLServerInstances.Error)
                {
                    PromptForServerSelection promptForServerSelection = new PromptForServerSelection();
                    if(!promptForServerSelection.Error)
                    {
                        CreateConnectionString createConnectionString = new CreateConnectionString();
                        if(!createConnectionString.Error)
                        {
                            ConnectToGestProjectDatabase connectToGestProjectDatabase = new ConnectToGestProjectDatabase();
                            if(!connectToGestProjectDatabase.Error)
                            {
                                MessageBox.Show("Gestproject database connection workflow successfully executed.");
                            }
                        }
                    }
                };
            };
            //new GatherDataFilters();
            //new GatherFilteredData();
            //new ValidateData();
            //new StoreNonConformantData();
            //new IndicateNonConformantData();
            //new StoreConformantData();
            //new PrepareConformantDataForSincronization();
        }
    }
}
