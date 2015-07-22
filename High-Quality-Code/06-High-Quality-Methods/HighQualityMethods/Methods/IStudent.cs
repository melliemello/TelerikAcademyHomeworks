using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityMethods.Methods
{
    internal interface IStudent
    {
        int GetAge();

        bool IsOlderThan(IStudent other);
    }
}
