using ADSAutomation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class HSTResultTest : MasterTest
    {
        private LoginPage _loginPage;
        private HSTResultPage _hstResultPage;

        [OneTimeSetUp]
        public void OneTimeBefore()
        {
            _hstResultPage = new HSTResultPage(_driver);
            _loginPage = new LoginPage(_driver);
            _loginPage.Login("admin@techaffinity.com", "admin");
            _hstResultPage.GoToHSTResults();
        }

        [SetUp]
        public void Before()
        {  
            _hstResultPage.GoToHSTResults();
        }

        [Test(Description = "Check whether the user is able to navigate to HST Result page")]
        public void Verify_HSTResultLink_ReturnsHSTResultPage()
        {
            Assert.AreEqual("HST Results", _hstResultPage.GetHeader("HST Results"));
        }

        [Test(Description = "To verify user is able to search the record in HST Result page")]
        public void Verify_Patients_CanBeSearched()
        {
            _hstResultPage.ClickAllRadioBtn();
            _hstResultPage.EnterPatientName("Tagmuthu2 Krishnan");
            _hstResultPage.EnterInsuranceId("");
            _hstResultPage.EnterReferralDate("12/14/2022");
            _hstResultPage.EnterAHI("");
            _hstResultPage.EnterShippedDate("");
            _hstResultPage.EnterReturnDate("");
            _hstResultPage.EnterInterpretDate("");
            _hstResultPage.EnterSSN("");
            _hstResultPage.EnterInterpretDateRangeFrom("");
            _hstResultPage.EnterInterpretDateRangeTo("");
            _hstResultPage.EnterPhysicianName("Test md Test");
            _hstResultPage.EnterNPI("");
            _hstResultPage.Submit();
            Assert.AreEqual("1", _hstResultPage.GetPagingNumber());
        }

        [Test(Description = "To verify Cancel functioanlity in HST Result page")]
        public void Verify_CancelButton_ClearsAllTheFields()
        {
            _hstResultPage.EnterPatientName("Tagmuthu2 Krishnan");
            _hstResultPage.EnterInsuranceId("ABC1234");
            _hstResultPage.EnterReferralDate("12/14/2022");
            _hstResultPage.EnterAHI("12/14/2022");
            _hstResultPage.EnterShippedDate("12/14/2022");
            _hstResultPage.EnterReturnDate("12/14/2022");
            _hstResultPage.EnterInterpretDate("12/14/2022");
            _hstResultPage.EnterSSN("80840123456789");
            _hstResultPage.EnterInterpretDateRangeFrom("12/14/2022");
            _hstResultPage.EnterInterpretDateRangeTo("12/14/2022");
            _hstResultPage.EnterPhysicianName("Test md Test");
            _hstResultPage.EnterNPI("80840123456789");
            _hstResultPage.Cancel();
            Assert.IsTrue(_hstResultPage.AreAllTextboxCleared());
        }

        [Test(Description = "To verify user is able to see the All records in HST Record page")]
        public void Verify_AllPatientsCanBeViewed_ByClickingAllRadioButton()
        {
            _hstResultPage.ClickNonArchivedRadioBtn();
            var nonArchivedEntries = _hstResultPage.GetPagingNumber();
            _hstResultPage.ClickAllRadioBtn();
            Assert.IsTrue(_hstResultPage.GetPagingNumber() != nonArchivedEntries);
        }

        [Test(Description = "To verify user is able to see the Archived records in HST Record page")]
        public void Verify_ArchivedPatientsCanBeViewed_ByClickingArchivedRadioButton()
        {
            _hstResultPage.ClickNonArchivedRadioBtn();
            var nonArchivedEntries = _hstResultPage.GetPagingNumber();
            _hstResultPage.ClickArchivedRadioBtn();
            Assert.IsTrue(_hstResultPage.GetPagingNumber() != nonArchivedEntries);
        }

        [Test(Description = "To verify user is able to see the Non Archived records in HST Record page")]
        public void Verify_NonArchivedPatientsCanBeViewed_ByClickingNonArchivedRadioButton()
        {
            _hstResultPage.ClickNonArchivedRadioBtn();
            Assert.AreEqual("Archive", _hstResultPage.GetArchiveActionBtnText());
        }

        [Test(Description = "To verify user is able to upload the Report for patient")]
        public void Verify_PatientsReport_CanBeUploaded()
        {
            _hstResultPage.ClickReport();
            var reportName = _hstResultPage.ChooseReport();
            _hstResultPage.Upload();
            Assert.AreEqual(reportName, _hstResultPage.GetReportName());
        }

        [Test(Description = "To verify user is able to Edit the details for Patient")]
        public void Verify_Patient_CanBeEditted()
        {
            _hstResultPage.ClickEdit();
            Assert.Inconclusive("Report page is showing up instead of the edittable page ");
        }

        [Test(Description = "To verify user is Resend the Fax from HST Result")]
        public void Verify_TheFax_CanBeResent()
        {
            _hstResultPage.ClickFax();
            _hstResultPage.ClickResendFax();
            Assert.Inconclusive("Fax machine not available");
            _hstResultPage.ClickOkAlert();
        }

        [Test(Description = "To verify user is able to move the Non Archived records to Archived records")]
        public void Verify_NonArchivedRecords_CanBeMovedToArchivedRecords()
        {
            _hstResultPage.ClickNonArchivedRadioBtn();
            _hstResultPage.ClickArchiveActionBtn();
            Assert.AreEqual("Record moved to Archieved", _hstResultPage.GetAlertText());
            _hstResultPage.ClickOkAlert();
        }

        [Test(Description = "To verify user is able to Submit the claim for particular record in HST Result page")]
        [Ignore("functionality not ready yet")]
        public void Verify_Claims_CanBeSubmitted()
        {
            _hstResultPage.ClickClaimActionBtn();
            _hstResultPage.ClickOkAlert();
            _hstResultPage.ClickOkAlert();
        }

        [Test(Description = "To verify user is able to see the patient information from HST Result page")]
        public void Verify_PatientInfo_CanBeViewed()
        {
            var patientName = _hstResultPage.GetPatientName();
            _hstResultPage.ClickPatientInfoLink();
            Assert.AreEqual("Update Patient", _hstResultPage.GetHeader("Update Patient"));
            Assert.AreEqual(patientName, _hstResultPage.GetPatientFirstNameTextBoxContent());
        }

        [Test(Description = "To verify user is able to see the Physician information from HST Result page")]
        public void Verify_PhysicianInfo_CanBeViewed()
        {
            var physicianName = _hstResultPage.GetPhysicianName();
            _hstResultPage.ClickPhysicianInfoLink();
            Assert.AreEqual("Update Physician", _hstResultPage.GetHeader("Update Physician"));
            Assert.AreEqual(physicianName, _hstResultPage.GetPhysicianFirstNameTextBoxContent());
        }
    }
}
