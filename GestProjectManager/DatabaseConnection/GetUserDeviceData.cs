using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.DatabaseConnection
{ 
    internal class GetUserDeviceData
    {
        public string WindowsIdentityDomainName { get; set; } = null;
        public string WindowsIdentityUserName { get; set; } = null;
        public bool Error { get; set; } = true;
        public GetUserDeviceData() 
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            string userName = identity.Name;
            string[] userNameParts = userName.Split('\\');

            if(userNameParts.Length == 1)
            {
                WindowsIdentityUserName = Environment.UserName;
            }
            else
            {
                WindowsIdentityDomainName = userNameParts[0];
                WindowsIdentityUserName = userNameParts[1];
            };

            if(WindowsIdentityDomainName != null && WindowsIdentityUserName != null)
            {
                Error = false;
                ValueHolder.WindowsIdentityDomainName = WindowsIdentityDomainName;
                ValueHolder.WindowsIdentityUserName = WindowsIdentityUserName;
            }
            else if(WindowsIdentityUserName != null && WindowsIdentityDomainName == "")
            {
                Error = false;
                ValueHolder.WindowsIdentityUserName = WindowsIdentityUserName;
            }
            else if(WindowsIdentityUserName == "")
            {
                MessageBox.Show("No logramos encontrar el nombre de usuario.\n\nContacte al proveedor para más información.");
            };
        }
    }
}
