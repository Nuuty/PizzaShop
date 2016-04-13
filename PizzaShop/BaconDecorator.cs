using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class BaconDecorator : AbstractPizzaDecorator
    {


        public BaconDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Ingredients = Pizza.Ingredients + ", bacon";
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return $"Pizza med {Ingredients} koster {Price}";
        }
    }
}
