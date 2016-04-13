using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    interface IPizzaFactory
    {
        AbstractPizza MakePizza(string[] ingrediensliste);
    }
}
