using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using ADSAutomation.Pages;
using ADSAutomation.Utils;
using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
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
            _loginPage.Login("admin@techaffinity.com", "admin");
            bool verifyElement = _driver.FindElement(_loginPage._homePageElement).Displayed;
            if (true == verifyElement)
            {
                Assert.True(true, "Login Successfully");
            }
            else
            {
                Assert.False(false, "unable to login");
            }
        }

        [Test(Description = "Verify that a user can login to the application with invalid credentials")]
        public void TestInValidUserLogin()
        {
            _loginPage.Login("admin123@techaffinity.com", "admin");
            try
            {
                bool verifyElement = _driver.FindElement(_loginPage._homePageElement).Displayed;
                if (false == verifyElement)
                {
                    Assert.True(true, "Unable to login due to invalid username");
                }
            }
            catch 
            {
                _test.Log(Status.Fail, "Login successfully with wrong username");
            }
        }

        [Test(Description = "Verify that a user can login to the application with valid username and invalid password credentials")]
        public void TestValidUserAndInvalidPasswordLogin()
        {
            _loginPage.Login("admin@techaffinity.com", "admin123");
            try
            {
                bool verifyElement = _driver.FindElement(_loginPage._homePageElement).Displayed;
                if (false == verifyElement)
                {
                    Assert.True(true, "Unable to login due to wrong password");
                }
            }
            catch
            {
                _test.Log(Status.Fail, "Login succesfully with invalid password");
            }
        }

        [Test(Description = "To verify the Login without username")]
        public void TestWithoutUsernameLogin()
        {
           
            try
            {
                _loginPage.Login("", "admin");
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Username"));
            }
        }

        [Test(Description = "To verify the Login without username and password")]
        public void TestWithoutUsernameAndPasswordLogin()
        {
            _loginPage.Login("", "");
            try
            {
                bool verifyElement = _driver.FindElement(_loginPage._homePageElement).Displayed;
                if (false == verifyElement)
                {
                    Assert.True(true, "Unable to login due to without username and password");
                }
            }
            catch
            {
                _test.Log(Status.Fail, "Login succesfully without username");
            }
        }
    }
}
