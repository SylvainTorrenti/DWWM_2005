using System;

namespace ConsoleAppObservateurJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new Writer();
            var client1 = new Client();
            var client2 = new Client();
            var client3 = new Client();
            var observerA = new Abonnement();
            writer.Attach(observerA);
            client1.Attach(observerA);
            Console.WriteLine("************");
            client3.Attach(observerA);
            Console.WriteLine("************");
            writer.Write();
            Console.WriteLine("************");
            client1.Deliver(observerA);
            Console.WriteLine("************");
            client2.Deliver(observerA);
            Console.WriteLine("************");
            client3.Deliver(observerA);
            Console.WriteLine("************");
            client1.Detach(observerA);
        }
    }
}
