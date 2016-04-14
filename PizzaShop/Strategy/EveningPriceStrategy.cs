using PizzaShop.Adapter;

namespace PizzaShop.Strategy
{
    class EveningPriceStrategy : IPriceStrategy
    {
        public double CalculatePrice(IMenu pizzamenu)
        {
            return pizzamenu.MenuPrice*1.1;
        }
    }
}
