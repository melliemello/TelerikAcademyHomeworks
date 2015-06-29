using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank:Machine,ITank
    {
        private bool defenseMode = true;
        private const double HEALTH_POINTS = 100;
        private const double DEFENCE_BONUS = 30;
        private const double ATTACK_PENALTY = 40;

        public Tank(string name, double attackPoints, double defensePoints)
            :base(name, attackPoints, defensePoints,HEALTH_POINTS )
        {
        }

        public override double AttackPoints
        {
            get
            {
                if (this.defenseMode)
                {
                    return this.attackPoints - ATTACK_PENALTY;
                }
                else
                {
                    return this.attackPoints;
                }                
            }

        }

        public override double DefensePoints
        {
            get
            {
                if (this.defenseMode)
                {
                    return this.defensePoints + DEFENCE_BONUS;
                }
                else
                {
                    return this.defensePoints;
                }
            }
        }

        public bool DefenseMode {
            get { return this.defenseMode; }
            set
            {
                if (value != null)
                {
                    this.defenseMode = value;
                }
                else
                {
                    throw new ArgumentNullException("Defence mode cannot be set to null");
                }
            }
        }

        public void ToggleDefenseMode()
        {
            this.defenseMode = !this.defenseMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendLine(String.Format(" *Defense: {0}", this.defenseMode  ? "ON" : "OFF"));
            return result.ToString().TrimEnd('\n', '\r');
        }
    }
}
