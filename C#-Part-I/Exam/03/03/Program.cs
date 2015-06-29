using System;
using System.Numerics;


class ConsoleApplication2
    {
        static void Main()
        {
            string currentNumber;
            int len;
            int position = 0;
            BigInteger finalProduct = new BigInteger(1);
            BigInteger mediumProduct = new BigInteger(0);
            BigInteger currentProduct = new BigInteger(1);
            while((currentNumber = Console.ReadLine()) != "END")
            {
                if(position % 2 == 0 )
                {
                    if (Int64.Parse(currentNumber) == 0)
                    {
                        currentProduct = 1;
                    }
                    else
                    {
                        currentProduct = 1;
                        len = currentNumber.Length;
                        for (int i = 0; i < len; i++)
                        {
                            if (Int64.Parse(currentNumber[i].ToString()) == 0)
                            {
                                continue;
                            }
                            currentProduct *= ulong.Parse(currentNumber[i].ToString());
                        }
                    }
                    finalProduct *= currentProduct;
                }

                if ( position == 9) 
                {
                    mediumProduct = finalProduct;
                    finalProduct = 1;
                }
                position++;
            }

            if (position > 9)
            {
                Console.WriteLine("{0}", mediumProduct);
                Console.WriteLine("{0}", finalProduct);
            }
            else
            {
                Console.WriteLine("{0}", finalProduct);
            }

        }
    }
