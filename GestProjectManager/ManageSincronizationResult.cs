using GestProjectManager.GatherFilteredData;
using GestProjectManager.ValidateData;

namespace GestProjectManager
{
    public class ManageSincronizationResult
    {
        public bool Error { get; set; } = true;
        public ManageSincronizationResult()
        {
            if(!new ValidateDataWorkflow().Error)
            {

            };
        }
    }
}
