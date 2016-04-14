using System;
using PizzaShop.Adapter;
using PizzaShop.Decorator;
using PizzaShop.Factory;
using PizzaShop.Strategy;

namespace PizzaShop.Observer
{
    class PizzaMan : IObserver
    {
        public PizzaOven PizzaOven { get; set; }
        public PizzaFactory PizzaFactory { get; set; }
        public IPriceStrategy PriceStrategy { get; set; }

        public PizzaMan(PizzaOven pizzaOven)
        {
            PizzaOven = pizzaOven;
            PizzaOven.AddObserver(this);
            PizzaFactory = new PizzaFactory();
        }
        public void Notify(IMenu menu)
        {
            Console.WriteLine($"{menu.Pizza}kr med {menu.Drink} som tilbehør til {menu.MenuPrice}kr. I alt : {menu.Pizza.Price + menu.MenuPrice}kr");
        }

        public void TakeOrder(string[] ingredients)
        {
            var pizza = PizzaFactory.MakePizza(ingredients);
            PizzaOven.PreparePizza(new PizzaToMenuAdapter(pizza));
        }
        public void TakeOrder(string[] ingredients, string drink, double price)
        {
            var pizza = PizzaFactory.MakePizza(ingredients);
            PizzaOven.PreparePizza(new PizzaToMenuAdapter(drink, price, pizza));
        }
        public enum TimeOfDay { Lunch, Evening, Night };




    }
}
