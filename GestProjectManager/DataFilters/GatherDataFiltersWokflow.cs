using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProjectManager.DataFilters
{
    internal class GatherDataFiltersWokflow
    {
        public bool Error { get; set; } = true;
        public GatherDataFiltersWokflow() 
        {
            if(!new PromptForDates().Error)
            {
                //if(!new CreateSQLCommandConditional().Error)
                //{

                //}
            }
        }
    }
}
