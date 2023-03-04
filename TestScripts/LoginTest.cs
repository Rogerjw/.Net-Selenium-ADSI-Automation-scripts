using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using ADSAutomation.Pages;
using ADSAutomation.Utils;
using NUnit.Framework;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    public class LoginTest : MasterTest
    {
        private LoginPage _loginPage;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(_driver);
        }

        [Test(Description = "Verify that a user can login to the application with valid credentials")]
        public void TestValidUserLogin()
        {
            _loginPage.Login("admin@techaffinity.com","admin");
            Assert.AreEqual("Oximetry", _driver.Title);            
        }

        [Test(Description = "Verify that a user can login to the application with invalid credentials")]
        public void TestInValidUserLogin()
        {
            _loginPage.Login("zxc@techaffinity.com", "admin");
            Assert.AreEqual("Oximeter", _driver.Title);
        }
    }
}
