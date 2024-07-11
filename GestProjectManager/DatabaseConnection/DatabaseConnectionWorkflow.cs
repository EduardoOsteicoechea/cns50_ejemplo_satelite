using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.DatabaseConnection
{
    internal class DatabaseConnectionWorkflow
    {
        public bool Error { get; set; } = true;
        public DatabaseConnectionWorkflow() 
        {
            if(!new GetUserDeviceData().Error)
            {
                if(!new GetUserDeviceSQLServerInstances().Error)
                {
                    //if(!new PromptForServerSelection().Error)
                    //{
                        if(!new CreateConnectionString().Error)
                        {
                            if(!new ConnectToGestProjectDatabase().Error)
                            {
                                //MessageBox.Show("Gestproject database connection workflow successfully executed.");
                                Error = false;
                            };
                        };
                    //};
                };
            };
        }
    }
}
