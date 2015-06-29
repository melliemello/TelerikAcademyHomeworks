using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Forest:Location, IGatheringLocation
    {
        private const ItemType gatheringType = ItemType.Wood;
        private const ItemType requiredItem = ItemType.Weapon;

        public Forest(string name)
            :base(name, LocationType.Forest)
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
            return new Wood(name);
        }
    }
}
