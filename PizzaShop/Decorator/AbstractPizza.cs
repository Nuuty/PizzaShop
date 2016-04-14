using System;

namespace PizzaShop.Decorator
{
    abstract class AbstractPizza
    {
        public String Ingredients { get; set; }
        public double Price { get; set; }
    }
}
