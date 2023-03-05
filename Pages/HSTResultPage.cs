using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ADSAutomation.Pages
{
    class HSTResultPage : Helpers
    {
        private readonly By _resultsTab = By.LinkText("Results");
        private readonly By _hstResultsSubmenu = By.LinkText("HST Results");
        private readonly By _patientNameTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtFirstName");
        private readonly By _insuranceIdTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtInsurance");
        private readonly By _referralReceivedDate = By.Id("ctl00_ContentPlaceHolder1_TxtReferalRecived");
        private readonly By _ahiTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtAhi");
        private readonly By _shippedDate = By.Id("ctl00_ContentPlaceHolder1_TxtShipped");
        private readonly By _returnDate = By.Id("ctl00_ContentPlaceHolder1_txtReturn");
        private readonly By _interpretDate = By.Id("ctl00_ContentPlaceHolder1_txtInterpret");
        private readonly By _ssnTxtBox = By.Id("ctl00_ContentPlaceHolder1_txtSN");
        private readonly By _interpretDateRangeFrom = By.Id("ctl00_ContentPlaceHolder1_txtInerpretDateFrom");
        private readonly By _interpretDateRangeTo = By.Id("ctl00_ContentPlaceHolder1_txtInerpretDateTo");
        private readonly By _physicianNameTxtBox = By.Id("ctl00_ContentPlaceHolder1_txtPhysicianName");
        private readonly By _npiTxtBox = By.Id("ctl00_ContentPlaceHolder1_txtNPI");
        private readonly By _submitBtn = By.Id("ctl00_ContentPlaceHolder1_BtnSubmit");
        private readonly By _cancelBtn = By.Id("ctl00_ContentPlaceHolder1_BtnCancel");
        private readonly By _allRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbArchived_0");
        private readonly By _archivedRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbArchived_1");
        private readonly By _nonArchivedRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbArchived_2");
        private readonly By _archiveActionBtn = By.Id("ctl00_ContentPlaceHolder1_RepeaterHstResult_ctl00_lbarchieved");
        private readonly By _reportActionBtn = By.Id("ctl00_ContentPlaceHolder1_RepeaterHstResult_ctl00_HyperLink4");
        private readonly By _pagingNumberInfo = By.Id("ctl00_ContentPlaceHolder1_rpthstpaging_lblShowing");
        private readonly By _fileUpload = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlDocument_fileUploadDocument");
        private readonly By _uploadBtn = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlDocument_btnUploadFile");
        private readonly By _reportGridFirstCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_tbschedule_tppnlDocument_GrdDocuments']/..//tr[2]/td[1]");
        private readonly By _editActionBtn = By.Id("ctl00_ContentPlaceHolder1_RepeaterHstResult_ctl00_hledit");
        private readonly By _faxActionBtn = By.Id("ctl00_ContentPlaceHolder1_RepeaterHstResult_ctl00_HyperLink1");
        private readonly By _resendFaxBtn = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlFax_btnResendFax");
        private readonly By _claimActionBtn = By.Id("ctl00_ContentPlaceHolder1_RepeaterHstResult_ctl00_LinkSubmitClaim");
        private readonly By _patientInfoLink = By.Id("ctl00_ContentPlaceHolder1_RepeaterHstResult_ctl00_HyperLink6");
        private readonly By _physicianInfoLink = By.Id("ctl00_ContentPlaceHolder1_RepeaterHstResult_ctl00_HyperLink3");
        private readonly By _patientFirstNameTxtbox = By.Id("ctl00_ContentPlaceHolder1_tbpatient_tppatientInformation_TxtFirstName");
        private readonly By _physicianFirstNameTxtbox = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_TxtFirstName");

        public HSTResultPage(IWebDriver driver) : base(driver)
        {
        }
        public void GoToHSTResults()
        {
            MouseHover(_resultsTab);
            Click(_hstResultsSubmenu);
        }

        public string GetHeader(string name)
        {
            var _headerName = By.XPath($"//h4[text()='{name}']");
            return GetElement(_headerName).Text;
        }

        public void EnterPatientName(string name)
        {
            SendKeysWithClear(_patientNameTxtBox, name);
        }
        public void EnterInsuranceId(string id)
        {
            SendKeysWithClear(_insuranceIdTxtBox, id);
        }
        public void EnterReferralDate(string date)
        {
            SendKeysWithClear(_referralReceivedDate, date);
        }
        public void EnterAHI(string ahi)
        {
            SendKeysWithClear(_ahiTxtBox, ahi);
        }
        public void EnterShippedDate(string date)
        {
            SendKeysWithClear(_shippedDate, date);
        }
        public void EnterReturnDate(string date)
        {
            SendKeysWithClear(_returnDate, date);
        }
        public void EnterInterpretDate(string date)
        {
            SendKeysWithClear(_interpretDate, date);
        }

        public void EnterSSN(string ssn)
        {
            SendKeysWithClear(_ssnTxtBox, ssn);
        }
        public void EnterInterpretDateRangeFrom(string date)
        {
            SendKeysWithClear(_interpretDateRangeFrom, date);
        }
        public void EnterInterpretDateRangeTo(string date)
        {
            SendKeysWithClear(_interpretDateRangeTo, date);
        }
        public void EnterPhysicianName(string name)
        {
            SendKeysWithClear(_physicianNameTxtBox, name);
        }
        public void EnterNPI(string npi)
        {
            SendKeysWithClear(_npiTxtBox, npi);
        }
        public void Submit()
        {
            Click(_submitBtn);
        }
        public void Cancel()
        {
            Click(_cancelBtn);
        }

        public void ClickAllRadioBtn()
        {
            Click(_allRadioBtn);
        }
        public void ClickArchivedRadioBtn()
        {
            Click(_archivedRadioBtn);
        }
        public void ClickNonArchivedRadioBtn()
        {
            Click(_nonArchivedRadioBtn);
        }
        public Boolean AreAllTextboxCleared()
        {
            return GetElement(_patientNameTxtBox).GetAttribute("value").Equals("") || GetElement(_ssnTxtBox).GetAttribute("value").Equals("") || GetElement(_interpretDate).GetAttribute("value").Equals("");
        }

        public string GetPagingNumber()
        {
            string pagingNumberInfo = GetElement(_pagingNumberInfo).Text;
            var pagingNumberInfoSplit = pagingNumberInfo.Split(" ");
            var numberOfRecords = pagingNumberInfoSplit[pagingNumberInfoSplit.Length - 2];
            return numberOfRecords;
        }

        public string GetArchiveActionBtnText()
        {
            return GetElement(_archiveActionBtn).Text;
        }

        public void ClickReport()
        {
            Click(_reportActionBtn);
        }

        public string ChooseReport()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            var actualPath = path.Substring(0, path.LastIndexOf("bin", StringComparison.Ordinal));
            var projectPath = new Uri(actualPath).LocalPath;
            var reportPath = projectPath + "\\Data\\TestResults.txt";
            SendKeysWithClear(_fileUpload, reportPath);
            return "TestResults.txt";
        }
        public void Upload()
        {
            Click(_uploadBtn);
        }

        public string GetReportName()
        {
            return GetElement(_reportGridFirstCell).Text;
        }

        public void ClickEdit()
        {
            Click(_editActionBtn);
        }

        public void ClickFax()
        {
            Click(_faxActionBtn);
        }

        public void ClickResendFax()
        {
            Click(_resendFaxBtn);
        }

        public void ClickArchiveActionBtn()
        {
            Click(_archiveActionBtn);
        }

        public void ClickClaimActionBtn()
        {
            Click(_claimActionBtn);
        }

        public void ClickPatientInfoLink()
        {
            Click(_patientInfoLink);
        }

        public void ClickPhysicianInfoLink()
        {
            Click(_physicianInfoLink);
        }

        public string GetPatientFirstNameTextBoxContent()
        {
            return GetElement(_patientFirstNameTxtbox).GetAttribute("value");
        }

        public string GetPhysicianFirstNameTextBoxContent()
        {
            return GetElement(_physicianFirstNameTxtbox).GetAttribute("value");
        }

        public string GetPatientName()
        {
            var fullName = GetElement(_patientInfoLink).Text.Split(" ");
            return fullName[0];
        }

        public string GetPhysicianName()
        {
            var fullName = GetElement(_physicianInfoLink).Text.Split(" ");
            return fullName[0];
        }
    }
}
