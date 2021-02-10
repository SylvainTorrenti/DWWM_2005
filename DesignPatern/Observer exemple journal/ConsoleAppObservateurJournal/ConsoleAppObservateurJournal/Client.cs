using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppObservateurJournal
{
    class Client : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Le client est abonner au journal.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Le client se désabonne du journal.");
        }

        public void Deliver(IObserver observer)
        {
            if ((observer as Abonnement).newspaper && _observers.Contains(observer))
            {
                Console.WriteLine("Le journal est livré.");
            }
            else
            {
                Console.WriteLine("Aucun journal n'a était livré.");
            }
        }
        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
