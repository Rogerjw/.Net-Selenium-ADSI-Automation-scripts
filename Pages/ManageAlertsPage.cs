using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class ManageAlertsPage : Helpers
    {
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _manageAlertsSubmenu = By.LinkText("Manage Alerts");
        private readonly By _submitButton = By.Id("ctl00_ContentPlaceHolder1_BtnSubmit");
        private readonly By _headerName = By.XPath("//h4[text()='Manage Alerts']");
        private readonly By _systemStatusRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbSystemStatus_0");
        private readonly By _scheduledUpdateRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbScheduledUpdate_1");
        private readonly By _alertMsgTxtArea = By.Id("ctl00_ContentPlaceHolder1_TxtAlertMsg");
        private readonly By _clearButton = By.Id("ctl00_ContentPlaceHolder1_BtnCancel");
        private readonly By _logoutBtn = By.LinkText("Logout");
        private readonly By _alertMessage = By.Id("ctl00_ContentPlaceHolder1_lblalertmsg");
        private readonly By _logbackin = By.Id("hlLogin");

        public ManageAlertsPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSubmit()
        {
            Click(_submitButton);
        }

        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_manageAlertsSubmenu);
        }

        public string GetHeader()
        {
            return GetElement(_headerName).Text;
        }

        public void ClickClear()
        {
            Click(_clearButton);
        }

        public void EnterAlertMsg(string message)
        {
            SendKeysWithClear(_alertMsgTxtArea, message);
        }

        public void ChooseSystemStatus()
        {
            Click(_systemStatusRadioBtn);
        }

        public void ChooseScheduledUpdate()
        {
            Click(_scheduledUpdateRadioBtn);
        }

        public string GetTextAreaValue()
        {
            return GetElement(_alertMsgTxtArea).GetAttribute("value");
        }


        public void ClickLogout()
        {
            Click(_logoutBtn);
        }

        public string AlertMessage()
        {
            return GetElement(_alertMessage).Text;
        }

        public void LogBackIn()
        {
            Click(_logbackin);
        }
    }
}
