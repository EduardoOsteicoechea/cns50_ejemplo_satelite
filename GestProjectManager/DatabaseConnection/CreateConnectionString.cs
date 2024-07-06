using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.DatabaseConnection
{
    internal class CreateConnectionString
    {
        public bool Error { get; set; } = true;
        public CreateConnectionString() 
        {
            string serverName = "";
            if(ValueHolder.WindowsIdentityDomainName != null) 
            {
                serverName += ValueHolder.WindowsIdentityDomainName + "\\" + ValueHolder.GestprojectVersionName;
            }
            else
            {
                serverName += ValueHolder.WindowsIdentityUserName + "\\" + ValueHolder.GestprojectVersionName;
            };

            string connectionString = "";
            connectionString += $"Server={serverName};";
            connectionString += $"Database={ValueHolder.GestprojectVersionName};";
            connectionString += $"Trusted_Connection=true;";

            ValueHolder.ConnectionString = connectionString;

            Error = false;
        }
    }
}
