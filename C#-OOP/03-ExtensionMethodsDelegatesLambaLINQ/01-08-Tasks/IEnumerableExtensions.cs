using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_Tasks
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            if (typeof(T).IsNumericType())
            {
                var sum = (dynamic)0;
                foreach (T element in list)
                {
                    sum += element;
                }
                return sum;
            }
            else
            {
                throw new NotSupportedException("The type should be a numeric value in order the calculate the sum");
            }
        }

        public static T Average<T>(this IEnumerable<T> list)
        {
            if (typeof(T).IsNumericType())
            {
                var sum = (dynamic)0;
                foreach (T element in list)
                {
                    sum += element;
                }
                return sum / (dynamic)list.Count();
            }
            else
            {
                throw new NotSupportedException("The type should be a numeric value in order the calculate the sum");
            }
        }

        public static T Product<T>(this IEnumerable<T> list)
        {
            if (typeof(T).IsNumericType())
            {
                var product = (dynamic)1;
                foreach (T element in list)
                {
                    product *= element;
                }
                return product;
            }
            else
            {
                throw new NotSupportedException("The type should be a numeric value in order the calculate the product");
            }
        }

        public static T MinExt<T>(this IEnumerable<T> list)
        {
            return list.Min();
        }
        public static T MaxExt<T>(this IEnumerable<T> list)
        {
            return list.Max();
        }

        
    
    }
}
