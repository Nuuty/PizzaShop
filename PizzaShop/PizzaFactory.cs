using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class PizzaFactory : IPizzaFactory
    {
        public AbstractPizza MakePizza(string[] ingrediensliste)
        {
          AbstractPizza pizza = new PlainPizza();


            foreach (var s in ingrediensliste)
            {
                pizza = AddIngredients(s, pizza);
            }

            return pizza;
          
        }

        private AbstractPizza AddIngredients(string ingredient, AbstractPizza pizza)
        {
            switch(ingredient.ToLower())
            {
                case "ham":
                    return new PlainPizza();
                    break;
                case "bacon":
                    Console.WriteLine("bacon");
                    return new PlainPizza();
                case "pepperoni":
                    Console.WriteLine("pepperoni");
                    return new PlainPizza();
                default:
                    return pizza;
                    break;
            }       
        }
    }

}
