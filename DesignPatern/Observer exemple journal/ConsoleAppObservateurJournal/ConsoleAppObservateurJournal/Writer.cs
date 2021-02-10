using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppObservateurJournal
{
    class Writer : ISubject
    {
        public bool newspaper { get; set; } = false;

        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void Write()
        {
            this.newspaper = true;
            this.Notify();
        }
    }
}
