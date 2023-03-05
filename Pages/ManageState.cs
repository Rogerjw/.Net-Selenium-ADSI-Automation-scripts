using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class ManageState: Helpers
    {
        private IWebDriver driver;
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _managerStateSubmenu = By.LinkText("Manage State");

        private readonly By _statename = By.Id("ctl00_ContentPlaceHolder1_TxtStateName");
        private readonly By _statecode = By.Id("ctl00_ContentPlaceHolder1_txtStateCode");
        private readonly By _submit = By.Id("ctl00_ContentPlaceHolder1_BtnSubmitState");
        private readonly By _cancel = By.Id("ctl00_ContentPlaceHolder1_BtnCancelState");
        private readonly By _update = By.Id("ctl00_ContentPlaceHolder1_BtnSubmitState");

        private readonly By _editicon = By.Id("ctl00_ContentPlaceHolder1_GrdState_ctl03_ImgBtnEdit");

        public ManageState(IWebDriver driver) : base(driver)
        {

        }
        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_managerStateSubmenu);
        }

        public void EnterStatename(string statename)
        {
            SendKeys(_statename, statename);
        }

        public void EnterStatecode(string statecode)
        {
            SendKeysWithClear(_statecode, statecode);
        }

        public void ClickCancel()
        {
            Click(_cancel);
        }
        public void ClickSubmit()
        {
            Click(_submit);
        }
        public void ClickUpdate()
        {
            Click(_update);
        }
        public void EditButton()
        {
            Click(_editicon);
        }
        public void ClickEditButton(string stateName)
        {
            Click(By.XPath($"//td[text()='{stateName}']/following-sibling::td/input[1]"));
        }
        public string GetStateCode(string stateName)
        {
            return GetElement(By.XPath($"//td[text()='{stateName}']")).Text;
        }

        public string GetTextBoxValue()
        {
            return GetElement(_stateCodeTxtBox).GetAttribute("value");
        }
        private readonly By _stateCodeTxtBox = By.Id("ctl00_ContentPlaceHolder1_txtStateCode");
        //Check the Empty Submit Validation
        public void SubmitStateRecord()
        {
            ClickSubmit();
        }

        //Check the Manage State Functionality by entering state name only.
        public void ManageStateRecordByStateName(string statename)
        {
            EnterStatename(statename);
            ClickSubmit();
        }

        //Verify Manage State Functionality by providing All Fields
        public void ManageStateRecord(string statename, string statecode)
        {
            EnterStatename(statename);
            EnterStatecode(statecode);
            ClickSubmit();
        }
        public string AlertText()
        {
            return GetAlertText();
        }
        //Verify the Cancel button Functionality
        public void ManageStateRecordCancelButton(string statename, string statecode)
        {
            EnterStatename(statename);
            EnterStatecode(statecode);
            ClickCancel();
        }

        //Verify the Edit icon Functionality ... Verify the Update Functionality
        public void ManageStateRecordEdit(string statecode)
        {
            EditButton();
            EnterStatecode(statecode);
            ClickUpdate();
        }
    }
}
