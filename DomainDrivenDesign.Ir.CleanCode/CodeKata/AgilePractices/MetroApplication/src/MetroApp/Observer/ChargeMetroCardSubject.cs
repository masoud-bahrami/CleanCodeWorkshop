using System;
using MetroApp.Compositions;

namespace MetroApp.Observer
{
    public class ChargeMetroCardSubject : IObservable<ChargeMetroCardViewModel>
    {
        private readonly ChargeMetroCardCollection<ChargeMetroCardViewModel> _observers = new ChargeMetroCardCollection<ChargeMetroCardViewModel>();

        public void RegisterObserver(IObserver<ChargeMetroCardViewModel> observer)
        {
            _observers.Register(observer);
        }

        public void UnRegisterObserver(IObserver<ChargeMetroCardViewModel> observer)
        {
            _observers.UnRegister(observer);
        }

        public void NotifyObservers(ChargeMetroCardViewModel data)
        {
            while (_observers.HasNext())
            {
                var observer = _observers.Next();

                observer.Update(data);
            }
        }
    }
}