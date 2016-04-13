using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPizza pizza = new PlainPizza();
            pizza = new HamDecorator(pizza);
            pizza = new BaconDecorator(pizza);
            pizza = new PepperoniDecorator(pizza);
            Console.WriteLine(pizza);



        }
    }
}
