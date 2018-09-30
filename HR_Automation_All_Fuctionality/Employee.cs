using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Automation_All_Fuctionality
{
   
   public class Employee
   {
      public Dictionary<string, string> Fields = new Dictionary<string, string>();
      public Employee()
      {
         int No_of_colums_in_excel = int.Parse(ConfigurationSettings.AppSettings.Get("No_of_colums_in_excel"));

         for (int i = 0; i < No_of_colums_in_excel; i++)
         {
            Fields.Add("a" + i, null);
         }

      }
   }
}
