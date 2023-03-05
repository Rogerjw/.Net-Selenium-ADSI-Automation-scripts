using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    class ManageRegionTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageRegion _manageRegion;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(_driver);
            _manageRegion = new ManageRegion(_driver);
        }
        [Test(Description = "Verify if Admin >> Manage Region link is clickable and navigates to Manage Region page")]
        public void HoverManageRegionPage()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "Verify if State is created without any data's provided")]
        public void Verify_Region_CanToBeCreated()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            _manageRegion.SubmitRegionRecord();
            Assert.AreEqual(true, _manageRegion.AlertText().Contains("Enter Region"));
        }

        [Test(Description = "Verify Manage State Functionality by providing only Mandatory Fields")]
        public void Verify_Region_ByOnly_RegionName()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            _manageRegion.ManageRegionRecordByRegionName("Buja");
            Assert.AreEqual("Inserted Successfully", _manageRegion.AlertText());
        }

        [Test(Description = "Verify if Duplicate Region Name is allowed to submit")]
        public void Verify_DuplicateRegionName_CannotCreated()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            _manageRegion.EnterRegionname("Absolute Elder Care Ocala");
            _manageRegion.ClickSubmit();
            Assert.AreEqual("RegionName already Exist", _manageRegion.AlertText());
        }
        [Test(Description = "Verify Manage Region Functionality by providing All Fields")]
        public void Verify_ManageRegion_Filling_AllFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            _manageRegion.ManageRegionRecord("AHUP MEDICAL FLORIDA", "600081");
            Assert.AreEqual("Inserted Successfully", _manageRegion.AlertText());
        }

        [Test(Description = "Verify the Cancel button Functionality")]
        public void Verify_CancelButton()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            _manageRegion.ManageRegionRecordCancel("ABC MEDICAL FLORIDA", "600081");
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "Verify the Edit icon Functionality")]
        public void Verify_ManageRegion_EditIcon()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            _manageRegion.ManageRegionIconRecord();
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "Verify the Update Functionality")]
        public void Verify_ManageRegionPageUpdate()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageRegion.GoToAdmin();
            _manageRegion.EditButton();
            _manageRegion.EnterRegioncode("900002");
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageRegion.ClickUpdate();
        }
    }
}
