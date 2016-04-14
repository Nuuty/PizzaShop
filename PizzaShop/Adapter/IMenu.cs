using System;
using PizzaShop.Decorator;

namespace PizzaShop.Adapter
{
    interface IMenu
    {
        String Drink { get; set; }
        double MenuPrice { get; set; }
        AbstractPizza Pizza { get; set; }
    }
}
