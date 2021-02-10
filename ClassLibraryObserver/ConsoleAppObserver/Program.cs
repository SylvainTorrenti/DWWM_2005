using ClassLibraryObserver;
using System;

namespace ConsoleAppObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);
            Console.WriteLine();
            subject.StateChangement();
            Console.WriteLine();
            subject.StateChangement();
            Console.WriteLine();
            subject.StateChangement();
            Console.WriteLine();
            subject.Detach(observerA);

        }
    }
}
