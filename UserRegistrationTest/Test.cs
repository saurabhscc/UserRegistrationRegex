using System;
using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFirstNameValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = UserValidation.ValidateFirstName();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = UserValidation.ValidateLastName();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenEmailValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = UserValidation.ValidateEmailId();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenMobileValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = UserValidation.ValidateMobileNumber();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = UserValidation.ValidatePasswordR4();
            Assert.AreEqual(actual, expected);
        }
        public void GivenFirstNameValid_ShouldReturnSad()
        {
            bool expected = true;
            bool actual = UserValidation.ValidateFirstName();
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = UserValidation.ValidateLastName();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        public void GivenEmailInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = UserValidation.ValidateEmailId();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        public void GivenMobileInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = UserValidation.ValidateMobileNumber();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = UserValidation.ValidatePasswordR4();
            Assert.AreNotEqual(actual, expected);
        }
        [Test]
        [TestCase("abc@yahoo.com", true)]
        [TestCase("abc-100@abc.net", true)]
        [TestCase("abc.100@abc.com.au", true)]
        [TestCase("abc+100@gmail.com", true)]
        [TestCase("abc.@gmail.com", true)]

        public void ParameterizedTest(string emailid, bool expected)
        {
            bool actual = UserValidation.ValidateEmailId();
            Assert.AreEqual(actual, expected);
        }
    }
}