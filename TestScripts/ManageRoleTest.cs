using ADSAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class ManageRoleTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageRolePage _manageRolePage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _manageRolePage = new ManageRolePage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
            
        }

        [SetUp]
        public void Before()
        {
            _manageRolePage.GoToAdmin();
        }

        [Test(Description = "Verify if Admin >> Manage Role link is clickable and navigates to Manage Role page")]
        public void Verify_ManageRoleLink_ReturnsManageRolePage()
        { 
            Assert.AreEqual("Manage Roles", _manageRolePage.GetHeader());
        }

        [Test(Description = "Verify if Role is created without any data's provided")]
        public void Verify_RoleCanBeCreated_WithoutData()
        {
            _manageRolePage.GoToSubmit();
            Assert.IsTrue(_manageRolePage.GetAlertText().Contains("Req.RoleName"));
            _manageRolePage.ClickOkAlert();

        }

        [Test(Description = "Verify Manage Role Functionality by providing only Mandatory Fields")]
        public void Verify_RoleCanBeCreated_WithOnlyMandatoryField()
        {
            var roleName = "a" + _manageRolePage.GenerateRandomNumber();
            _manageRolePage.EnterRoleName(roleName);
            _manageRolePage.GoToSubmit();
            Assert.AreEqual("Inserted Successfully", _manageRolePage.GetAlertText());
            _manageRolePage.ClickOkAlert();
        }

        [Test(Description = "Verify if Duplicate Name is allowed to submit")]
        public void Verify_DuplicateRoleNames_CannotBeCreated()
        {
            _manageRolePage.EnterRoleName("Admin");
            _manageRolePage.GoToSubmit();
            _manageRolePage.ClickOkAlert();
            _manageRolePage.EnterRoleName("Admin");
            _manageRolePage.GoToSubmit();
            Assert.AreEqual("Role already Created", _manageRolePage.GetAlertText());
            _manageRolePage.ClickOkAlert();
        }

        [Test(Description = "Verify Manage Role Functionality by providing All Fields")]
        public void Verify_RoleCanBeCreated_WithAllFields()
        {
            var roleName = "a" + _manageRolePage.GenerateRandomNumber();
            _manageRolePage.EnterRoleName(roleName);
            _manageRolePage.SelectAllFields();
            _manageRolePage.GoToSubmit();
            Assert.AreEqual("Inserted Successfully", _manageRolePage.GetAlertText());
            _manageRolePage.ClickOkAlert();
        }

        [Test(Description = "Verify the Cancel button Functionality")]
        public void Verify_CancelButton_ClearsAllTheFields()
        {
            var roleName = "a" + _manageRolePage.GenerateRandomNumber();
            _manageRolePage.EnterRoleName(roleName);
            _manageRolePage.SelectAllFields();
            _manageRolePage.ClickCancel();
            Assert.IsFalse(_manageRolePage.IsAnyCheckboxSelected());
        }


        [Test(Description = "Verify the Edit icon Functionality")]
        public void Verify_Role_CanBeEditted()
        {
            _manageRolePage.ClickEditButton();
            Assert.AreEqual(_manageRolePage.GetFirstCell(), _manageRolePage.GetRoleNameTextBoxValue());
        }

        [Test(Description = "Verify the Delete Functionality")]
        public void Verify_Role_CanBeDeleted()
        {
            var roleName = "a" + _manageRolePage.GenerateRandomNumber();
            _manageRolePage.EnterRoleName(roleName);
            _manageRolePage.GoToSubmit();
            Assert.AreEqual("Inserted Successfully", _manageRolePage.GetAlertText());
            _manageRolePage.ClickOkAlert();
            _manageRolePage.ClickDeleteButton();
            _manageRolePage.ClickOkAlert();
            Assert.AreEqual("SuccessFully Deleted", _manageRolePage.GetAlertText());
            _manageRolePage.ClickOkAlert();
        }

        [Test(Description = "Verify the Update Functionality")]
        public void Verify_Role_CanBeUpdated()
        {
            var roleName = "a" + _manageRolePage.GenerateRandomNumber();
            _manageRolePage.EnterRoleName(roleName);
            _manageRolePage.GoToSubmit();
            Assert.AreEqual("Inserted Successfully", _manageRolePage.GetAlertText());
            _manageRolePage.ClickOkAlert();
            _manageRolePage.ClickEditButton();
            _manageRolePage.EnterRoleName("a" + _manageRolePage.GenerateRandomNumber());
            _manageRolePage.ChooseType();
            _manageRolePage.GoToSubmit();
            Assert.AreEqual("Updated Successfully", _manageRolePage.GetAlertText());
            _manageRolePage.ClickOkAlert();
        }
    }
}
