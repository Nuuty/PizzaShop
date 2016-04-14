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
        public IPriceStrategy EveningPriceStrategy = new EveningPriceStrategy();
        public IPriceStrategy LunchPriceStrategy = new LunchPriceStrategy();
        public IPriceStrategy NightPriceStrategy = new NightPriceStrategy();
        public TimeOfDay DayTime { get; set; }

        public PizzaMan(PizzaOven pizzaOven)
        {
            PizzaOven = pizzaOven;
            PizzaOven.AddObserver(this);
            PizzaFactory = new PizzaFactory();
            DayTime = TimeOfDay.Night;
        }
        public void Notify(IMenu menu)
        {
            Console.WriteLine($"{menu.Pizza}kr");
            if (menu.Drink != null)
            {
                Console.WriteLine($"Served with {menu.Drink}");
            }
            double price = 0;
            switch (DayTime)
            {
                case TimeOfDay.Evening: price = EveningPriceStrategy.CalculatePrice(menu); break;
                case TimeOfDay.Lunch: price = LunchPriceStrategy.CalculatePrice(menu); break;
                case TimeOfDay.Night: price = NightPriceStrategy.CalculatePrice(menu); break;
            }
            Console.WriteLine($"With a total cost of {price}");
            
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
