using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    class ManageInsuranceTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageInsurance _manageInsurance;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(_driver);
            _manageInsurance = new ManageInsurance(_driver);
        }

        [Test(Description = "Verify if Admin >> Manage Insurance link is clickable and navigates to Manage Insurance page")]
        public void HoverManageInsurancePage()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageInsurance.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        //[Test(Description = "To verify the ÀDSI functionality in insurance screen")]
        //public void _Verify_ManageInsurance_Create()
        //{
        //    _loginPage.Login("admin@techaffinity.com", "admin");
        //    _manageInsurance.GoToAdmin();
        //    //Assert.AreEqual("Oximetry", _driver.Title);
        //    _manageInsurance.ManageInsuranceADSI();
        //    _manageInsurance.ManageInsuranceInfo("ASSAR", "RAS5");
        //    _manageInsurance.ManageContactInfo("ADDR1", "ADDR2", "Kgl");
        //    _manageInsurance.ManageBillingInfo("4", "3");
        //    _manageInsurance.ClickSave();
        //    Assert.AreEqual("Added Successfully.", _manageInsurance.AlertText());
        //}

        [Test(Description = "To verify the update values")]
        public void Verify_ManageUpdateValues_InsurancePage()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageInsurance.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageInsurance.ClickPrimaryTab();
            _manageInsurance.ClickEditIcon();
            _manageInsurance.EnterInsuranceName("CIGNA CARE CENTRY");
            _manageInsurance.ClickUpdate();
            Assert.AreEqual("Updated Successfully", _manageInsurance.AlertText());
        }

        [Test(Description = "To verify the add new button ADSI")]
        public void Verify_AddNewButton_ADSI()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageInsurance.GoToAdmin();
            _manageInsurance.ManageAddNewADSI("Mutuel","1288","Medical Insurance","123","456","789","12098");
            _manageInsurance.ClickSave();
            Assert.AreEqual("Added Successfully.", _manageInsurance.AlertText());
        }
    }
}
