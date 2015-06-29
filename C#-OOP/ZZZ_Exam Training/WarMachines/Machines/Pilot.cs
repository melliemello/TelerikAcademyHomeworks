using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Pilot: IPilot
    {
        private List<IMachine> machines;
        private string name;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name

        {
            get { return this.name; }
            protected set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Pilot's name can not be set to null");
                }
            }
        }

        public void AddMachine(IMachine machine)
        {            
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("{0} - {1} {2}", this.name, this.machines.Count > 0 ? this.machines.Count.ToString() : "no", this.machines.Count == 1 ? "machine" : "machines"));
            if(this.machines.Count > 0)
            {
                result.Append(Environment.NewLine);
                foreach (IMachine machine in this.machines.OrderBy(m=> m.HealthPoints).ThenBy(m=>m.Name))
                {
                    result.AppendLine(machine.ToString());
                }
            }

            return result.ToString().TrimEnd('\n','\r');
        }
    }
}
