using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryObserver
{
    class Subject : ISubject
    {
        public int State { get; set; } = 0;

        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Le sujet est abonner à l'Observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Le sujet se désabonne.");
        }

        public void Notify()
        {
            Console.WriteLine("L'observer est notifier du changement est vois si il doit réagir.");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void StateChangement()
        {
            this.State = new Random().Next(1, 10);
            Console.WriteLine("L'etat du sujet à changer en " + this.State);
            this.Notify();
        }
    }
}
