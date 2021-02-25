namespace MetroApp.Observer
{
    public interface IObserver<in T>
    {
        void Update(T data);
    }
}