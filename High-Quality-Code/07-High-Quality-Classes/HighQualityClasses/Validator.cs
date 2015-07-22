using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses
{
    public class Validator
    {
        public static void ValidateNumberGreaterThanZero(double number, string message)
        {
            if (number <= 0)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateNonEmptyString(string value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }

            if (value.Length < 1)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
