using System;
using Xunit;

namespace CleanCode.AgilePractices.SOLID.DIP
{
    public class CopierTests
    {
        [Fact]
        public void Test()
        {
            new Copier().Copy();
        }
    }

    public class Copier
    {
        public void Copy()
        {
            var keyboardReader = new KeyboardReader();

            int c;
            while ((c = keyboardReader.Read()) != -1)
            {
                //write to the output
                Console.WriteLine(c);
            }
        }
    }

    public class KeyboardReader
    {
        public int Read()
        {
            //TODO read characters via Keyboard
            return 1;
        }
    }
}
