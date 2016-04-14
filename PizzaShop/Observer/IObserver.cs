using PizzaShop.Adapter;
using PizzaShop.Decorator;

namespace PizzaShop.Observer
{
    interface IObserver
    {
        void Notify(IMenu Menu);
    }
}
