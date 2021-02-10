using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppObservateurJournal
{
    class Abonnement : IObserver
    {
        public bool newspaper { get; set; } = false;
        public void Update(ISubject writer)
        {
            if ((writer as Writer).newspaper == true)
            {
                Console.WriteLine("Un journal est ecrit et doit être livré.");
                newspaper = true;
            }
            else
            {
                Console.WriteLine("Aucun journal n'a était ecrit.");
                newspaper = false;
            }
        }
    }
}
