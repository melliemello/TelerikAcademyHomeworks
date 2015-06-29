using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
    class GSM
    {
        private Battery battery;
        private Display display;
        private string model;
        private string manufacturer;
        private const byte MIN_INPUT_LENGTH = 3;
        private const short MAX_INPUT_LENGTH = 100;
        private List<Call> callHistory = new List<Call>();
        public static GSM IPhone4s = new GSM(
                                                "IPhone 4s",
                                                "Apple",
                                                new Display("SomeDisplayMode", 14.7), 
                                                new Battery("Some Battery Model", BatteryType.Li_ion) 
                                            );

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, Display display, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Display = display;
            this.Battery = battery;
        }

        public Battery Battery
        {
            get { return this.battery; }
            set 
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get { return this.display; }
            set
            {
                this.display = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (IsValidString(value, MIN_INPUT_LENGTH, MAX_INPUT_LENGTH))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("The lenght of the model should be between {0} and {1}.", MIN_INPUT_LENGTH, MAX_INPUT_LENGTH));
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (IsValidString(value, MIN_INPUT_LENGTH, MAX_INPUT_LENGTH))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("The lenght of the model should be between {0} and {1}.", MIN_INPUT_LENGTH, MAX_INPUT_LENGTH));
                }
            }
        }

        public List<Call> CallHistory 
        {
            get { return this.callHistory; }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public double CallPrice( double price)
        {
            double totalDuration = this.CallHistory.Select(x => x.Duration).Sum();
            return (totalDuration / 60) * price;
            
        }


        private bool IsValidString(string input, byte minLen, short maxLen)
        {
            if (input.Length >= minLen && input.Length <= maxLen)
            {
                return true;
            }
            return false;            
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                try
                {
                    result.Append(String.Format("{0} = {1}", prop.Name, prop.GetValue(this, null).ToString()));
                }
                catch(NullReferenceException)
                {
                    result.Append(String.Format("{0} = {1}", prop.Name, "N/A"));
                }
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }
    }
    
}
