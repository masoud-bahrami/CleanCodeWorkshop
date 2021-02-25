namespace MetroApp.ChainOfResponsibility
{
    public interface IHandler<T>
    {
        IHandler<T> SetNext(IHandler<T> handler);
        T Handle(T request);
    }
}