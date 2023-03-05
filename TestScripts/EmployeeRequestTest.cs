using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class EmployeeRequestTest : MasterTest
    {
        private LoginPage _loginPage;
        private EmployeeRequestPage _employeeRequestPage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _employeeRequestPage = new EmployeeRequestPage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
        }

        [SetUp]
        public void Before()
        {
            _employeeRequestPage.GoToAdmin();
        }

        [Test(Description = "Check whether the user is able to navigate to Employee Request  page")]
        public void Verify_EmployeeRequestLink_ReturnsEmployeeRequestPage()
        {
            Assert.AreEqual("Employee Request", _employeeRequestPage.GetHeader());
        }

        [Test(Description = "To verify user is able to create the Employee Request")]
        public void Verify_EmployeeRequestCanBeCreated_WithAllFieldsProvided()
        {
            var numberOfRecords = _employeeRequestPage.GetPagingNumber();
            _employeeRequestPage.ChooseRequestReason();
            _employeeRequestPage.SelectStartDate("2/15/1954");
            _employeeRequestPage.SelectEndDate("2/16/1954");
            _employeeRequestPage.ChooseOtherRequestReason();
            _employeeRequestPage.ClickSubmit();
            _employeeRequestPage.ClickLogout();
            AfterTest();
            TearDown();
            BeforeTest();
            OneTimeBefore();
            Before();
            var numberOfRecordsTwo = _employeeRequestPage.GetPagingNumber();
            Assert.AreEqual(numberOfRecords + 1, numberOfRecordsTwo);
        }

        [Test(Description = "To verify user is able to edit the existing Employee Request")]
        public void Verify_EmployeeRequest_CanBeEdittedAndUpdated()
        {
            _employeeRequestPage.ClickEditButton();
            Assert.AreEqual(_employeeRequestPage.GetNames(), _employeeRequestPage.GetFirstTwoCells());

        }

        [Test(Description = "To verify user is able to search the Existing Employee Request using First Name")]
        public void Verify_EmployeeRequestCanbeSearched_usingFirstName()
        {
            _employeeRequestPage.SearchFirstName("Jhon");
            //Assert.AreEqual("Jhon", _employeeRequestPage.GetFirstCell());
        }

        [Test(Description = "To verify user is able to search the Existing Employee Request using Last Name")]
        public void Verify_EmployeeRequestCanbeSearched_usingLastName()
        {
            _employeeRequestPage.SearchLastName("user");
            //Assert.AreEqual("user", _employeeRequestPage.GetSecondCell());
        }

        [Test(Description = "To verify user is able to search the Existing Employee Request using Request Reason")]
        public void Verify_EmployeeRequestCanbeSearched_usingRequestReason()
        {
            _employeeRequestPage.SearchRequestReason("Vacation");
            //Assert.AreEqual("Vacation", _employeeRequestPage.GetThirdCell());
        }

        [Test(Description = "To verify user is able to search the Existing Employee Request using Other Requested Reason")]
        public void Verify_EmployeeRequestCanbeSearched_usingOtherRequestReason()
        {
            _employeeRequestPage.SearchOtherRequestReason("Vacation");
            //Assert.AreEqual("Vacation", _employeeRequestPage.GetFourthCell());
        }

        [Test(Description = "To verify user is able to search the Existing Employee Request using Approve Status")]
        public void Verify_EmployeeRequestCanbeSearched_usingApproveStatus()
        {
            _employeeRequestPage.SearchApproveStatus("Approved");
            //Assert.AreEqual("Approved", _employeeRequestPage.GetSixthCell());
        }
    }
}
