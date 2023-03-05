using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ADSAutomation.Pages
{
    class ManageOrganizationPage : Helpers
    {
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _manageOrganizationSubmenu = By.LinkText("Manage Organization");
        private readonly By _submitButton = By.Id("ctl00_ContentPlaceHolder1_BtnSubmitBussiness");
        private readonly By _headerName = By.XPath("//h4[text()='Manage Organization']");
        private readonly By _organizationTxtBox = By.Id("ctl00_ContentPlaceHolder1_txtbussinessname");
        private readonly By _stateDdl = By.Id("ctl00_ContentPlaceHolder1_ddlState");
        private readonly By _phoneTxtBox = By.Id("ctl00_ContentPlaceHolder1_Txtphone");
        private readonly By _addressTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtAddress");
        private readonly By _urlTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtUrl");
        private readonly By _zipcodeTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtZipcode");
        private readonly By _cityDdl = By.Id("ctl00_ContentPlaceHolder1_ddlcity");
        private readonly By _faxTxtBox = By.Id("ctl00_ContentPlaceHolder1_Txtfax");
        private readonly By _fileUpload = By.Id("ctl00_ContentPlaceHolder1_FileUpload1");
        private readonly By _cancelButton = By.Id("ctl00_ContentPlaceHolder1_BtnCancelBussiness");
        private readonly By _reportHeaderRadioBtn = By.Id("ctl00_ContentPlaceHolder1_reportHeaderForReports_0");
        private readonly By _acronymTxtBox = By.Id("ctl00_ContentPlaceHolder1_txtAcronym");
        private readonly By _brightTreeUserRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbnBrightreeUser_0");
        private readonly By _brightTreeBranchTxtBox = By.Id("txtBrightTreeBranchID");
        private readonly By _dataEntryRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbnDataEntryMethod_0");
        private readonly By _editButton = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqGrdBussiness']/..//tr[2]/td[9]/a");
        private readonly By _firstCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqGrdBussiness']/..//tr[2]/td[2]");

        public ManageOrganizationPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSubmit()
        {
            Click(_submitButton);
        }

        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_manageOrganizationSubmenu);
        }
        public string GetHeader()
        {
            return GetElement(_headerName).Text;
        }

        public void EnterBusiness(string organizationName)
        {
            SendKeysWithClear(_organizationTxtBox, organizationName);
        }

        public void ChooseState(string stateName)
        {
            Click(_stateDdl);
            Click(By.XPath($"//option[text()='{stateName}']"));
        }

        public void ChooseCity(string cityName)
        {
            Click(_cityDdl);
            Click(By.XPath($"//option[text()='{cityName}']"));
        }

        public void EnterPhone(string phoneNumber)
        {
            SendKeysWithClear(_phoneTxtBox, phoneNumber);
        }

        public void EnterAddress(string addressNumber)
        {
            SendKeysWithClear(_addressTxtBox, addressNumber);
        }

        public void EnterUrl(string url)
        {
            SendKeysWithClear(_urlTxtBox, url);
        }

        public void EnterZipcode(string zipcode)
        {
            SendKeysWithClear(_zipcodeTxtBox, zipcode);
        }

        public void EnterFax(string fax)
        {
            SendKeysWithClear(_faxTxtBox, fax);
        }

        public void ChooseLogo()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            var actualPath = path.Substring(0, path.LastIndexOf("bin", StringComparison.Ordinal));
            var projectPath = new Uri(actualPath).LocalPath;
            var reportPath = projectPath + "\\Data\\companyLogo.txt";
            SendKeysWithClear(_fileUpload, reportPath);
        }

        public void ClickCancel()
        {
            Click(_cancelButton);
        }

        public void ChooseReportHeader()
        {
            Click(_reportHeaderRadioBtn);
        }

        public void EnterAcronym(string acronym)
        {
            SendKeysWithClear(_acronymTxtBox, acronym);
        }

        public void ChooseBrightTreeUser()
        {
            Click(_brightTreeUserRadioBtn);
        }

        public void EnterBrightTreeNickname(string nickname)
        {
            SendKeysWithClear(_brightTreeBranchTxtBox, nickname);
        }

        public void ChooseDataEntry()
        {
            Click(_dataEntryRadioBtn);
        }

        public Boolean AreAllTextboxCleared()
        {
            return GetElement(_faxTxtBox).GetAttribute("value").Equals("") || GetElement(_brightTreeBranchTxtBox).GetAttribute("value").Equals("") || GetElement(_organizationTxtBox).GetAttribute("value").Equals("");
        }

        public void ClickEditButton()
        {
            Click(_editButton);
        }

        public string GetBusinessName()
        {
            return GetElement(_firstCell).Text;
        }

        public string GetTextBoxValue()
        {
            return GetElement(_organizationTxtBox).GetAttribute("value");
        }
    }
}
