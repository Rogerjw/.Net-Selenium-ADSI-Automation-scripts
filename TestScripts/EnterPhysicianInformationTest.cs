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
    public class EnterPhysicianInformationTest : MasterTest
    {
        private LoginPage _loginPage;
        private EnterPhysicianInformationPage _physicianInformationPage;

        [SetUp]
        public void Before()
        {           
            _loginPage = new LoginPage(_driver);
            _physicianInformationPage = new EnterPhysicianInformationPage(_driver);
        }

        [Test(Description = "To verify the schedule oximetry flow ")]
        public void VerifyCreatePhysicianFunctionalityWithValidInputs()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");            
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Equals("Successfully Inserted"));
        }

        [Test(Description = "To verify the create physician functionality with empty value")]
        public void VerifyCreatePhysicianFunctionalityWithEmptyValue()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.ClickSubmit();
            Assert.IsFalse(_physicianInformationPage.GetAlertText().Equals("Successfully Inserted"));
        }

        [Test(Description = "To verify the First name field in create physician functionality")]
        public void VerifyFirstnameFieldInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();            
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("ReqFirstName"));
        }

        [Test(Description = "To verify the NPI field functionality in create physician functionality")]
        public void VerifyNPIFieldInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");           
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter NPI"));
        }

        [Test(Description = "To verify the Physician name field in create physician functionality")]
        public void VerifyPhysiciannameFieldInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.ClearPhysicianName();
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("EnterUserName"));
        }

        [Test(Description = "To verify the Organization, company and company user fields in create physician functionality")]
        public void VerifyOrganizationCompanyAndCompanyuserFieldsInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");            
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter Company"));
        }

        [Test(Description = "To verify the email field in create physician functionality")]
        public void VerifyEmailFieldInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.ClearEmailID();
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter EmailID"));
        }

        [Test(Description = "To verify the password field in create physician functionality")]
        public void VerifyPasswordFieldInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.ClearPhysicianPassword();
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter Password"));
        }

        [Test(Description = "To verify the state and city fields in create physician functionality")]
        public void VerifyStateAndCityFieldsInCreatePhysicianFunctionalit()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");           
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("EnterState"));
            _physicianInformationPage.AcceptAlert();
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter City"));
        }

        [Test(Description = "To verify the zip field in create physician functionality")]
        public void VerifyZipFieldInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");            
            _physicianInformationPage.EnterPhysicianPhone("2161562632");
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter Zip"));
        }

        [Test(Description = "To verify the phone field in create physician functionality")]
        public void VerifyPhoneFieldInCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");            
            _physicianInformationPage.EnterPhysicianFax("2161562632");
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter Phone"));
        }

        [Test(Description = "To verify the fax field in create physician functionality")]
        public void VerifyFaxFieldCreatePhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _physicianInformationPage.GoToManagePhysician();
            _physicianInformationPage.ClickEnterPhysicianInformationImage();
            _physicianInformationPage.EnterPhysicianFirstName("Test");
            _physicianInformationPage.EnterPhysicianLastName("Physician");
            _physicianInformationPage.EnterPhysicianNPI("6956");
            _physicianInformationPage.SelectOrganization("Medway Medical");
            _physicianInformationPage.SelectCompany("Medway Medical");
            _physicianInformationPage.SelectCompanyUsers("Alex Jones");
            _physicianInformationPage.EnterBrightreePhysicianID("7646");
            _physicianInformationPage.EnterPhysicianCMDReferringSequence("5664");
            _physicianInformationPage.EnterPhysicianAddress1("Test");
            _physicianInformationPage.EnterPhysicianAddress2("Test");
            _physicianInformationPage.SelectPhysicianState("Florida");
            _physicianInformationPage.SelectPhysicianCity("32401");
            _physicianInformationPage.EnterPhysicianZip("2161562632");
            _physicianInformationPage.EnterPhysicianPhone("2161562632");           
            _physicianInformationPage.SelectOximetryReports("Full Report");
            _physicianInformationPage.SelectHSTMarketing("No");
            _physicianInformationPage.SelectOxygenRx("No");
            _physicianInformationPage.SelectNPVisitReports("Full Report");
            _physicianInformationPage.SelectReportDelivery("HME to Deliver");
            _physicianInformationPage.SelectOximeterReportLayout("Simple Design");
            _physicianInformationPage.ClickSubmit();
            Assert.IsTrue(_physicianInformationPage.GetAlertText().Contains("Enter Fax"));
        }
    }
}
