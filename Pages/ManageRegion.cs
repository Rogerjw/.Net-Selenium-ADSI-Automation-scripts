using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class ManageRegion : Helpers
    {
        private IWebDriver driver;
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _managerRegionSubmenu = By.LinkText("Manage Region");

        private readonly By _regionname = By.Id("ctl00_ContentPlaceHolder1_TxtRegionName");
        private readonly By _regioncode = By.Id("ctl00_ContentPlaceHolder1_txtRegionCode");
        private readonly By _submit = By.Id("ctl00_ContentPlaceHolder1_BtnSubmitRegion");
        private readonly By _cancel = By.Id("ctl00_ContentPlaceHolder1_BtnCancelRegion");
        private readonly By _update = By.Name("ctl00$ContentPlaceHolder1$BtnSubmitRegion");

        private readonly By _editicon = By.XPath("//*[@id='47']/td[5]/a");

        public ManageRegion(IWebDriver driver) : base(driver)
        {

        }
        public string AlertText()
        {
            return GetAlertText();
        }
        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_managerRegionSubmenu);
        }

        public void EnterRegionname(string regionname)
        {
            SendKeys(_regionname, regionname);
        }

        public void EnterRegioncode(string regioncode)
        {
            SendKeysWithClear(_regioncode, regioncode);
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
        public void ClickEditButton(string regionName)
        {
            Click(By.XPath($"//td[text()='{regionName}']/following-sibling::td/input[1]"));
        }
        //Verify if State is created without any data's provided
        public void SubmitRegionRecord()
        {
            ClickSubmit();
        }

        //Verify Manage Region Functionality by providing only Mandatory Fields ...Verify if Duplicate Region Name is allowed to submit
        public void ManageRegionRecordByRegionName(string regionname)
        {
            EnterRegionname(regionname);
            ClickSubmit();
        }

        //Verify Manage Region Functionality by providing All Fields
        public void ManageRegionRecord(string regionname, string regioncode)
        {
            EnterRegionname(regionname);
            EnterRegioncode(regioncode);
            ClickSubmit();
        }

        //Verify the Cancel button Functionality
        public void ManageRegionRecordCancel(string regionname, string regioncode)
        {
            EnterRegionname(regionname);
            EnterRegioncode(regioncode);
            ClickCancel();
        }

        //Verify the Edit icon Functionality
        public void ManageRegionIconRecord()
        {
            EditButton();
        }

        //Verify the Update Functionality
        public void ManageRegionModifyRecord(string regionname, string regioncode)
        {
            EditButton();
            EnterRegionname(regionname);
            EnterRegioncode(regioncode);
            ClickUpdate();
        }
    }
}
