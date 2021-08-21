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
            string expected = "true";
            string actual = UserValidation.ValidateFirstName("Virat");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = UserValidation.ValidateLastName("Kohli");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenEmailValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = UserValidation.ValidateEmailId("abc.xyz@bl.co.in");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenMobileValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = UserValidation.ValidateMobileNumber("91 9919819801");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = UserValidation.ValidatePassword("Sai@ram77");
            Assert.AreEqual(actual, expected);
        }
        public void GivenFirstNameValid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = UserValidation.ValidateFirstName("Chiku");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenLastNameInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = UserValidation.ValidateLastName("Koli");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenEmailInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = UserValidation.ValidateEmailId("abc@%*.com");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenMobileInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = UserValidation.ValidateMobileNumber("911");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenPasswordInvalid_ShouldReturnSad()
        {

            string expected = "false";
            string actual = UserValidation.ValidatePassword("Sairam");
            Assert.AreEqual(actual, expected);
        }
        
    }
}