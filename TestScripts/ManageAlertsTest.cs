using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class ManageAlertsTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageAlertsPage _manageAlertsPage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _manageAlertsPage = new ManageAlertsPage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
        }

        [SetUp]
        public void Before()
        {
            _manageAlertsPage.GoToAdmin();
        }

        [Test(Description = "Check whether the user is able to navigate to Manage Alert page")]
        public void Verify_ManageAlertsLink_ReturnsManageAlertsPage()
        {
            Assert.AreEqual("Manage Alerts", _manageAlertsPage.GetHeader());
        }

        [Test(Description = "To verify user is able to create the Alert message")]
        public void Verify_AlertsCanBeCreated_WithAllFieldsProvided()
        {
            _manageAlertsPage.EnterAlertMsg("Message");
            _manageAlertsPage.ChooseSystemStatus();
            _manageAlertsPage.ChooseScheduledUpdate();
            _manageAlertsPage.ClickSubmit();
            _manageAlertsPage.ClickOkAlert();
            _manageAlertsPage.ClickLogout();
            _manageAlertsPage.LogBackIn();
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Message", _manageAlertsPage.AlertMessage());
        }

        [Test(Description = "To Verify Save functionality without data in Manage Alert page")]
        [Ignore("No functionality for this yet")]
        public void Verify_AlertsCannotBeCreated_WithoutDataProvided()
        {
            _manageAlertsPage.ClickSubmit();
        }

        [Test(Description = "To Verify Clear functionality in Manage Alert page")]
        public void Verify_ClearButton_ClearsAllTheFields()
        {
            _manageAlertsPage.EnterAlertMsg("Message");
            _manageAlertsPage.ChooseSystemStatus();
            _manageAlertsPage.ChooseScheduledUpdate();
            _manageAlertsPage.ClickClear();
            Assert.IsTrue(_manageAlertsPage.GetTextAreaValue().Equals(""));
        }
    }
}
