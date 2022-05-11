using Ales_lvl1_variant2.Car;
using Ales_lvl1_variant2.Car.Variation;
using Ales_lvl1_variant2.Interfaces.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ales_lvl1_variant2.Market
{
    public class Catalog
    {
        private MarketItem[] _items = new MarketItem[] {
            new MarketItem() {
                Car = new SportCar(new MoveFlat(), 3f, 50),
                Price = 2000,
                Name = "Спортивная машина",
                Description = "это быстрая машина"
            },
            new MarketItem() {
                Car = new ClownCar(new MoveStagger(), 1f, 150),
                Price = 1500,
                Name = "Клоунский автомобиль",
                Description = "это машина для настоящего клоуна"
            },
            new MarketItem() {
                Car = new BrokenCar(new MoveInvert(), 1.8f, 300),
                Price = 4000,
                Name = "Сломанный автомобиль",
                Description = "Что бы доломать прийдется постараться"
            }
        };

        public MarketItem GetItemById(int index)
        {
            if (_items.Count() > index) 
            {
                return _items[index];
            }
            return null;
        }

        public bool BuyItem(MarketItem item) 
        {
            return true;
        }

        public bool BuyItem(int item)
        {
            if(GetItemById(item)!= null)
                return true;

            return false;
        }

        public MarketItem[] GetAllItems() => _items;
    }
}
