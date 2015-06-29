using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TimerEvents
{
    public class Timer
    {
        private DateTime startTime;
        private int interval;
        private bool isStarted = false;
        public event EventHandler TickEvent;

        public Timer(int interval)
        {
            this.Interval = interval;
        }

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

        protected virtual void OnTickEvent()
        {
            EventHandler handler = TickEvent;
            if(handler != null)
            {
                handler(this, EventArgs.Empty);
            }            
        }

        public void Start()
        {
            this.isStarted = true;
            this.startTime = DateTime.Now;            
            while (this.isStarted == true)
            {
                DateTime currentTime = DateTime.Now;
                int diff = (int)Math.Round((currentTime - this.startTime).TotalMilliseconds);

                if (diff >= interval)
                {
                    this.startTime = currentTime;
                    OnTickEvent();
                    
                }
            }
        }

    }
}
