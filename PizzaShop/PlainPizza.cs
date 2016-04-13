using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class PlainPizza : AbstractPizza
    {
        public PlainPizza()
        {
            Ingredients = "tomat, ost";
            Price = 40.00;
        }


        public override string ToString()
        {
            return $"Denne pizza er med tomat og ost";
        }
    }
}
