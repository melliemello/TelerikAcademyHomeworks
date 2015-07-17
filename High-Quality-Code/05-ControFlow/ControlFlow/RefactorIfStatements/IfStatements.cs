using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Chef
{
    internal class IfStatements
    {
        public void CookPotato()
        {
            Potato potato = new Potato();

            if (potato != null &&
                potato.IsPealed && 
                !potato.IsCut)
            {
                Console.WriteLine("Cook Potato");
            }                    
        }

        public void Move(int x, int y)
        {
            const int MaxY = int.MaxValue;
            const int MinY = int.MinValue;
            const int MaxX = int.MaxValue;
            const int MinX = int.MinValue;
            bool isVisitable = true;
            bool xIsInRange = IsInRange(x, MinX, MaxX);
            bool yIsInRange = IsInRange(y, MinY, MaxY);

            if (xIsInRange && yIsInRange && isVisitable)
            {
               Console.WriteLine("Visit Cell");
            }
        }

        public bool IsInRange(int number, int min, int max)
        {
            bool isInRange = min <= number && number >= max;
            return isInRange;         
        }                
    }
}
