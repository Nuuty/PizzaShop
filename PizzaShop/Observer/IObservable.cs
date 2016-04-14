namespace PizzaShop.Observer
{
    interface IObservable
    {
        void AddObserver(IObserver observer);
    }
}
