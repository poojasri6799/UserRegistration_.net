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

        //Test Method to validate last name
        [Test]
        public void GivenProperLastName_ShouldReturnTrue()
        {
            bool result = userRegistration.lastNameValidater("Sri");
            Assert.True(result);
        }

        //Test Method to Invalidate last name
        [Test]
        public void GivenInvalidLastName_ShouldReturnFalse()
        {
            bool result = userRegistration.firstNameValidater("sr");
            Assert.False(result);
        }

        //Test Method to validate mailid
        [Test]
        public void GivenProperMailId_ShouldReturnTrue()
        {
            bool result = userRegistration.mailIdValidater("pooja@gmail.com");
            Assert.True(result);
        }

        //Test Method to Invalidate mailid
        [Test]
        public void GivenInvalidMailId_ShouldReturnFalse()
        {
            bool result = userRegistration.mailIdValidater("@pooja.123");
            Assert.False(result);
        }

        //Test Method to validate mobile number
        [Test]
        public void GivenProperPhonenumber_ShouldReturnTrue()
        {
            bool result = userRegistration.PhoneNumberValidater("91 9963316462");
            Assert.True(result);
        }

        //Test Method to Invalidate mobile number
        [Test]
        public void GivenInvalidPhoneNumber_ShouldReturnFalse()
        {
            bool result = userRegistration.PhoneNumberValidater("9132 3464");
            Assert.False(result);
        }

        //Test Method to validate password
        [Test]
        public void GivenMin8Character_ShouldReturnTrue()
        {
            bool result = userRegistration.minimumEightValidater("Pooja@123");
            Assert.True(result);
        }

        //Test Method to Invalidate password
        [Test]
        public void GivenLessthan8Character_ShouldReturnFalse()
        {
            bool result = userRegistration.PhoneNumberValidater("pooja");
            Assert.False(result);
        }

        //Test Method to validate password
        [Test]
        public void GivenOneUpperCase_ShouldReturnTrue()
        {
            bool result = userRegistration.minimumUpperCase("Pooja@123");
            Assert.True(result);
        }

        //Test Method to Invalidate password
        [Test]
        public void GivenInvalidUpperCase_ShouldReturnFalse()
        {
            bool result = userRegistration.PhoneNumberValidater("pooja13344");
            Assert.False(result);
        }

        //Test Method to validate password
        [Test]
        public void GivenNumeric_ShouldReturnTrue()
        {
            bool result = userRegistration.numericValidater("Pooja@123");
            Assert.True(result);
        }

        //Test Method to Invalidate password
        [Test]
        public void GivenIncorrectInput_ShouldReturnFalse()
        {
            bool result = userRegistration.numericValidater("pooja");
            Assert.False(result);
        }


        //Test Method to validate password
        [Test]
        public void GivenSpecialcharacter_ShouldReturnTrue()
        {
            bool result = userRegistration.specialCharValidater("Pooja@123");
            Assert.True(result);
        }

        //Test Method to Invalidate password
        [Test]
        public void GivenIncorrectPassword_ShouldReturnFalse()
        {
            bool result = userRegistration.specialCharValidater("pooja");
            Assert.False(result);
        }
    }
}