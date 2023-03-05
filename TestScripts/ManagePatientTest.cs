using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using ADSAutomation.Base;
using ADSAutomation.Pages;
using ADSAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    public class ManagePatientTest : MasterTest
    {
        private ManagePatient _managePatient;
        private LoginPage _loginPage;

        [SetUp]
        public void Before()
        {
            _managePatient = new ManagePatient(_driver);
            _loginPage = new LoginPage(_driver);
        }
        [Test(Description = "To verify the Mouse Hover on Manage Menu ")]
        public void ADS_TC_236_ClickManagePatient()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();

        }

        [Test(Description = "To verify if user can navigate to search user page ")]
        public void ADS_TC_237_ClickSearchPatient()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.ClickEditIcon();

        }

        [Test(Description = "To verify if user can search physician with firstname")]
        public void ADS_TC_238_SearchByFirstName()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByFirstName("Megan" + Keys.Enter);
            _managePatient.WaitToClick("Megan", "Shirley, D.O.");
            _managePatient.ClickEditIcon();

        }
        [Test(Description = "To verify if user can search physician with lastname")]
        public void ADS_TC_239_SearchByLastName()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByLastName("Shirley, D.O." + Keys.Enter);
            _managePatient.WaitToClick("Megan", "Shirley, D.O.");
            _managePatient.ClickEditIcon();

        }
        [Test(Description = "To verify if user can search physician with emailid")]
        public void ADS_TC_240_SearchByEmailId()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByEmail("Megan@MeganShirleyDO.com" + Keys.Enter);
            _managePatient.WaitToClick("Megan", "Shirley, D.O.");
            _managePatient.ClickEditIcon();

        }
        [Test(Description = "To verify if user can search physician with Phoneno")]
        public void ADS_TC_241_SearchByPhoneNumber()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByPhone("(561) 318-6100" + "\n");
            _managePatient.WaitToClick("Megan", "Shirley, D.O.");
            _managePatient.ClickEditIcon();

        }
        [Test(Description = "To verify if user can search physician with Fax")]
        public void ADS_TC_242_SearchByFax()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByFax("5613286900" + "\n");
            _managePatient.WaitToClick("Megan", "Shirley, D.O.");
            _managePatient.ClickEditIcon();

        }
        [Test(Description = "To verify if user can search physician with City")]
        public void ADS_TC_243_SearchByCity()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByCity("ATLANTIS" + "\n");
            _managePatient.WaitToClick("Megan", "Shirley, D.O.");
            _managePatient.ClickEditIcon();

        }
        [Test(Description = "To verify if user can search physician with State")]
        public void ADS_TC_244_SearchByState()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByState("Florida" + "\n");
            //_managePatient.WaitTillPageLoad();
            _managePatient.ClickEditIcon();

        }
        [Test(Description = "To verify if user can search physician with Npi")]
        public void ADS_TC_245_SearchByNpi()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _managePatient.ClickManageMenu();
            _managePatient.ClickSearchPhysician();
            _managePatient.LoadPage();
            _managePatient.Elementchecker();
            _managePatient.SearchByNpi("1447662000" + "\n");
            _managePatient.WaitToClick("Megan", "Shirley, D.O.");
            _managePatient.ClickEditIcon();

        }
    }
}
