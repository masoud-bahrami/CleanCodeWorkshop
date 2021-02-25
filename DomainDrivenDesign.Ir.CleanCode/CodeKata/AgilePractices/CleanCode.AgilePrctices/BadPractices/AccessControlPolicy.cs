using Xunit;

namespace CleanCode.AgilePractices.BadPractices
{
    public class AccessControlPolicyTests
    {
        [Fact]
        public void Test()
        {
            var sut = new AccessControlPolicy();
            sut.CanEdit();
            sut.CanDelete();
            Assert.True(sut.HasAccessForEditCanSomething);
            Assert.False(sut.HasAccessForDeleteCanSomething);
        }
    }
    public class AccessControlPolicy
    {
        public bool HasAccessForEditCanSomething;
        public bool HasAccessForDeleteCanSomething;

        public void CanEdit()
        {
            HasAccessForEditCanSomething = true;
        }

        public void CanDelete()
        {
            HasAccessForDeleteCanSomething = true;
        }
    }
}