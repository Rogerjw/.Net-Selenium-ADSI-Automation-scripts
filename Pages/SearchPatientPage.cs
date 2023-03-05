using ADSAutomation.Base;
using OpenQA.Selenium;

namespace ADSAutomation.Pages
{
    public class SearchPatientPage : Helpers
    {
        private readonly By _manageTab = By.LinkText("Manage");
        private readonly By _managePatientSubmenu = By.LinkText("Manage Patient");
        private readonly By _searchPatientRecord = By.Id("ctl00_ContentPlaceHolder1_ImgPatRec");
        private readonly By _searchPatientFirstName = By.Id("ctl00_ContentPlaceHolder1_TxtFirstName");
        private readonly By _searchPatientSubmit = By.Id("ctl00_ContentPlaceHolder1_BtnSubmit");
        private readonly By _searchPatientLastname = By.Id("ctl00_ContentPlaceHolder1_TxtLastName");
        private readonly By _searchPatientDOB = By.Id("ctl00_ContentPlaceHolder1_TxtDate");
        private readonly By _searchPatientInsurance = By.Id("ctl00_ContentPlaceHolder1_TxtInsurance");
        private readonly By _searchPatientCancel = By.Id("ctl00_ContentPlaceHolder1_TxtInsurance");
        private readonly By _searchPatientRecords = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_pnlPatientSection']/table");

        public SearchPatientPage(IWebDriver driver) : base(driver)
        {

        }

        public void GoToManagePatient()
        {
            MouseHover(_manageTab);
            Click(_managePatientSubmenu);
        }

        public void ClickSearchPatientRecords()
        {
            Click(_searchPatientRecord);
        }

        public bool VerifySearchPatientRecordsImageDisplayed()
        {            
            return VerifyElementDisplayed(_searchPatientRecord);
        }

        public bool VerifyFirstnameFieldDisplayed()
        {
            return VerifyElementDisplayed(_searchPatientFirstName);
        }

        public void EnterFirstname(string firstname)
        {
            SendKeys(_searchPatientFirstName, firstname);
        }

        public void ClickSubmit()
        {
            Click(_searchPatientSubmit);
        }

        public bool VerifyGivenFirstnameDisplayed(string firstname)
        {
            return VerifyGivenTextPresent(firstname);
        }

        public void EnterLastname(string lastname)
        {
            SendKeys(_searchPatientLastname, lastname);
        }

        public void EnterDOB(string dob)
        {
            SendKeys(_searchPatientDOB, dob);
        }

        public void EnterInsurance(string insurance)
        {
            SendKeys(_searchPatientInsurance, insurance);
        }

        public void ClickCancel()
        {
            Click(_searchPatientCancel);
        }

        public bool VerifyElementText()
        {
            if (GetElement(_searchPatientFirstName).Text.Equals("")) { return true;  } return false;
        }

        public bool VerifySearchResults()
        {
            int count = GetDriver().FindElements(_searchPatientRecords).Count;
            if (count >= 1) { return true; } return false;
        }
    }
}
