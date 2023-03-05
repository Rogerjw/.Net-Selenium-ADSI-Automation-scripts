using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class ManageCompany : Helpers
    {
        private IWebDriver driver;
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _managerCompanySubmenu = By.LinkText("Manage Company");

        public ManageCompany(IWebDriver driver) : base(driver)
        {

        }
        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_managerCompanySubmenu);
        }
        //Company's Information
        private readonly By _companyname = By.Id("ctl00_ContentPlaceHolder1_TxtCompanyName");
        private readonly By _displayname = By.Id("ctl00_ContentPlaceHolder1_txtDisplayName");
        private readonly By _Brightree = By.Id("txtBrightTreeBranchID");
        private readonly By _selectregion = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_ddlRegion']/option[2]");
        private readonly By _selectarea = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_ddlArea']/option[2]");
        private readonly By _selectstate = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_ddlState']/option[2]");
        private readonly By _selectcity = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_ddlCity']/option[2]");
        private readonly By _selectorganization = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_ddlBussinessID']/option[2]");
        private readonly By _fax = By.Id("ctl00_ContentPlaceHolder1_TxtFax");
        private readonly By _phone = By.Id("ctl00_ContentPlaceHolder1_TxtPhone");
        private readonly By _primaryContact = By.Id("ctl00_ContentPlaceHolder1_TxtPrimaryContactNo");
        private readonly By _address1 = By.Id("ctl00_ContentPlaceHolder1_TxtAdd1");
        private readonly By _address2 = By.Id("ctl00_ContentPlaceHolder1_TxtAdd2");
        private readonly By _zipcode = By.Id("ctl00_ContentPlaceHolder1_Txtzipcode");
        private readonly By _email = By.Id("ctl00_ContentPlaceHolder1_TxtEmail");
        private readonly By _officetype = By.Id("ctl00_ContentPlaceHolder1_rbtOfficeType_0");

        //oximetry notifications
        private readonly By _oximetryemail = By.Id("ctl00_ContentPlaceHolder1_ctl00_ctl00_txtOximetryUpdateEmail1");
        private readonly By _hstemail = By.Id("ctl00_ContentPlaceHolder1_ctl00_ctl01_txtHSTNotesEmail1");
        private readonly By _rnotesemail = By.Id("ctl00_ContentPlaceHolder1_ctl00_ctl02_txtRENotesEmail1");
        private readonly By _salesemail = By.Id("ctl00_ContentPlaceHolder1_ctl00_ctl03_txtSalesRepEmail1");

        private readonly By _selectoximetry=By.Id("__tab_ctl00_ContentPlaceHolder1_ctl00_ctl00");
        private readonly By _selecthstnotification=By.Id("__tab_ctl00_ContentPlaceHolder1_ctl00_ctl01");
        private readonly By _selectRenotification=By.Id("__tab_ctl00_ContentPlaceHolder1_ctl00_ctl02");
        private readonly By _selectsalesnotification=By.Id("__tab_ctl00_ContentPlaceHolder1_ctl00_ctl03");

        //Company defaults
        private readonly By _selectoximetryType = By.Id("ctl00_ContentPlaceHolder1_rbtOximeterDeviceType_1");
        private readonly By _selectoximetryreport = By.Id("ctl00_ContentPlaceHolder1_rbtOximetryReportNotification_0");
        private readonly By _selectdocumentuploadnotification = By.Id("ctl00_ContentPlaceHolder1_rbtDocumentUploadNotification_0");
        private readonly By _selectspo2 = By.Id("ctl00_ContentPlaceHolder1_rbtSpO2_0");
        private readonly By _selectemailfornotification = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_ddlAdminEmailList']/option[2]");
        private readonly By _selectOxyEmailNotification = By.Id("ctl00_ContentPlaceHolder1_rbtOximetryEmailNotificationBypass_0");
        private readonly By _selectweb = By.Name("ctl00$ContentPlaceHolder1$company_web_text");
        private readonly By _selectCompanyCodeN = By.Id("ctl00_ContentPlaceHolder1_txtCompanyCode");
        private readonly By _selectHSTmarketing = By.Id("ctl00_ContentPlaceHolder1_rbtHSTMarketing_1");


        private readonly By _submit = By.Id("ctl00_ContentPlaceHolder1_BtnSubmitCompany");
        private readonly By _cancel = By.Id("ctl00_ContentPlaceHolder1_BtnCancelCompany");
        private readonly By _Update = By.Name("ctl00$ContentPlaceHolder1$BtnSubmitCompany");

        //search in the table header
        private readonly By _SearchByCompname = By.Id("gs_CompanyName");
        private readonly By _RequestTxtBox = By.Id("gs_CompanyName");

        public void EnterCompanynameSearch(string compsearch)
        {
            SendKeys(_SearchByCompname, compsearch);
            SendKeys(_RequestTxtBox, Keys.Enter);
        }

        public void EnterWebname(string websitename)
        {
            SendKeys(_selectweb, websitename);
        }
        public void EnterCompCode(string compid)
        {
            SendKeys(_selectCompanyCodeN, compid);
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
            Click(_Update);
        }
        //company defaults click
        public void ClickOximetryType()
        {
            Click(_selectoximetryType);
        }
        public void ClickOximetryReport()
        {
            Click(_selectoximetryreport);
        }
        public void ClickDocumentUp()
        {
            Click(_selectdocumentuploadnotification);
        }
        public void ClickSpo2()
        {
            Click(_selectspo2);
        }
        public void ClickEmailN()
        {
            Click(_selectemailfornotification);
        }
        public void ClickOxyEmail()
        {
            Click(_selectOxyEmailNotification);
        }
        public void ClickWeb()
        {
            Click(_selectweb);
        }
        public void ClickHSTMarketing()
        {
            Click(_selectHSTmarketing);
        }
        public void ChooseFile()
        {
            GetElement(By.Id("ctl00_ContentPlaceHolder1_CompanyLogoUploadCtrl"))
                .SendKeys(@"C:\Users\CTRL-SHIFT Ltd\Pictures\Screenshots\logo.png");

        }
        //oximetry notifications header button click
        public void ClickHstNotifications()
        {
            Click(_selecthstnotification);
        }
        public void ClickRenotifications()
        {
            Click(_selectRenotification);
        }
        public void ClickSalesNotifications()
        {
            Click(_selectsalesnotification);
        }
        //oximrtry input fields
        public void EnterOximetryEmail(string oxiemail)
        {
            SendKeys(_oximetryemail, oxiemail);
        }
        public void EnterHSTmail(string hstemail)
        {
            SendKeys(_hstemail, hstemail);
        }
        public void EnterREemail(string rmail)
        {
            SendKeys(_rnotesemail, rmail);
        }
        public void EnterSalesEmail(string salesemail)
        {
            SendKeys(_salesemail, salesemail);
        }

       //company information fields
        public void EnterCompanyname(string companyname)
        {
            SendKeys(_companyname, companyname);
        }
        public void EnterDisplayname(string displayname)
        {
            SendKeys(_displayname, displayname);
        }
        public void EnterBrightree(string brightree)
        {
            SendKeys(_Brightree, brightree);
        }
        public void EnterFax(string faxname)
        {
            SendKeys(_fax, faxname);
        }
        public void EnterPhone(string phonenumber)
        {
            SendKeys(_phone, phonenumber);
        }
        public void EnterPrimaryContact(string primarycont)
        {
            SendKeys(_primaryContact, primarycont);
        }
        public void EnterAdress1(string adress1)
        {
            SendKeys(_address1, adress1);
        }
        public void EnterAdress2(string adress2)
        {
            SendKeysWithClear(_address2, adress2);
        }
        public void EnterZipcode(string zipcode)
        {
            SendKeys(_zipcode, zipcode);
        }
        public void EnterEmail(string emailid)
        {
            SendKeys(_email, emailid);
        }
        //clicking dropdown list
        public void ClickRegion()
        {
            Click(_selectregion);
        }
        public void ClickArea()
        {
            Click(_selectarea);
        }
        public void ClickState()
        {
            Click(_selectstate);
        }
        public void ClickCity()
        {
            Click(_selectcity);
        }
        public void ClickOrganization()
        {
            Click(_selectorganization);
        }
        public void ClickselectType()
        {
            Click(_officetype);
        }

        public string AlertText()
        {
            return GetAlertText();
        }
        //To verify the create company functionality with valid inputs
        public void ManageCompanyRecord(string compname, string displayname, string bright, string faxname, string phone,
            string primary, string ad1, string ad2, string zip, string emal)
        {
            EnterCompanyname(compname);
            EnterDisplayname(displayname);
            EnterBrightree(bright);
            ClickRegion();
            ClickArea();
            ClickState();
            ClickCity();
            ClickOrganization();
            EnterFax(faxname);
            EnterPhone(phone);
            EnterPrimaryContact(primary);
            EnterAdress1(ad1);
            EnterAdress2(ad2);
            EnterZipcode(zip);
            EnterEmail(emal);
            ClickselectType();

        }

        public void oxmetries(string email)
        {
            EnterOximetryEmail(email);
            ClickHstNotifications();
            EnterHSTmail(email);
            ClickRenotifications();
            EnterREemail(email);
            ClickSalesNotifications();
            EnterSalesEmail(email);
        }

        public void ManageCompanyDefaults(string webnam, string compcode)
        {
            ClickOximetryType();
            ClickOximetryReport();
            ClickDocumentUp();
            ClickSpo2();
            ClickEmailN();
            ClickOxyEmail();
            EnterWebname(webnam);
            ClickWeb();
            ChooseFile();
            EnterCompCode(compcode);
            ClickHSTMarketing();
        }

        //To verify the create company functionality with empty inputs
        public void VerifyEmptySubmission()
        {
            ClickSubmit();
        }

        //To verify that system accepting duplicate company name
        public void ManageDuplicateCompName(string compname)
        {
            EnterCompanyname(compname);
            ClickSubmit();
        }

        //To verify that search functionality in manage company screen
        public void ManageSearchFunctionality(string compnameSearch)
        {
            EnterCompanynameSearch(compnameSearch);
        }

        private readonly By _EditIcon = By.XPath("//*[@id='34']/td[7]/a");
        public void SelectEditIcon()
        {
            Click(_EditIcon);
        }
        //To verify that edit functionality in manage company screen
        public void ManageEditFunctionality( string address2name)
        {
            SelectEditIcon();
            ClickUpdate();
        }
    }
}
