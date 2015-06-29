using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
    class Display
    {
        private string model;
        private double size;
        private int colors;
        const double MIN_SIZE = 2;
        const double MAX_SIZE = 20;
        const int MIN_COLORS = 2;
        const int MAX_COLORS = 256;
        private const byte MIN_MODEL_LENGTH = 3;
        private const short MAX_MODEL_LENGTH = 100;

        public Display(string model)
        {
            this.Model = model;
        }

        public Display(string model, double size)
        {
            this.Model = model;
            this.Size = size;
        }

        public Display(string model, double size, int colors)
        {
            this.Model = model;
            this.Size = size;
            this.Colors = colors;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
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
        public double Size
        {
            get { return this.size; }
            set 
            {
                if (IsValidSize(value, MIN_SIZE, MAX_SIZE))
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("The size should be between {0} and {1}.", MIN_SIZE, MAX_SIZE));
                }
            }
        }

        public int Colors
        {
            get { return this.colors; }
            set
            {
                if (IsValidColorRange(value, MIN_COLORS, MAX_COLORS))
                {
                    this.colors = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("The colors should be between {0} and {1} and divisible by 8.", MIN_SIZE, MAX_SIZE));
                }
            }
        }

        private bool IsValidSize(double size, double min, double max)
        {
            if(size <= max && size >= min )
            {
                return true;
            }
            return false;
        }

        private bool IsValidColorRange(int colors, int min, int max)
        {
            if (colors <= max && colors >= min && colors % 8 == 0)
            {
                return true;
            }
            return false;
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
