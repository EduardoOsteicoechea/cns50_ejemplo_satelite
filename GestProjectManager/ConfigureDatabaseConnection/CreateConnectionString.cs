using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.ConfigureDatabaseConnection
{
    internal class CreateConnectionString
    {
        public bool Error { get; set; } = true;
        public CreateConnectionString() 
        {
            string serverName = "";
            if(GestprojectDataValueHolder.WindowsIdentityDomainName != null) 
            {
                serverName += GestprojectDataValueHolder.WindowsIdentityDomainName + "\\" + GestprojectDataValueHolder.GestprojectVersionName;
            }
            else
            {
                serverName += GestprojectDataValueHolder.WindowsIdentityUserName + "\\" + GestprojectDataValueHolder.GestprojectVersionName;
            };

            string connectionString = "";
            connectionString += $"Server={serverName};";
            connectionString += $"Database={GestprojectDataValueHolder.GestprojectVersionName};";
            connectionString += $"Trusted_Connection=true;";

            GestprojectDataValueHolder.ConnectionString = connectionString;
            MessageBox.Show(GestprojectDataValueHolder.ConnectionString);
            Error = false;
        }
    }
}
