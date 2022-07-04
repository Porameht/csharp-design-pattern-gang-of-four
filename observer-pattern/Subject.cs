using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace observer_pattern
{
    public class Subject
    {
        private List<Observer> _observer;
        public Subject()
        {
            _observer = new List<Observer>();
        }

        public void AddObserver(Observer obServer)
        {
            _observer.Add(obServer);
        }

        public void RemoveObserver(Observer obServer)
        {
            _observer.Remove(obServer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observer)
            {
                observer.Update();
            }
        }
    }
}