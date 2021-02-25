using Xunit;

namespace CleanCode.AgilePractices.BadSmells._02DuplicatedCode
{
    public class CustomerTests
    {
        [Fact]
        public void Test1()
        {
            Customer customer = new Customer();
            //Rest of the test
        }

        [Fact]
        public void Test2()
        {
            Customer customer = new Customer();
            //Rest of the test
        }

        [Fact]
        public void Test3()
        {
            Customer customer = new Customer();
            //Rest of the test
        }
    }
}
