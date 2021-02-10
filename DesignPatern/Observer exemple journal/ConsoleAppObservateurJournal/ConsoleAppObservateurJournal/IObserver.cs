using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppObservateurJournal
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
