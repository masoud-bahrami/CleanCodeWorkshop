namespace MetroApp.Iterator
{
    public interface IIterator<out T>
    {
        bool HasNext();
        T Next();
    }
}