using PizzaShop.Adapter;

namespace PizzaShop.Strategy
{
    interface IPriceStrategy
    {
        double CalculatePrice(IMenu pizzamenu);
    }
}
