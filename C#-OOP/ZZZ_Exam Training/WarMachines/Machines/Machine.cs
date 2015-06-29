using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public abstract class Machine : IMachine
    {
        private IPilot pilot;
        protected double defensePoints;
        protected double attackPoints;
        private List<string> targets;

        public Machine(string name, double attackPoints, double defencePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name { get; set; }
        
        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if(value != null)
                {
                    this.pilot = value;
                }
                else
                {
                    throw new ArgumentNullException("The Pilot object should not be null");
                }
            }
        }

        public double HealthPoints { get; set; }

        public virtual double AttackPoints 
        {
            get { return this.attackPoints; }
            set
            {
                this.attackPoints = value;
            }
        }

        public virtual double DefensePoints
        {
            get { return this.defensePoints; }
            set
            {
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get {return this.targets; }
        }

        public void Attack(string target)
        {
            if(!string.IsNullOrEmpty(target) )
            {
                this.targets.Add(target);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("- {0}", this.Name));
            result.AppendLine(String.Format(" *Type: {0}", this.GetType().Name ));
            result.AppendLine(String.Format(" *Health: {0}", this.HealthPoints ));
            result.AppendLine(String.Format(" *Attack: {0}", this.AttackPoints  ));
            result.AppendLine(String.Format(" *Defense: {0}", this.DefensePoints ));
            result.AppendLine(String.Format(" *Targets: {0}", this.targets.Count > 0 ? PrintTargets(this.targets): "None" ));
            return result.ToString();
 
        }

        private string PrintTargets(List<string> targets)
        {
            StringBuilder result = new StringBuilder();
            foreach(string target in targets)
            {
                result.Append(String.Format("{0}, ",target));
            }
            return result.ToString().TrimEnd(',',' ');
        }
    }
}
