using PizzaShop.Decorator;

namespace PizzaShop.Adapter
{
    class PizzaToMenuAdapter : IMenu
    {
        public string Drink { get; set; }
        public double MenuPrice { get; set; }
        public AbstractPizza Pizza { get; set; }

        public PizzaToMenuAdapter(string drink, double menuPrice, AbstractPizza pizza)
        {
            Drink = drink;
            MenuPrice = pizza.Price + menuPrice;
            Pizza = pizza;
        }

        public PizzaToMenuAdapter(AbstractPizza pizza)
        {
            Pizza = pizza;
            MenuPrice = pizza.Price;
        }
    }
}
