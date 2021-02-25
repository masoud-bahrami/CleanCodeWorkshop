using System.Collections.Generic;
using MetroApp.Iterator;
using MetroApp.Observer;

namespace MetroApp.Compositions
{
    public class ChargeMetroCardCollection<T> : IIterator<IObserver<T>>
    {
        private readonly IList<IObserver<T>> _observers = new List<IObserver<T>>();

        public void Register(IObserver<T> observer)
        {
            if (_observers.Contains(observer))
                return;

            _observers.Add(observer);
        }

        public void UnRegister(IObserver<T> observer)
        {
            if (_observers.Contains(observer))
                return;

            _observers.Remove(observer);
        }

        public bool HasNext() => HasAnyObserver();

        private bool HasAnyObserver() => _currentIndex < _observers.Count - 1;

        private int _currentIndex;

        public IObserver<T> Next()
        {
            return _observers[_currentIndex++];
        }
    }
}