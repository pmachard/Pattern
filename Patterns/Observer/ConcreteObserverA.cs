using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    public class ConcreteObserverA : IObserver
    {
        public string Notify()
        {
            return "ConcreteObserverA";
        }
    }
}
