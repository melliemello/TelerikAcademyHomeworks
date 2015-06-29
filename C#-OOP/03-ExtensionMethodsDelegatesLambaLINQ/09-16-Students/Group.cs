using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16_Students
{
    class Group
    {

        public Group(byte id, string department)
        {
            this.GroupID = id;
            this.Department = department;
        }

        public string Department { get; private set; }
        public byte GroupID { get; private set; }
        
    }
}
