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
            /*STEP 1*/
            /*AbstractPizza pp = new PlainPizza();
            pp = new HamDecorator(pp);
            pp = new BaconDecorator(pp);
            pp = new PepperoniDecorator(pp);
            Console.WriteLine(pp);*/
            
            /*STEP 2 */
            PizzaFactory pf = new PizzaFactory();
            Console.WriteLine(pf.MakePizza(new []{"bacon","bacon","bacon"}));



        }
    }
}
