using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestProjectManager.Data
{
    public static class PrintClassProperties
    {
        public static void Print(object obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("Class Properties:");

            foreach(PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                messageBuilder.AppendLine($"{property.Name}: {value}");
            }

            string message = messageBuilder.ToString();
            MessageBox.Show(message);
        }
    }
}
