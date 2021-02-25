using System;

namespace CleanCode.AgilePractices.SOLID.SRP
{
    public interface IModem
    {
        void DialUp(string number);
        void HangUp();
        void Send(object obj);
        void Receive(Func<object> callBack);
    }
}