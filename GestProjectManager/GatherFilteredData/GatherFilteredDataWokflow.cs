using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.GatherFilteredData
{
    internal class GatherFilteredDataWokflow
    {
        public bool Error { get; set; } = true;
        public GatherFilteredDataWokflow() 
        {
            if(!new PromptForDates().Error)
            {
                if(!new CreateSelectSQLCommands().Error)
                {
                    if(!new ExecuteSelectSQLCommands().Error)
                    {
                        if(!new GenerateFilteredDataViews().Error)
                        {
                            //MessageBox.Show("Gestproject GatherFilteredDataWokflow successfully executed.");
                            Error = false;
                        }
                    }
                }
            }
        }
    }
}
