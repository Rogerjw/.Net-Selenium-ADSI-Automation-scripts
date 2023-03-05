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
    public class ScheduleOximetryTest : MasterTest
    {
        private ScheduleOximetryPage _scheduleOximetryPage;
        private LoginPage _loginPage;

        [SetUp]
        public void Before()
        {
            _scheduleOximetryPage = new ScheduleOximetryPage(_driver);
            _loginPage = new LoginPage(_driver);
        }

        [Test(Description = "To verify the schedule oximetry flow ")]
        public void TestScheduleOximetry()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleOximetryPage.GoToScheduleOximetry();            
            string name = _scheduleOximetryPage.SearchPatient("Tagmuthu", "Krishnan");
            _scheduleOximetryPage.SelectGivenPatientRecord(name);
            _scheduleOximetryPage.ClickPatientNext();
            _scheduleOximetryPage.SelectPhysician("Peter", "Hogenkamp, Md");
            _scheduleOximetryPage.SearchAndSelectDiagnosis("Shortness of breath");
            _scheduleOximetryPage.SearchAndSelectDiagnosis1("Wheezing");
            _scheduleOximetryPage.SearchAndSelectDiagnosis2("Snoring");
            _scheduleOximetryPage.ChooseRXOnFileCheckbox();
            _scheduleOximetryPage.ChooseAOBOnFileCheckbox();
            _scheduleOximetryPage.EnterRXDate("12/03/2023");
            _scheduleOximetryPage.ClickSubmit();
        }

        [Test(Description = "To verify the select patient functionality in schedule oximetry")]
        public void VerifySelectPatientFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleOximetryPage.GoToScheduleOximetry();
            try { _scheduleOximetryPage.ClickPatientNext(); }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            { Assert.IsTrue(ex.AlertText.Equals("Please select a Patient record.")); } 
        }

        [Test(Description ="To verify the select physician functionality in schedule oximetry")]
        public void VerifySelectPhysicianFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleOximetryPage.GoToScheduleOximetry();
            string name = _scheduleOximetryPage.SearchPatient("Tagmuthu", "Krishnan");
            _scheduleOximetryPage.SelectGivenPatientRecord(name);
            _scheduleOximetryPage.ClickPatientNext();            
            try { _scheduleOximetryPage.ClickPhysicianNext(); }
            catch(OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Please select a Physician Record."));
            } 
        }

        [Test(Description = "To verify the diagnosis field in schedule oximetry")]
        public void VerifyDiagnosisFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");            
            _scheduleOximetryPage.GoToScheduleOximetry();            
            string name = _scheduleOximetryPage.SearchPatient("Tagmuthu", "Krishnan");
            _scheduleOximetryPage.SelectGivenPatientRecord(name);
            _scheduleOximetryPage.ClickPatientNext();
            _scheduleOximetryPage.SelectPhysician("Peter", "Hogenkamp, Md");            
            _scheduleOximetryPage.ChooseRXOnFileCheckbox();
            _scheduleOximetryPage.ChooseAOBOnFileCheckbox();
            _scheduleOximetryPage.EnterRXDate("12/03/2023");
            try { _scheduleOximetryPage.ClickSubmit(); }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Enter Diagnosis"));
            }           
        }

        [Test(Description = "To verify the schedule oximetry flow ")]
        public void VerifyRXonFileAndAOBonFileFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleOximetryPage.GoToScheduleOximetry();
            string name = _scheduleOximetryPage.SearchPatient("Tagmuthu", "Krishnan");
            _scheduleOximetryPage.SelectGivenPatientRecord(name);
            _scheduleOximetryPage.ClickPatientNext();
            _scheduleOximetryPage.SelectPhysician("Peter", "Hogenkamp, Md");
            _scheduleOximetryPage.SearchAndSelectDiagnosis("Shortness of breath");
            _scheduleOximetryPage.SearchAndSelectDiagnosis1("Wheezing");
            _scheduleOximetryPage.SearchAndSelectDiagnosis2("Snoring");
            _scheduleOximetryPage.EnterRXDate("12/03/2023");
            _scheduleOximetryPage.ClickSubmit();            
            Assert.IsTrue(_scheduleOximetryPage.VerifyMessage());
        }

        [Test(Description = "To verify RX date functionality in schedule oximetry")]
        public void VerifyRXDAteFunctionality()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            Assert.AreEqual("Oximetry", _driver.Title);
            _scheduleOximetryPage.GoToScheduleOximetry();
            string name = _scheduleOximetryPage.SearchPatient("Tagmuthu", "Krishnan");
            _scheduleOximetryPage.SelectGivenPatientRecord(name);
            _scheduleOximetryPage.ClickPatientNext();
            _scheduleOximetryPage.SelectPhysician("Peter", "Hogenkamp, Md");
            _scheduleOximetryPage.SearchAndSelectDiagnosis("Shortness of breath");
            _scheduleOximetryPage.SearchAndSelectDiagnosis1("Wheezing");
            _scheduleOximetryPage.SearchAndSelectDiagnosis2("Snoring");
            _scheduleOximetryPage.ChooseRXOnFileCheckbox();
            _scheduleOximetryPage.ChooseAOBOnFileCheckbox();
            try { _scheduleOximetryPage.ClickSubmit(); }
            catch (OpenQA.Selenium.UnhandledAlertException ex)
            {
                Assert.IsTrue(ex.AlertText.Equals("Please Select a Date for Schedule"));
            }
        }
    }
}
