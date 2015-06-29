using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Extended.Specialties
{
    public class AddAttackWhenSkip:Specialty
    {
        private readonly int attackPointsBonus;

        public AddAttackWhenSkip(int attackPointsBonus)
        {
            if(attackPointsBonus < 1 || attackPointsBonus > 10)
            {
                throw new ArgumentOutOfRangeException("AttackBonus", "AttackBonus should be between 1 and 10, inclusive");
            }

            this.attackPointsBonus = attackPointsBonus;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack  += this.attackPointsBonus;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", base.ToString(), this.attackPointsBonus );
        }
    }
}
