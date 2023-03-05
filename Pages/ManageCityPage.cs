using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    public class ManageCityPage : Helpers
    {
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _manageCitySubmenu = By.LinkText("Manage City");
        private readonly By _submitButton = By.Id("ctl00_ContentPlaceHolder1_BtnSubmitCity");
        private readonly By _dropdown = By.Id("ctl00_ContentPlaceHolder1_ddlState");
        private readonly By _cityNameTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtCityname");
        private readonly By _headerName = By.XPath("//h4[text()='Manage City']");
        private readonly By _cancelButton = By.Id("ctl00_ContentPlaceHolder1_BtnCancelCity");
        private readonly By _editButton = By.Id("ctl00_ContentPlaceHolder1_GrdCity_ctl02_ImgBtnEdit");
        private readonly By _deleteButton = By.Id("ctl00_ContentPlaceHolder1_GrdCity_ctl02_ImgBtnDelete");
        private readonly By _firstCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_GrdCity']/..//tr[2]/td[1]");

        public ManageCityPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSubmit()
        {
            Click(_submitButton);
        }

        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_manageCitySubmenu);
        }

        public string GetHeader()
        {
            return GetElement(_headerName).Text;
        }

        public void EnterCityName(string cityName)
        {
            SendKeysWithClear(_cityNameTxtBox, cityName);
        }

        public void ChooseState(string stateName)
        {
            Click(_dropdown);
            Click(By.XPath($"//option[text()='{stateName}']"));
        }

        public void ClickCancel()
        {
            Click(_cancelButton);
        }

        public string GetTextBoxValue()
        {
            return GetElement(_cityNameTxtBox).GetAttribute("value");
        }

        public void ClickEditButton()
        {
            Click(_editButton);
        }

        public string GetFirstCellCityName()
        {
            return GetElement(_firstCell).Text;
        }
    }
}
