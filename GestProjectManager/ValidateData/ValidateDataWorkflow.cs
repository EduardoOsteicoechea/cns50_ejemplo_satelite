using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProjectManager.ValidateData
{
    internal class ValidateDataWorkflow
    {
        public bool Error { get; set; } = true;
        public ValidateDataWorkflow() 
        {
            
            if(!new CompareClients().Error)
            {

            };
        }
    }
}
