using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
    class Call
    {
        private string number;
        private DateTime dateTime;
        private double duration;
        private const byte MIN_NUMBER_LENGTH = 6;
        private const byte MAX_NUMBER_LENGTH = 10;

        public Call(string number, DateTime datetime, double duration)
        {
            this.Number = number;
            this.DateTime = datetime;
            this.Duration = duration;
        }

        public string Number
        {
            get { return this.number; }
            set 
            {
                if (IsValidNumber(value, MIN_NUMBER_LENGTH, MAX_NUMBER_LENGTH))
                {
                    this.number = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("The number should be between {0} and {1} numbers, without any blank spaces between them", MIN_NUMBER_LENGTH, MAX_NUMBER_LENGTH));
                }
            }
        }

        public DateTime DateTime
        {
            get { return this.dateTime; }
            set 
            {
                this.dateTime = value;
            }
        }

        public double Duration {get; set;}
        
    

        private bool IsValidNumber(string number, byte min, byte max)
        {
            if(number.Length < min || number.Length > max )
            {
                return false;
            }
            for (int i = 0; i < number.Length; i++ )
            {
                if(!Char.IsDigit(number[i]))
                {
                    return false;
                }
            }
            return true;
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
