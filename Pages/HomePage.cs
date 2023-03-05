using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenQA.Selenium.Interactions;
using ADSAutomation.Base;
using System.Threading;

namespace ADSAutomation.Pages
{
    public class HomePage : Helpers
    {
        private readonly By _clickHomeButoon = By.XPath("//a[text()='Home']");
        private readonly By _loadingIcon = By.Id("load_grdPendingReview");
        private readonly By _patientName = By.Id("gs_PatientName");
        private readonly By _companyName = By.Id("gs_CompanyName");
        private readonly By _viewDocument = By.XPath("(//a[@id='lnkViewDocument'])[1]");
        private readonly By _deleteDocument = By.XPath("(//a[text()='Delete'])[1]");
        private readonly By _editRecord = By.XPath("(//a[text()='Edit'])[1]");
        private readonly By _reviewedButton = By.XPath("//span[text()='Reviewed']");
        private readonly By _clickFormDropdown = By.XPath("//select[@id='ddlReviewedMonth']");
        private readonly By _select6MonthOption = By.XPath("//option[text()='6 Months']");
        private readonly By _selectAllOption = By.XPath("//option[text()='All']");
        private readonly By _reviewPatientName = By.XPath("(//input[@name='PatientName'])[2]");
        private readonly By _reviewCompanyName = By.XPath("(//input[@name='CompanyName'])[2]");
        private readonly By _reviewViewDocument = By.XPath("(//a[@id='lnkViewDocument'])[11]");
        private readonly By _reviewEditRecord = By.XPath("(//a[text()='Edit'])[11]");
        private readonly By _closeButton = By.Id("cboxClose");
        private readonly By _callerId = By.Id("txtCallerId");
        private readonly By _receivedDate = By.Id("txtReceivedOn");
        private readonly By _fileName = By.Id("txtFileName");
        private readonly By _adminUser = By.Id("txtAdminUser");
        private readonly By _incPatientName = By.Id("txtIncomingfaxPatientName");
        private readonly By _searchButton = By.Id("btnSubmit");
        private readonly By _viewButton = By.XPath("(//a[text()='View'])[1]");
        private readonly By _yesRadioButton = By.XPath("(//input[@value='Yes'])[11]");
        private readonly By _okButton = By.XPath("//span[text()='Ok']");
        private readonly By _ifrCallerId = By.Id("txtRvdCallerId");
        private readonly By _ifrReceivedDate = By.Id("txtRvdReceivedOn");
        private readonly By _ifrFileName = By.Id("txtRvdFileName");
        private readonly By _ifrAdminUser = By.Id("txtRvdAdminUser");
        private readonly By _ifrPatientName = By.Id("txtIncomingFaxRwPatientName");
        private readonly By _ifrSearchButton = By.Id("btnRvdSearch");
        private readonly By _incomingFaxReviewedButton = By.XPath("//span[text()='Incoming faxes Reviewed']");
        private readonly By _pendingReviewYesClick = By.XPath("(//input[@value='Yes'])[1]");
        private readonly By _closeIcon = By.XPath("//button[text()='close']");
        private readonly By _viewPDFIFRSection = By.XPath("(//a[text()='View'])[11]");
                                    
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        

        public void GoToHomePage()
        {
            Click(_clickHomeButoon);
            Loading(_loadingIcon);

        }

        private void Loading(By loadingIcon)
        {
            throw new NotImplementedException();
        }

        public void ViewPDFIFRSection()
        {
            Click(_viewPDFIFRSection);

        }


        public void LoadingIcon()
        {
            Loading(_loadingIcon);
        }

        public void ClickEnter(IWebDriver driver)
        {
            driver.FindElement(By.XPath("String")).SendKeys(Keys.Enter);
        }

        public void SearchPatientName(string name)
        {
            SendKeys(_patientName, name);

        }

        public void SearchCompanyName(string name)
        {
            SendKeys(_companyName, name);

        }

        public void ViewDocument()
        {
            Click(_viewDocument);
        }
        public void DeleteDocument()
        {
            Click(_deleteDocument);
        }
        public void EditRecord()
        {
            Click(_editRecord);
        }
        public void ClickReviewedButton()
        {
            Click(_reviewedButton);
        }
        public void ClickFormDropDown()
        {
            Click(_clickFormDropdown);
        }
        public void Click6MonthOption()
        {
            Click(_select6MonthOption);
            //Click(_patientName);
        }
        public void ClickAllOption()
        {
            Click(_selectAllOption);
            Loading(_loadingIcon);
        }
        public void SearchPatientNameInReviewedSection(string name)
        {
            SendKeys(_reviewPatientName, name);

        }
        public void SearchCompanyNameInReviewedSection(string name)
        {
            SendKeys(_reviewCompanyName, name);

        }
        public void ReviewdViewDocument()
        {
            Click(_reviewViewDocument);
        }
        public void ReviewdEditRecord()
        {
            Click(_reviewEditRecord);
        }
        public void ClickCloseButton()
        {
            Click(_closeButton);
        }
        public void SendCallerIdData(string callerid)
        {
            SendKeys(_callerId, callerid);
        }
        public void SendReceivedDate(string recdate)
        {
            SendKeys(_receivedDate, recdate);
        }
        public void SendFileName(string filename)
        {
            SendKeys(_fileName, filename);
        }
        public void SendAdminUser(string filename)
        {
            SendKeys(_adminUser, filename);
        }
        public void ClickSearchButton()
        {
            Click(_searchButton);
        }
        public void ViewPdfLink()
        {
            Click(_viewButton);
        }
        public void ClickYesRadioButton()
        {
            Click(_yesRadioButton);
        }
        public void ClickOkButton()
        {
            Click(_okButton);
        }

        public void IFRSendCallerIdData(string callerid)
        {
            SendKeys(_ifrCallerId, callerid);
        }
        public void IFRSendReceivedDate(string recdate)
        {
            SendKeys(_ifrReceivedDate, recdate);
        }
        public void IFRSendFileName(string filename)
        {
            SendKeys(_ifrFileName, filename);
        }
        public void IFRSendAdminUser(string filename)
        {
            SendKeys(_ifrAdminUser, filename);
        }
        public void ClickIFRSearchButton()
        {
            Click(_ifrSearchButton);
        }
        public void ClickIFRButton()
        {
            Click(_incomingFaxReviewedButton);
        }
        public void WaitTillPageLoad()
        {
            Thread.Sleep(2000);
        }
        public void PendingReviewYesClick()
        {
            Click(_pendingReviewYesClick);
        }
        public void ClickCloseIcon()
        {
            Click(_closeIcon);
        }

    }


}
