using PizzaShop.Decorator;

namespace PizzaShop.Factory
{
    interface IPizzaFactory
    {
        AbstractPizza MakePizza(string[] ingrediensliste);
    }
}
