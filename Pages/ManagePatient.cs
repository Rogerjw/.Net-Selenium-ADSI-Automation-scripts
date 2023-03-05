using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenQA.Selenium.Interactions;
using ADSAutomation.Base;
using ADSAutomation.TestScripts;
using System.Threading;

namespace ADSAutomation.Pages
{
    public class ManagePatient : Helpers

    {

        private readonly By _clickManage = By.XPath("//a[text()='Manage']");
        private readonly By _manageTab = By.LinkText("Manage");
        private readonly By _clickManagePhysician = By.XPath("//a[text()='Manage Physician']");
        private readonly By _clicksearchPhysician = By.XPath("//h4[text()='Search Physician']");
        private readonly By _firstName = By.Id("gs_Firstname");
        private readonly By _lastName = By.Id("gs_LastName");
        private readonly By _emailId = By.Id("gs_EmailID");
        private readonly By _phone = By.Id("gs_Phone");
        private readonly By _fax = By.Id("gs_Fax");
        private readonly By _city = By.Id("gs_CityName");
        private readonly By _state = By.Id("gs_StateName");
        private readonly By _npi = By.Id("gs_NPI");
        private readonly By _loadingIcon = By.Id("load_grdPendingReview");
        private readonly By _editIcon = By.XPath("(//td[@aria-describedby='ctl00_ContentPlaceHolder1_GrdSearchPhysicians_Edit'])[1]");
        private readonly By _createManagePhysician = By.XPath("//input[@value='Create Physician']");

        //private IWebDriver driver;

        public ManagePatient(IWebDriver driver) : base(driver)
        {

        }
        
        public void ClickManageMenu()
        {
            MouseHover(_manageTab);
            Click(_clickManagePhysician);

        }
        public void LoadingIcon()
        {
            Loading(_loadingIcon);
        }
        public void ClickManagePhysician()
        {
            Click(_clickManagePhysician);
        }
        public void ClickSearchPhysician()
        {
            Click(_clicksearchPhysician);
        }
        public void SearchByFirstName(string fname)
        {
            WaitUntilElementVisible(_firstName);
            SendKeys(_firstName, fname);
        }
        public void SearchByLastName(string lname)
        {
            SendKeys(_lastName, lname);

        }
        public void SearchByEmail(string email)
        {
            SendKeys(_emailId, email);
        }
        public void SearchByPhone(string phone)
        {
            SendKeys(_phone, phone);
        }
        public void SearchByFax(string phone)
        {
            SendKeys(_fax, phone);
        }
        public void SearchByCity(string phone)
        {
            SendKeys(_city, phone);
        }
        public void SearchByState(string phone)
        {
            SendKeys(_state, phone);
        }
        public void SearchByNpi(string phone)
        {
            SendKeys(_npi, phone);
        }
        public void Explicitwait(By by)
        {
            WebDriverWait w = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30));
            w.Until(ExpectedConditions.ElementExists(by));
        }
        public void WaitToClick(string fname, string lname)
        {
            Explicitwait(By.XPath("//td[text()='" + fname + "']//..//td[text()='" + lname + "']"));
        }
        public void ClickEditIcon()
        {
            Click(_editIcon);
        }
        public void LoadPage()
        {
            PageLoad();
        }
        public void WaitLoading(By by)
        {
            new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.InvisibilityOfElementLocated(_editIcon));
        }
        public void WaitTillPageLoad()
        {
            Thread.Sleep(2000);
        }
        public void Elementchecker()
        {
            Explicitwait(_editIcon);
        }
    }

}
