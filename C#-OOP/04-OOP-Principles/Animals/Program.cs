using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Pesho",12, Gender.Male);
            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Pesho",13),
                new Tomcat("Goshko",12),
                new Tomcat("Pencho",6),
                new Tomcat("Gencho",2)
            };

            Console.WriteLine("The average age of our tomcats is:{0}",Tomcat.AverageAge(tomcats)); 
            
        }
    }
}
