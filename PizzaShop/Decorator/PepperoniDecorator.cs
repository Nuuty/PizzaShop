namespace PizzaShop.Decorator
{
    class PepperoniDecorator : AbstractPizzaDecorator
    {
        public PepperoniDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Ingredients = Pizza.Ingredients + ", pepperoni";
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return $"Pizza med {Ingredients} koster {Price}";
        }
    }
}
