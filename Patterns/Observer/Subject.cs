using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> _Observers;

        public Subject()
        {
            _Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_Observers.Contains(observer))
            {
                _Observers.Add(observer);
            }
        }

        public void UnRegisterObserver(IObserver observer)
        {
            if (_Observers.Contains(observer))
            {
                _Observers.Remove(observer);
            }
        }

        public string NotifyObservers()
        {
            string result = "Subject";
            foreach(var item in _Observers)
            {
                result += ";" + item.Notify();
            }
            return result;
        }
    }
}
