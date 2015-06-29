using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TimerEvents
{
    public class ConsoleLogger
    {
        public ConsoleLogger(Timer timer)
        {
            timer.TickEvent += HandleTickEvent;
        }
        private void HandleTickEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Tick");
        }
    }
}
