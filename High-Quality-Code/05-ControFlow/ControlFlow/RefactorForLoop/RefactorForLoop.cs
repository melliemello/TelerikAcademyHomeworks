using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.RefactorForLoop
{
    class RefactorForLoop
    {
        public void Find(int[] array, int expectedValue)
        {
            bool valueIsFound = false;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                bool isDivisibleByTen = i % 10 == 0;
                bool isExpectedValue = array[i] == expectedValue;

                if (isDivisibleByTen && isExpectedValue)
                {
                    valueIsFound = true;
                    break;
                }
            }

            // More code here
            if (valueIsFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
