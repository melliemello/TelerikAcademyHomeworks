using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Mine:Location, IGatheringLocation
    {
        private const ItemType gatheringType = ItemType.Iron;
        private const ItemType requiredItem = ItemType.Armor;

        public Mine(string name)
            : base(name, LocationType.Mine )
        {
        }

        public ItemType GatheredType
        {
            get { return gatheringType; }
        }

        public ItemType RequiredItem
        {
            get { return requiredItem; }
        }

        public Item ProduceItem(string name)
        {
            return new Iron(name);
        }
    }
}
