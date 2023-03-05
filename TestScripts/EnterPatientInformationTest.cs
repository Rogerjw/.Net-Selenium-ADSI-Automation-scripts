using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    public class EnterPatientInformationTest : MasterTest
    {
        private LoginPage _loginPage;
        private EnterPatientInformation _EnterPatientInformation;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(_driver);
            _EnterPatientInformation = new EnterPatientInformation(_driver);

        }
        [Test(Description = "To verify add patient information")]
        public void addPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC","ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1"+Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try { _EnterPatientInformation.clickSubmitButton(); }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Successfully Inserted"));
            }

        }

        [Test(Description = "To verify submit patient information without data")]
        public void submitPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _EnterPatientInformation.GotoEnterPatientInformation();
            try { _EnterPatientInformation.clickSubmitButton(); }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter FistName"));
            }
        }

        [Test(Description = "To verify First Name field in patient information page")]
        public void verifyFirstNameFieldinPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");

            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter FistName"));
            }
        }

        [Test(Description = "To verify lastname field in patient information page")]
        public void verifyLastNameFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter LastName"));
            }

        }

        [Test(Description = "To verify DOB field in patient information page")]
        public void verifyDOBFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Dob"));
            }

        }

        [Test(Description = "To verify Gender field in patient information page")]
        public void verifyGenderFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Gender"));
            }

        }

        [Test(Description = "To verify Insurance Type field in patient information page")]
        public void verifyInsuranceTypeFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Insurance Type"));
            }

        }

        [Test(Description = "To verify Insurance No field in patient information page")]
        public void verifyInsuranceNoFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("EnterInsuranceNo"));
            }

        }

        [Test(Description = "To verify Business field in patient information page")]
        public void verifyBusinessFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.entertheDetailsBillingAddress("10#", "123", "Alabama", "Abbeville", "2222", "1312143142", "4113141231", "dtest@gmail.com", "testing@gmail.com", "", "", "");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Company"));
            }

        }

        [Test(Description = "To verify State field in patient information page")]
        public void verifyStateFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC","ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.enterAddress1("12#");
            _EnterPatientInformation.enterZip("1214131");
            _EnterPatientInformation.enterPhone("4121411234");
            _EnterPatientInformation.enterCell("2131234453");
            _EnterPatientInformation.enterEmail1("testing123@gmail.com");
            _EnterPatientInformation.enterEmail2("test@gmail.com");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("", "", "", "", "", "", "", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Zip"));
            }

        }

        [Test(Description = "To verify Address field in patient information page")]
        public void verifyAddressFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.selectState("Alabama");
            _EnterPatientInformation.selectCity("Abbeville");
            _EnterPatientInformation.enterPhone("4121411234");
            _EnterPatientInformation.enterCell("2131234453");
            _EnterPatientInformation.enterZip("123141");
            _EnterPatientInformation.enterEmail1("testing123@gmail.com");
            _EnterPatientInformation.enterEmail2("test@gmail.com");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("test", "test", "1" + Random, "1" + Random, "testing", "1231", "11341", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("EnterAddress"));
            }

        }

        [Test(Description = "To verify Zip field in patient information page")]
        public void verifyZipFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.enterAddress1("12#");
            _EnterPatientInformation.selectState("Alabama");
            _EnterPatientInformation.selectCity("Abbeville");
            _EnterPatientInformation.enterPhone("4121411234");
            _EnterPatientInformation.enterCell("2131234453");
            _EnterPatientInformation.enterEmail1("testing123@gmail.com");
            _EnterPatientInformation.enterEmail2("test@gmail.com");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("", "", "", "", "", "", "", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Zip"));
            }

        }

        [Test(Description = "To verify Phone field in patient information page")]
        public void verifyPhoneFieldInPatientInformation()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            Random number = new Random();
            int Random = number.Next(100, 1000);
            _EnterPatientInformation.GotoEnterPatientInformation();
            //_EnterPatientInformation.clickEnterPatientInformation();
            _EnterPatientInformation.enterFirstName("test" + Random);
            _EnterPatientInformation.enterLastName("tech" + Random);
            _EnterPatientInformation.enterDOB("05/01/1997");
            _EnterPatientInformation.selectGender("Male");
            _EnterPatientInformation.selectPrimaryInsurance("Medicaid");
            _EnterPatientInformation.enterPrimaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterPrimaryInsGroup("1" + Random);
            _EnterPatientInformation.selectSecondaryInsurance("BCBS");
            _EnterPatientInformation.enterSecondaryInsuranceNo("1" + Random);
            _EnterPatientInformation.enterSecondaryInsGroup("1" + Random);
            _EnterPatientInformation.selectOrganization("Access Healthcare LLC");
            _EnterPatientInformation.selectCompany("Access Healthcare LLC", "ADS_Test");
            _EnterPatientInformation.enterBrightreePatientID("1" + Random);
            _EnterPatientInformation.enterHDMSAccount("1" + Random);
            _EnterPatientInformation.enterCMDAccount("1" + Random);
            //_EnterPatientInformation.AddCSR("", "", "");
            _EnterPatientInformation.enterAddress1("12#");
            _EnterPatientInformation.selectState("Alabama");
            _EnterPatientInformation.selectCity("Abbeville");
            _EnterPatientInformation.enterCell("2131234453");
            _EnterPatientInformation.enterZip("131313");
            _EnterPatientInformation.enterEmail1("testing123@gmail.com");
            _EnterPatientInformation.enterEmail2("test@gmail.com");
            _EnterPatientInformation.detailsPatientDocuments("Oximetry Rx", "3/2/2023", "9/8/2023", "");
            _EnterPatientInformation.detailsOfHSTInsuranceVerifcation("", "", "", "", "", "", "", "", "", "", "", "");
            try
            {
                _EnterPatientInformation.clickSubmitButton();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Phone"));
            }
        }
    }
}
