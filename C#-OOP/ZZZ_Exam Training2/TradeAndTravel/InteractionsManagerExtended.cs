using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class InteractionsManagerExtended:InteractionManager
    {
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;

                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleGatherInteraction(string[] commandWords,Person actor)
        {
            string name = commandWords[2];
            var currentLocation = actor.Location as IGatheringLocation;
            if(currentLocation != null)
            {
                if (actor.ListInventory().FirstOrDefault(item => item.ItemType == currentLocation.RequiredItem) != null)
                {
                    this.AddToPerson(actor, currentLocation.ProduceItem(name));
                }
            }         
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            var itemString = commandWords[2];
            Item item = null;
            List<ItemType> requiredItems;
            switch(itemString)
            {
                case "weapon":
                    item = new Weapon(commandWords[3]);
                    requiredItems = Weapon.
                    break;
                case "armor":
                    item = new Armor(commandWords[3]);
                    break;
                default:
                    break;
            }

            if(actor.ListInventory().Merge(item.))
            {
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "forest":
                    location = new Forest(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }


        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation,item);
                    break;
            }
            return item;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
                    
            }
            return person;
        }
    }
}
