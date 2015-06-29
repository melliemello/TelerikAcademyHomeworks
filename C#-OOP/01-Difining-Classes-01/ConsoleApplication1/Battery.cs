using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;
        private const byte MIN_MODEL_LENGTH = 3;
        private const short MAX_MODEL_LENGTH = 100;
        private const short MIN_HOURS = 1;
        private const short MAX_HOURS = 500;


        public Battery()
        {
        }

        public Battery(string model)
        {
            this.Model = model;            
        }

        public Battery(string model, BatteryType type)
        {
            this.Model = model;
            this.Type = type;
        }

        public Battery(string model, BatteryType type, double hoursTalk, double hoursIdle)
        {
            this.Model = model;
            this.Type = type;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            { 
                if(IsValidHours(value, MIN_HOURS, MAX_HOURS))
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("The battery duration should be between {0} and {1}.", MIN_HOURS, MAX_HOURS));
                }
            }
        }


        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (IsValidHours(value, MIN_HOURS, MAX_HOURS))
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("The battery duration should be between {0} and {1}.", MIN_HOURS, MAX_HOURS));
                }
            }
        }

        public string Model
        {
            get { return this.model; }
            set {
                if (IsValidModel(value, MIN_MODEL_LENGTH, MAX_MODEL_LENGTH))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("The lenght of the string should be between {0} and {1}.", MIN_MODEL_LENGTH, MAX_MODEL_LENGTH));
                }
            }
        }

        private bool IsValidModel(string model, byte minLen, short maxLen)
        {
            if (model.Length >= minLen && model.Length <= maxLen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsValidHours(double hours, short minLen, short maxLen)
        {
            if (hours >= minLen && hours <= maxLen)
            {
                return true;
            }
            else
            {
                return false;
            }
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
                catch (NullReferenceException)
                {
                    result.Append(String.Format("{0} = {1}", prop.Name, "N/A"));
                }
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

    }
}
