using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {

        public InvalidRangeException(T start, T end):base(String.Format("Out of Range [{0}..{1}]", start, end))
        {
            this.Start = start;
            this.End = end;
        }

        public T Start{get; private set;}
        public T End { get; private set; }
    }
}
