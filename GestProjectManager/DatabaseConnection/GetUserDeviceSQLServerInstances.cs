using GestProjectManager.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.DatabaseConnection
{
    internal class GetUserDeviceSQLServerInstances
    {
        public string MicrosoftSQLServerfolderPath { get; set; } =
        Environment.GetEnvironmentVariable("ProgramFiles") + @"\" + "Microsoft SQL Server";
        public List<string> DatabaseInstancesNames { get; set; } = new List<string>();
        public List<string> DatabaseVersionNames { get; set; } = new List<string>();
        public bool Error { get; set; } = true;
        public GetUserDeviceSQLServerInstances() 
        {
            if(Directory.Exists(MicrosoftSQLServerfolderPath))
            {
                string[] folderNames = Directory.GetDirectories(MicrosoftSQLServerfolderPath);
                string aa = "";

                for(global::System.Int32 i = 0; i < folderNames.Length; i++)
                {
                    string folderName = folderNames[i];
                    if(folderName.Contains("GESTPROJECT"))
                    {
                        string gestprojectDatabaseInstanceName = folderName.Split('\\').Last();
                        DatabaseInstancesNames.Add(gestprojectDatabaseInstanceName);

                        string gestprojectDatabaseInstanceProgramVersionName = gestprojectDatabaseInstanceName.Split('.').FirstOrDefault(part => part.Contains("GESTPROJECT"));

                        DatabaseVersionNames.Add(gestprojectDatabaseInstanceProgramVersionName);
                    };
                }

                if(DatabaseVersionNames.Count > 0)
                {
                    ValueHolder.GestprojectVersionNames = DatabaseVersionNames;
                    ValueHolder.GestprojectVersionName = DatabaseVersionNames.Last();
                    Error = false;
                }
                else
                {
                    MessageBox.Show("No hay servidores de Gestproject en la carpeta de Microsoft SQL Server.\n\nVerifica si Gestproject está instalado en tu dispositivo.");
                };

                for(global::System.Int32 i = 0; i < DatabaseVersionNames.Count; i++)
                {
                    aa += DatabaseVersionNames[i] + "\n";
                }
            }
            else
            {
                MessageBox.Show("La carpeta de Microsoft SQL Server no existe en tu dispositivo.\n\nVerifica si Microsoft SQL Server está instalado.");
            }

        }
    }
}
