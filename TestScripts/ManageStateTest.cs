using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class ManageStateTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageState _manageState;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(_driver);
            _manageState = new ManageState(_driver);
        }

        [Test(Description = "Verify if Admin >> Manage State link is clickable and navigates to Manage State page")]
        public void HoverManageStatePage()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "Verify if State is created without any data's provided")]
        public void Verify_StateCanBeCreated_WithoutData()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.ClickSubmit();
            Assert.AreEqual(true, _manageState.AlertText().Contains("Enter State"));
        }
        [Test(Description = "Verify Manage State Functionality by providing only Mandatory Fields")]
        public void Verify_ManageState_ByOnly_StateName()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.ManageStateRecordByStateName("Ottawa");
            Assert.AreEqual("Inserted Successfully", _manageState.AlertText());
        }

        [Test(Description = "Verify if Duplicate State Name is allowed to submit")]
        public void Verify_Duplicate_StateName_Allowed()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.EnterStatename("Arizona");
            _manageState.EnterStatecode("AA");
            _manageState.ClickSubmit();
            Assert.AreEqual("StateName already Exist", _manageState.AlertText());
        }

        [Test(Description = "Verify if Duplicate State Name is allowed to submit")]
        public void Verify_DuplicateStateName_CannotCreated()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.EnterStatename("Arizona");
            _manageState.ClickSubmit();
            Assert.AreEqual("StateName already Exist", _manageState.AlertText());
        }
        [Test(Description = "Verify Manage State Functionality by providing All Fields")]
        public void Verify_ManageStatePage_Fiiling_AllFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.ManageStateRecord("Cuba", "RA");
            Assert.AreEqual("Inserted Successfully", _manageState.AlertText());
        }

        [Test(Description = "Verify the Cancel button Functionality")]
        public void Verify_CancelButton()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.ManageStateRecordCancelButton("Rwanda", "RA");
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "Verify the Edit icon Functionality")]
        public void Verify_ManageState_CanBeEdited()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.ClickEditButton("Arizona");
            Assert.AreEqual("Oximetry", _driver.Title);
        }
        [Test(Description = "Verify the Update Functionality")]
        public void Verify_ManageState_CanBeUpdated()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageState.GoToAdmin();
            _manageState.EditButton();
            _manageState.EnterStatecode("AK");
            _manageState.ClickUpdate();
            Assert.AreEqual("Successfully Updated", _manageState.AlertText());
        }
    }
}
