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

        //Test Method to validate first name
        [Test]
        public void GivenProperFirstName_ShouldReturnTrue()
        {
            bool result = userRegistration.firstNameValidater("Pooja");
            Assert.True(result);
        }

        //Test Method to Invalidate first name
        [Test]
        public void GivenInvalidFirstName_ShouldReturnFalse()
        {
            bool result = userRegistration.firstNameValidater("po");
            Assert.False(result);
        }
    }
}