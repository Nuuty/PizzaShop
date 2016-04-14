using PizzaShop.Decorator;

namespace PizzaShop.Model
{
    class PlainPizza : AbstractPizza
    {
        public PlainPizza()
        {
            Ingredients = "tomat, ost";
            Price = 40.00;
        }


        public override string ToString()
        {
            return $"Denne pizza er med tomat og ost";
        }
    }
}
