using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ETUDIANT.Models
{
    public class Convert
    {
        public static string ListToString(List<String> modules)
        {
            string modulesString = "";
            foreach (var elt in modules)
            {
                modulesString += elt + ";";
            }
            return modulesString;
        }
        public static List<String> StringToList(String modules)
        {
            return modules.Split(';').ToList();
        }

        internal static string StringToList(List<string> modules)
        {
            throw new NotImplementedException();
        }
    }
}
