using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    abstract class AbstractPizza
    {
        public String Ingredients { get; set; }
        public double Price { get; set; }
    }
}
