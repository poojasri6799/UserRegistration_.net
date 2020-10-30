using NUnit.Framework;
using UserRegistration;

namespace UserResistrationTest
{
    public class Tests
    {
        UserRegistrationMain userRegistration = new UserRegistrationMain();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void firstName()
        {
            bool result = userRegistration.firstNameValidater("Pooja");
            Assert.True(result);
        }
    }
}