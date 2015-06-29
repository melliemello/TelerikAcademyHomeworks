using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TimerEvents
{
    class Program
    {
        static void Main()
        {
            Timer testTimer = new Timer(2000);
            ConsoleLogger logger = new ConsoleLogger(testTimer);
            testTimer.Start();
        }
    }
}
