using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        string NotifyObservers();
    }
}
