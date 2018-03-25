using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    public class ConcreteObserverB : IObserver
    {
        public string Notify()
        {
            return "ConcreteObserverB";
        }
    }
}
