using System;

namespace CleanCode.AgilePractices.SOLID.LSP
{
   
    public class SuperClass
    {
        public DateTime Today => DateTime.Now;
        public void DoSomething()
        {
            if (Today.IsNotYesterday())
                throw new TimeOfDoingThisWorkIsExpiredException();
        }
    }

    public class SubClass : SuperClass
    {
        public new void DoSomething()
        {
            throw new IllegalBehaviourException();
        }
    }


    public class IllegalBehaviourException : Exception
    {
    }

    public class TimeOfDoingThisWorkIsExpiredException : Exception
    {
    }



    public static class DateTimeExtensions
    {
        public static bool IsNotYesterday(this DateTime date)
        {
            return false;
        }
    }



}