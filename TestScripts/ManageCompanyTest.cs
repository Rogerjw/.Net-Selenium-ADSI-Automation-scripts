using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    class ManageCompanyTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageCompany _manageCompany;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(_driver);
            _manageCompany = new ManageCompany(_driver);
        }

        [Test(Description = "Verify if Admin >> Manage Company link is clickable and navigates to Manage Company page")]
        public void HoverManageCompanyPage()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageCompany.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "To verify the create company functionality with valid inputs")]
        public void Verify_ManageCompany_InputAllFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageCompany.GoToAdmin();
            _manageCompany.ManageCompanyRecord("Airtel","Airtel Rw","mango12","123","0789887770","0707362526","kigali","kk","250","canal@gmail.com");
            _manageCompany.oxmetries("Airtel@gmail.com");
            _manageCompany.ManageCompanyDefaults("www.mango.com", "canal23");
            _manageCompany.ClickSubmit();
            Assert.AreEqual("Inserted Successfully", _manageCompany.AlertText());
        }

        [Test(Description = "To verify the create company functionality with empty inputs")]
        public void Verify_Submit_EmptyInputs_Allowed()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageCompany.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageCompany.VerifyEmptySubmission();
        }

        [Test(Description = "To verify that system accepting duplicate company name")]
        public void _Verify_ManageCompany_Allow_DuplicateCompanyName()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageCompany.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageCompany.ManageDuplicateCompName("ADSI");

        }

        [Test(Description = "To verify that search functionality in manage company screen")]
        public void Verify_SearchByCompanyName()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageCompany.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageCompany.ManageSearchFunctionality("ADSI");
        }

        [Test(Description = "To verify that edit functionality in manage company screen")]
        public void Verify_ManageCompany_EditFunction()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageCompany.GoToAdmin();
            _manageCompany.SelectEditIcon();
            _manageCompany.EnterAdress2("US HWY 25");
            _manageCompany.ClickUpdate();
            Assert.AreEqual("Successfully Updated", _manageCompany.AlertText());
        }
    }
}
