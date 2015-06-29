using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GSMTest
    {
        private const int NUMBER = 10;
        private GSM[] gsms = new GSM[NUMBER];
        public GSMTest()
        {
            for (int i = 0; i < NUMBER; i++ )
            {
                gsms[i] = new GSM("model" + i, "manufacturer" + i);
                Console.WriteLine("GSM Test N:{0}, {1}",i,gsms[i].ToString());
            }
            Console.WriteLine("IPHONE4 Test:{0}:",GSM.IPhone4s);
        }
    }
}
