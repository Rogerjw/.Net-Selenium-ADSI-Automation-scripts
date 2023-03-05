using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    public class ScheduleRandE : MasterTest
    {
        private ScheduleRandEPage _scheduleRandEPage;
        private LoginPage _loginPage;

        [SetUp]
        public void Before()
        {
            _scheduleRandEPage = new ScheduleRandEPage(_driver);
            _loginPage = new LoginPage(_driver);
        }

        [Test(Description = "To verify the schedule RandE flow ")]
        public void TestScheduleRandE()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleRandEPage.GoToScheduleRandE();
            string name = _scheduleRandEPage.SearchPatient("Tagmuthu100", "Krishnan");
            _scheduleRandEPage.SelectGivenPatientRecord(name);
            _scheduleRandEPage.ClickPatientNext();
            _scheduleRandEPage.SelectPhysician("Peter", "Hogenkamp, Md");
            _scheduleRandEPage.SearchAndSelectDiagnosis("Shortness of breath");
            _scheduleRandEPage.SearchAndSelectDiagnosis1("Wheezing");
            _scheduleRandEPage.SearchAndSelectDiagnosis2("Snoring");
            _scheduleRandEPage.ChooseRXOnFileCheckbox();
            _scheduleRandEPage.ChooseAOBOnFileCheckbox();
            _scheduleRandEPage.EnterRXDate("05/03/2023");
            _scheduleRandEPage.ClickSubmit();
        }

        [Test(Description = "To verify the select patient functionality in schedule RandE")]
        public void VerifySelectPatientFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleRandEPage.GoToScheduleRandE();
            try
            {
                _scheduleRandEPage.ClickPatientNext();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Please select a Patient record."));
            }
        }

        [Test(Description = "To verify the select physician functionality in schedule RandE")]
        public void VerifySelectPhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleRandEPage.GoToScheduleRandE();
            string name = _scheduleRandEPage.SearchPatient("Tagmuthu100", "Krishnan");
            _scheduleRandEPage.SelectGivenPatientRecord(name);
            _scheduleRandEPage.ClickPatientNext();
            try
            {
                _scheduleRandEPage.ClickPhysicianNext();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Please select a Physician Record."));
            }
        }

        [Test(Description = "To verify the diagnosis field in schedule RandE")]
        public void VerifyDiagnosisFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _scheduleRandEPage.GoToScheduleRandE();
            string name = _scheduleRandEPage.SearchPatient("Tagmuthu100", "Krishnan");
            _scheduleRandEPage.SelectGivenPatientRecord(name);
            _scheduleRandEPage.ClickPatientNext();
            _scheduleRandEPage.SelectPhysician("Peter", "Hogenkamp, Md");
            _scheduleRandEPage.ChooseRXOnFileCheckbox();
            _scheduleRandEPage.ChooseAOBOnFileCheckbox();
            _scheduleRandEPage.EnterRXDate("12/03/2023");
            try
            {
                _scheduleRandEPage.ClickSubmit();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Diagnosis"));
            }
        }

        [Test(Description = "To verify the schedule RandE flow ")]
        public void VerifyRXonFileAndAOBonFileFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleRandEPage.GoToScheduleRandE();
            string name = _scheduleRandEPage.SearchPatient("Tagmuthu100", "Krishnan");
            _scheduleRandEPage.SelectGivenPatientRecord(name);
            _scheduleRandEPage.ClickPatientNext();
            _scheduleRandEPage.SelectPhysician("Peter", "Hogenkamp, Md");
            _scheduleRandEPage.SearchAndSelectDiagnosis("Shortness of breath");
            _scheduleRandEPage.SearchAndSelectDiagnosis1("Wheezing");
            _scheduleRandEPage.SearchAndSelectDiagnosis2("Snoring");
            _scheduleRandEPage.EnterRXDate("12/03/2023");
            _scheduleRandEPage.ClickSubmit();
            Assert.IsTrue(_scheduleRandEPage.VerifyMessage());
        }

        [Test(Description = "To verify RX date functionality in schedule RandE")]
        public void VerifyRXDAteFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleRandEPage.GoToScheduleRandE();
            string name = _scheduleRandEPage.SearchPatient("Tagmuthu100", "Krishnan");
            _scheduleRandEPage.SelectGivenPatientRecord(name);
            _scheduleRandEPage.ClickPatientNext();
            _scheduleRandEPage.SelectPhysician("Peter", "Hogenkamp, Md");
            _scheduleRandEPage.SearchAndSelectDiagnosis("Shortness of breath");
            _scheduleRandEPage.SearchAndSelectDiagnosis1("Wheezing");
            _scheduleRandEPage.SearchAndSelectDiagnosis2("Snoring");
            _scheduleRandEPage.ChooseRXOnFileCheckbox();
            _scheduleRandEPage.ChooseAOBOnFileCheckbox();
            try
            {
                _scheduleRandEPage.ClickSubmit();
            }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Please Select a Date for Schedule"));
            }
        }
    }
}
