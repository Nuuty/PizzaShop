using PizzaShop.Adapter;

namespace PizzaShop.Strategy
{
    interface IPriceStrategy
    {
        void CalculatePrice(IMenu menuprice);
    }
}
