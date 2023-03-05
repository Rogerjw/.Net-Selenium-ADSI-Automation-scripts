using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class RestoreSessionPage : Helpers
    {
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _restoreSessionSubmenu = By.LinkText("Restore Session");
        private readonly By _headerName = By.XPath("//h4[text()='Restore CMS50F Upload failed sessions']");
        private readonly By _fnameTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtFirstName");
        private readonly By _lnameTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtLastName");
        private readonly By _dobTxtbox = By.Id("ctl00_ContentPlaceHolder1_TxtDate");
        private readonly By _physicianNameTxtbox = By.Id("ctl00_ContentPlaceHolder1_TxtPhyName");
        private readonly By _submitButton = By.Id("ctl00_ContentPlaceHolder1_BtnSubmit");
        private readonly By _viewSessionsButton = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_grdRestoreSessions']/..//tr[2]/td[7]/a");
        private readonly By _restoreSessionsButton = By.Id("btnRestoreSessions");

        public RestoreSessionPage(IWebDriver driver) : base(driver)
        {
        }
        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_restoreSessionSubmenu);
        }
        public string GetHeader()
        {
            return GetElement(_headerName).Text;
        }

        public void EnterFirstname(string firstName)
        {
            SendKeysWithClear(_fnameTxtBox, firstName);
        }

        public void EnterLastName(string lastName)
        {
            SendKeysWithClear(_lnameTxtBox, lastName);
        }

        public void EnterDOB(string date)
        {
            SendKeysWithClear(_dobTxtbox, date);
        }

        public void EnterPhysicianName(string physicianName)
        {
            SendKeysWithClear(_physicianNameTxtbox, physicianName);
        }

        public void ClickSubmit()
        {
            Click(_submitButton);
        }

        public void ClickViewSessions()
        {
            Click(_viewSessionsButton);
        }

        public void ClickRestoreSessions()
        {
            Click(_restoreSessionsButton);
        }

        public string AlertText()
        {
            return GetAlertText();
        }
    }
}
