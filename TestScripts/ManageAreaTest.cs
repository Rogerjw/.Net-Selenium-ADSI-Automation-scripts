using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class ManageAreaTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageAreaPage _manageAreaPage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _manageAreaPage = new ManageAreaPage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
        }

        [SetUp]
        public void Before()
        {
            _manageAreaPage.GoToAdmin();
        }

        [Test(Description = "Verify if Admin >> Manage Area link is clickable and navigates to Manage Area page")]
        public void Verify_ManageAreaLink_ReturnsManageAreaPage()
        {
            Assert.AreEqual("Manage Area", _manageAreaPage.GetHeader());
        }

        [Test(Description = "Verify if Region is created without any data's provided")]
        public void Verify_AreaCannotBeCreated_WithoutData()
        {
            _manageAreaPage.ClickSubmit();
            Assert.IsTrue(_manageAreaPage.GetAlertText().Contains("Enter Area"));
            _manageAreaPage.ClickOkAlert();
        }

        [Test(Description = "Verify Manage Area Functionality by providing only Mandatory Fields")]
        public void Verify_AreaCanBeCreated_WithOnlyMandatoryField()
        {
            _manageAreaPage.ChooseRegion("ABC MEDICAL FLORIDA");
            _manageAreaPage.EnterAreaName("a"+_manageAreaPage.GenerateRandomNumber());
            _manageAreaPage.ClickSubmit();
            Assert.AreEqual("Inserted Successfully", _manageAreaPage.GetAlertText());
            _manageAreaPage.ClickOkAlert();
        }

        [Test(Description = "Verify if Duplicate Area Name is allowed to submit")]
        public void Verify_DuplicateAreas_CannotBeCreated()
        {
            _manageAreaPage.ChooseRegion("ABC MEDICAL FLORIDA");
            _manageAreaPage.EnterAreaName("a");
            _manageAreaPage.ClickSubmit();
            _manageAreaPage.ClickOkAlert();
            _manageAreaPage.ChooseRegion("ABC MEDICAL FLORIDA");
            _manageAreaPage.EnterAreaName("a");
            _manageAreaPage.ClickSubmit();
            Assert.AreEqual("AreaName already Exist", _manageAreaPage.GetAlertText());
            _manageAreaPage.ClickOkAlert();
        }

        [Test(Description = "Verify Manage Area Functionality by providing All Fields")]
        public void Verify_AreaCanBeCreated_WithAllFieldsProvided()
        {
            _manageAreaPage.ChooseRegion("ABC MEDICAL FLORIDA");
            _manageAreaPage.EnterAreaName("a"+_manageAreaPage.GenerateRandomNumber());
            _manageAreaPage.EnterAreaCodeName("1"+_manageAreaPage.GenerateRandomNumber());
            _manageAreaPage.ClickSubmit();
            Assert.AreEqual("Inserted Successfully", _manageAreaPage.GetAlertText());
            _manageAreaPage.ClickOkAlert();
        }

        [Test(Description = "Verify the Cancel button Functionality")]
        public void Verify_CancelButton_ClearsAllTheFields()
        {
            _manageAreaPage.ChooseRegion("ABC MEDICAL FLORIDA");
            _manageAreaPage.EnterAreaName("aaa");
            _manageAreaPage.EnterAreaCodeName("1");
            _manageAreaPage.ClickCancel();
            Assert.IsTrue(_manageAreaPage.GetTextBoxValue().Equals(""));
        }

        [Test(Description = "Verify the Edit icon Functionality")]
        public void Verify_Area_CanBeEditted()
        {
            _manageAreaPage.ClickEditButton();
            Assert.AreEqual(_manageAreaPage.GetSecondCellAreaName(), _manageAreaPage.GetTextBoxValue());
        }

        [Test(Description = "Verify the Update Functionality")]
        public void Verify_Area_CanBeUpdated()
        {
            _manageAreaPage.ClickEditButton();
            _manageAreaPage.EnterAreaName("ab"+_manageAreaPage.GenerateRandomNumber());
            _manageAreaPage.EnterAreaCodeName("1"+_manageAreaPage.GenerateRandomNumber());
            _manageAreaPage.ClickSubmit();
            Assert.AreEqual("Successfully Updated", _manageAreaPage.GetAlertText());
            _manageAreaPage.ClickOkAlert();
        }
    }
}
