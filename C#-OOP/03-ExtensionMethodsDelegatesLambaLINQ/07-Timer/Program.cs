using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer
{
    class Program
    {
        static void Main()
        {
            TimerDelegate testMethod = new TimerDelegate(TestMethod);
            Timer timerTest = new Timer(testMethod, 4000);
            timerTest.Start();
            timerTest.End();
        }
        public static void TestMethod()
        {
            Console.WriteLine("Test works");
        }
    }
}
