using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class ManageAreaPage : Helpers
    {
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _manageAreaSubmenu = By.LinkText("Manage Area");
        private readonly By _submitButton = By.Id("ctl00_ContentPlaceHolder1_BtnSubmitArea");
        private readonly By _headerName = By.XPath("//h4[text()='Manage Area']");
        private readonly By _dropdown = By.Id("ctl00_ContentPlaceHolder1_ddlRegion");
        private readonly By _areaNameTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtAreaName");
        private readonly By _areaCodeTxtBox = By.Id("ctl00_ContentPlaceHolder1_txtAreaCode"); 
        private readonly By _cancelButton = By.Id("ctl00_ContentPlaceHolder1_BtnCancelArea");
        private readonly By _editButton = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqGrdArea']/..//tr[2]/td[6]/a");
        private readonly By _secondCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqGrdArea']/..//tr[2]/td[3]");

        public ManageAreaPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSubmit()
        {
            Click(_submitButton);
        }

        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_manageAreaSubmenu);
        }

        public string GetHeader()
        {
            return GetElement(_headerName).Text;
        }

        public void ChooseRegion(string regionName)
        {
            Click(_dropdown);
            Click(By.XPath($"//option[text()='{regionName}']"));
        }

        public void EnterAreaName(string areaName)
        {
            SendKeysWithClear(_areaNameTxtBox, areaName);
        }

        public void EnterAreaCodeName(string areaCode)
        {
            SendKeysWithClear(_areaCodeTxtBox, areaCode);
        }

        public void ClickCancel()
        {
            Click(_cancelButton);
        }

        public string GetTextBoxValue()
        {
            return GetElement(_areaNameTxtBox).GetAttribute("value");
        }

        public void ClickEditButton()
        {
            Click(_editButton); 
        }

        public string GetSecondCellAreaName()
        {
            return GetElement(_secondCell).Text;
        }

    }
}
