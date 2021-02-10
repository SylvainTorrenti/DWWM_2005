using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObserver
{
    class ConcreteObserverA : IObserver
    {

        public void Update(ISubject subject)
        {
            if ((subject as Subject).State <= 3)
            {
                Console.WriteLine("L'observer a réagi.");
            }
            else
            {
                Console.WriteLine("L'observer ne réagit pas.");
            }
        }
    }
    }

