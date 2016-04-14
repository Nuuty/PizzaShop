using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaShop.Adapter;
using PizzaShop.Decorator;

namespace PizzaShop.Observer
{
    class PizzaOven : IObservable
    {
        
        private List<IObserver> _observers;
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public PizzaOven()
        {
            _observers = new List<IObserver>();
        }
        public void PreparePizza(IMenu pizza)
        {
            Random random = new Random();
            Task.Factory.StartNew(() =>
            {
                int preparetime = random.Next(5, 15);
                System.Threading.Thread.Sleep(preparetime * 1000);
                NotifyObservers(pizza);
            });
        }
        private void NotifyObservers(IMenu menu)
        {
            foreach (var observer in _observers)
            {
                observer.Notify(menu);
            }
        }
    }
}
