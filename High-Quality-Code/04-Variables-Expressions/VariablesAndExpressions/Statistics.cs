namespace VariablesAndExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Statistics
    {
        public void Print(double[] data)
        {
            double[] indicators = GetMinMaxAndAverage(data);
            Console.WriteLine(
                "Min Value:{0} | Max Value:{1} | Average:{2}",
                indicators[0],
                indicators[1],
                indicators[2]);
        }

        protected double[] GetMinMaxAndAverage(double[] data)
        {
            double min = data[0];
            double max = data[0];
            double sum = 0;
            int dataCount = data.Length;

            for (int i = 0; i < dataCount; i++)
            {
                if (data[i] < min)
                {
                    min = data[i];
                }

                if (data[i] > max)
                {
                    max = data[i];
                }

                sum += data[i];
            }

            double[] result = new double[3] { min, max, sum };
            return result;
        }        
    }
}
