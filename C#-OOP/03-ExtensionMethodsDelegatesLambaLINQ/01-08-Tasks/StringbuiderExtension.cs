using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_08_Tasks
{
    public static class StringbuiderExtension
    {
        public static StringBuilder Substring( this StringBuilder str , int start, int length)
        {
            return new StringBuilder(str.ToString().Substring(start, length));
        }
    }
}
