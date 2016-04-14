using PizzaShop.Decorator;
using PizzaShop.Model;

namespace PizzaShop.Factory
{
    class PizzaFactory : IPizzaFactory
    {
        public AbstractPizza MakePizza(string[] ingrediensliste)
        {
          AbstractPizza pizza = new PlainPizza();


            foreach (var ingredient in ingrediensliste)
            {
                pizza = AddIngredients(ingredient, pizza);
            }

            return pizza;
          
        }

        private AbstractPizza AddIngredients(string ingredient, AbstractPizza pizza)
        {
            switch(ingredient.ToLower())
            {
                case "ham":
                    return new HamDecorator(pizza);
                case "bacon":
                    return new BaconDecorator(pizza);
                case "pepperoni":
                    return new PepperoniDecorator(pizza);
                default:
                    return new PlainPizza();
            }       
        }
    }

}
