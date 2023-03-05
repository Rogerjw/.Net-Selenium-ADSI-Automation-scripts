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
    public class SearchPatientTest : MasterTest
    {
        private ScheduleOximetryPage _scheduleOximetryPage;
        private LoginPage _loginPage;
        private SearchPatientPage _searchPatientPage;

        [SetUp]
        public void Before()
        {
            _scheduleOximetryPage = new ScheduleOximetryPage(_driver);
            _loginPage = new LoginPage(_driver);
            _searchPatientPage = new SearchPatientPage(_driver);
        }

        [Test(Description = "Verify if Manage Patient link is clickable and navigates to Manage patient page")]
        public void VerifyManagePatientLink()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();            
            Assert.AreEqual(_searchPatientPage.VerifySearchPatientRecordsImageDisplayed(),true);    
        }

        [Test(Description = "Verify if Search Patient Record menu is clickable and navigates to Search Patient page")]
        public void VerifySearchPatientRecord()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();           
            _searchPatientPage.ClickSearchPatientRecords();
            Assert.AreEqual(_searchPatientPage.VerifyFirstnameFieldDisplayed(), true);
        }

        [Test(Description = "Verify search functionality by providing only First Name")]
        public void VerifySearchPatientWithFirstname()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();
            _searchPatientPage.ClickSearchPatientRecords();
            _searchPatientPage.EnterFirstname("Tagmuthu");
            _searchPatientPage.ClickSubmit();
            Assert.AreEqual(_searchPatientPage.VerifyGivenFirstnameDisplayed("Tagmuthu"), true);
        }

        [Test(Description = "Verify search functionality by providing only Last Name")]
        public void VerifySearchPatientWithLastname()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();
            _searchPatientPage.ClickSearchPatientRecords();
            _searchPatientPage.EnterLastname("Krishnan");
            _searchPatientPage.ClickSubmit();
            Assert.AreEqual(_searchPatientPage.VerifyGivenFirstnameDisplayed("Krishnan"), true);
        }

        [Test(Description = "Verify search functionality by providing only DOB")]
        public void VerifySearchPatientWithDOB()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();
            _searchPatientPage.ClickSearchPatientRecords();
            _searchPatientPage.EnterDOB("04/08/1973"); 
            _searchPatientPage.ClickSubmit();
            Assert.AreEqual(_searchPatientPage.VerifyGivenFirstnameDisplayed("04/08/1973"), true); 
        }

        [Test(Description = "Verify search functionality by providing only Insurance ID")]
        public void VerifySearchPatientWithInsuranceId()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();
            _searchPatientPage.ClickSearchPatientRecords();
            _searchPatientPage.EnterInsurance("ABCD1234"); 
            _searchPatientPage.ClickSubmit();
            Assert.AreEqual(_searchPatientPage.VerifyGivenFirstnameDisplayed("Tagmuthu"), true); 
        }

        [Test(Description = "Verify the Search Functionality by providing all input field data's")]
        public void VerifySearchPatientWithAllInputs()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();
            _searchPatientPage.ClickSearchPatientRecords();
            _searchPatientPage.EnterFirstname("Tagmuthu");
            _searchPatientPage.EnterLastname("Krishnan");
            _searchPatientPage.EnterDOB("04/08/1973"); 
            _searchPatientPage.EnterInsurance("ABCD1234"); 
            _searchPatientPage.ClickSubmit();
            Assert.AreEqual(_searchPatientPage.VerifyGivenFirstnameDisplayed("Tagmuthu"), true); 
        }

        [Test(Description = "Verify the Search Functionality without providing any data's")]
        public void VerifySearchPatientWithEmptyInputs()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();
            _searchPatientPage.ClickSearchPatientRecords();           
            _searchPatientPage.ClickSubmit();
            Assert.AreEqual(_searchPatientPage.VerifySearchResults(),true); 
        }

        [Test(Description = "Verify the Cancel button functionality")]
        public void VerifySearchPatientCancelButton()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _searchPatientPage.GoToManagePatient();
            _searchPatientPage.ClickSearchPatientRecords();
            _searchPatientPage.EnterFirstname("Tagmuthu");
            _searchPatientPage.EnterLastname("Krishnan");
            _searchPatientPage.EnterDOB("Krishnan"); 
            _searchPatientPage.EnterInsurance("Krishnan");
            _searchPatientPage.ClickCancel();            
            Assert.AreEqual(_searchPatientPage.VerifyElementText(), true);
        }
    }
}
