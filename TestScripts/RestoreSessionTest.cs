using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class RestoreSessionTest : MasterTest
    {
        private LoginPage _loginPage;
        private RestoreSessionPage _restoreSessionPage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _restoreSessionPage = new RestoreSessionPage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
        }

        [SetUp]
        public void Before()
        {
            _restoreSessionPage.GoToAdmin();
        }

        [Test(Description = "Verify if Admin << Restore Session To verify the restore session functionality ")]
        public void Verify_Session_CanBeRestored()
        {
            _restoreSessionPage.EnterFirstname("Mickey");
            _restoreSessionPage.EnterLastName("Mouse");
            _restoreSessionPage.EnterDOB("6/21/1954");
            _restoreSessionPage.EnterPhysicianName("John pepper");
            _restoreSessionPage.ClickSubmit();
            _restoreSessionPage.ClickViewSessions();
            _restoreSessionPage.ClickRestoreSessions();
        }
    }
}
