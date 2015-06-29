using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GSMCallHistoryTest
    {
        public GSMCallHistoryTest()
        {
            GSM phone = new GSM("Gsm model", "Gsm Manufacturer", new Display("duper display", 12, 256), new Battery("super battery 1", BatteryType.Li_ion));

            //Initialize and print call history
            for (int i = 0; i < 10; i++ )
            {
                phone.AddCall(new Call("088892321" + i, DateTime.Now, 16 + 10 * i));
                Console.WriteLine("Call History Entry N:{0}: {1}",i, Environment.NewLine +  phone.CallHistory[i].ToString());
                
            }
            //Calculate price of the calls
            Console.WriteLine("Call Price: {0}",phone.CallPrice(0.37));

            //Find the longest call duration and remove it from the list
            IEnumerable<Call> sortedHistory = phone.CallHistory.OrderBy( c => c.Duration);
            phone.DeleteCall(sortedHistory.ElementAt(phone.CallHistory.Count -1));

            //Print the call history after removing the call
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                Console.WriteLine("Call History after removing the first call: {0}", Environment.NewLine + phone.CallHistory[i].ToString());

            }

            
        }
    }
}
