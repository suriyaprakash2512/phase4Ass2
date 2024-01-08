using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System;

namespace UnitTestAssesment2
{
    [TestFixture]
    public class UserAuthenticatorTests
    {
        private UserAuthenticator userAuthenticator;

        [SetUp]
        public void Setup()
        {
            userAuthenticator = new UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            
            string username = "Suryacse@gmail.com";
            string password = "Surya123";

            
            bool result = userAuthenticator.RegisterUser(username, password);


            Assert.IsTrue(result);
        }

        [Test]
        public void TestUserLogin()
        {
            // Arrange
            string username = "Vijay123@gmail.com";
            string password = "12345";
            userAuthenticator.RegisterUser(username, password);

            // Act
            bool result = userAuthenticator.LoginUser(username, password);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
