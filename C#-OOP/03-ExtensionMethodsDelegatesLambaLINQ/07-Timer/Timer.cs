using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Timer
{
    public delegate void TimerDelegate();
    public class Timer
    {
        private DateTime startTime;
        private int interval;
        private TimerDelegate timerMethod;
        private bool isStarted = false;

        public Timer(TimerDelegate function, int interval)
        {
            this.timerMethod = function;
            this.Interval = interval;
        }

        public TimerDelegate TimerMethod { private get; private set; }
        public int Interval
        {
            get
            {
                return this.interval;
            }
            set
            {
                if (value > 0)
                {
                    this.interval = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The interval should be greater than 0");
                }
            }
        }

        public void Start()
        {
            if(this.timerMethod != null)
            {
                this.isStarted = true;
                this.startTime = DateTime.Now;
                while (this.isStarted == true )
                {
                     DateTime currentTime = DateTime.Now;
                     int diff = (int)Math.Round((currentTime - this.startTime).TotalMilliseconds );
                   
                    if ( diff == interval)
                    {
                        this.startTime = currentTime;
                        timerMethod();
                    }
                }
            }
        }

        public void End()
        {
            this.isStarted = false;
        }
    }
}
