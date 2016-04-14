namespace PizzaShop.Decorator
{
    class HamDecorator : AbstractPizzaDecorator
    {

        public HamDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Ingredients = Pizza.Ingredients + ", ham";
            Price = Pizza.Price + 5;
        }

        public override string ToString()
        {
            return $"Pizza med {Ingredients} koster {Price}";
        }
    }
}
