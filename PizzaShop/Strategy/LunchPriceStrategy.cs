using PizzaShop.Adapter;

namespace PizzaShop.Strategy
{
    class LunchPriceStrategy : IPriceStrategy
    {
        public double CalculatePrice(IMenu pizzamenu)
        {
            return pizzamenu.MenuPrice*0.9;
        }
    }
}
