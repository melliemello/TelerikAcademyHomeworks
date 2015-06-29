using System;
using System.Collections;
using System.Text;

namespace _03_Print_Company
{
    class PrintCompany
    {
        static void Main(string[] args)
        {
           string[] companyAttributes = new string[] {"Name","Address","Phone","Fax","Web","Manager First Name","Manager Last Name","Manager Age","Manager Phone"};
           Hashtable companyInfo = new Hashtable();           

           foreach (string key in companyAttributes)
           {
                Console.WriteLine(key + ":");
                companyInfo[key] = Console.ReadLine();
           }

           Console.WriteLine("{0}\nAddress:{1}\nPhone:{2}\nFax:{3}\nWeb:{4}\nManager{5} {6}(age:{7}, tel:{8})", companyInfo["Name"], companyInfo["Address"], companyInfo["Phone"], companyInfo["Fax"], companyInfo["Web"], companyInfo["Manager First Name"], companyInfo["Manager Last Name"], companyInfo["Manager Age"], companyInfo["Manager Phone"]);

           


        }
    }
}
