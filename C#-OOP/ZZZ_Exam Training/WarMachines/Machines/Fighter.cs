using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Fighter : Machine, IFighter
    {
        private const double HEALTH_PONTS = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            :base(name, attackPoints, defensePoints, HEALTH_PONTS)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; protected set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendLine(String.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));
            return result.ToString().TrimEnd('\n', '\r');
        }
    }
}
