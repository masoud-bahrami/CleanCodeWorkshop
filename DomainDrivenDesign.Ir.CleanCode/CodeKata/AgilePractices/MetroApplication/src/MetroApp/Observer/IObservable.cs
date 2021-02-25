namespace MetroApp.Observer
{
    public interface IObservable<T>
    {
        void RegisterObserver(IObserver<T> observer);
        void UnRegisterObserver(IObserver<T> observer);
        void NotifyObservers(T data);
    }
}