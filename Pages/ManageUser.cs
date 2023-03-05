using ADSAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    public class ManageUser: Helpers
    {
        //WebDriver d = new FirefoxDriver();
        //WebElement browse = d.findElement(By.Id("ctl00_ContentPlaceHolder1_fileUploadDocument"));
        //browse.sendKeys("C:\Users\CTRL-SHIFT Ltd\Pictures\ScreenshotsScreenshot(88).png");
        
        private IWebDriver driver;
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _managerUserSubmenu = By.LinkText("Manage User");
        private readonly By _headerName = By.XPath("//h4[text()='Manage User']");

        private readonly By _firstname = By.Id("TxtFirstName");
        private readonly By _lastname = By.Id("TxtLastName");
        private readonly By _middlename= By.Id("ctl00_ContentPlaceHolder1_TxtMiddleName");
        private readonly By _password = By.Id("ctl00_ContentPlaceHolder1_TxtPassWord");
        private readonly By _username = By.Id("TxtUserName");

        //selecting drop down lists
        private readonly By _selectrole = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_DdlRole']/option[3]");
        private readonly By _selectrole2 = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_DdlRole']/option[10]");
        private readonly By _selectOrg = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_DdlBusiness']/option[2]");
        private readonly By _selectorganization = By.Id("ctl00_ContentPlaceHolder1_DdlBusiness");
        private readonly By _selectcompany = By.Id("ctl00_ContentPlaceHolder1_DdlCompany");
        private readonly By _phone = By.Id("ctl00_ContentPlaceHolder1_TxtPhone");
        private readonly By _fax = By.Id("ctl00_ContentPlaceHolder1_TxtFax");
        private readonly By _pin = By.Id("ctl00_ContentPlaceHolder1_TxtPin");
        private readonly By _userid = By.Id("ctl00_ContentPlaceHolder1_TxtEmail");

        private readonly By _selecttype = By.XPath("//*[@id='ctl00_ContentPlaceHolder1_ddlType']/option[2]");
        private readonly By _uploadsiganture = By.Id("ctl00_ContentPlaceHolder1_fileUploadDocument");

        private readonly By _checkSubAdmin = By.Id("ctl00_ContentPlaceHolder1_ChkIsSubAdmin");
        private readonly By _cancel = By.Id("ctl00_ContentPlaceHolder1_BtnCancel"); 
        private readonly By _submit = By.Id("ctl00_ContentPlaceHolder1_BtnSubmit");


        public ManageUser(IWebDriver driver) : base(driver)
        {

        }
        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_managerUserSubmenu);
            PageLoad();
        }
        public void GoToAdmin2()
        {
            MouseHover(_adminTab);
            Click(_managerUserSubmenu);
        }
        public string GetHeader()
        {
            return GetElement(_headerName).Text;
        }
        public void CreateUser()
        {
            MouseHover(_adminTab);
            Click(_managerUserSubmenu);
        }

        public void EnterFirstname(string firstname)
        {
            SendKeys(_firstname, firstname);
        }

        public void EnterLastname(string lastname)
        {
            SendKeys(_lastname, lastname);
        }

        public void EnterMiddlename(string midname)
        {
            SendKeys(_middlename, midname);
        }

        public void EnterPassword(string password)
        {
            SendKeys(_password, password);
        }

        public void EnterUsername(string username)
        {
            SendKeys(_username, username);
        }

        public void EnterPhone(string phone)
        {
            SendKeys(_phone, phone);
        }

        public void EnterFax(string fax)
        {
            SendKeys(_fax, fax);
        }

        public void EnterUserid(string email)
        {
            SendKeys(_userid, email);
        }

        public void UploadSignature()
        {
            //IWebElement element = driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_fileUploadDocument"));
            //element.SendKeys(@"D:\blog.txt");
            GetElement(By.Id("ctl00_ContentPlaceHolder1_fileUploadDocument")).
                SendKeys(@"C:\Users\CTRL-SHIFT Ltd\Pictures\Screenshots\logo.png");

        }
        public void ChooseFile()
        {
            UploadSignature();
        }
        //clicking dropdown list
        public void ClickRole()
        {
            Click(_selectrole);
        }
        public void ClickRole2()
        {
            Click(_selectrole2);
        }
        public void ClickOrganization()
        {
            Click(_selectOrg);
        }

        public void ClickType()
        {
            Click(_selecttype);
        }
        public void ClickSubmodule()
        {
            Click(_checkSubAdmin);
        }
        public void ClickCancel()
        {
            Click(_cancel);
        }
        public void ClickSubmit()
        {
            Click(_submit);
        }
        public void ManageUserCreation(string firstname, string lastname, string mid, string pass,string
            phone, string fax, string email)
        {
            EnterFirstname(firstname);
            EnterLastname(lastname);
            EnterMiddlename(mid);
            EnterPassword(pass);
            ClickRole();
            EnterPhone(phone);
            EnterFax(fax);
            EnterUserid(email);
            ClickType();
            ClickSubmodule();
            UploadSignature();
            ClickSubmit();
        }
        public void ManageUserFirstname(string lastname, string mid, string pass, string
            phone, string fax, string email)
        {
            EnterLastname(lastname);
            EnterMiddlename(mid);
            EnterPassword(pass);
            ClickRole();
            EnterPhone(phone);
            EnterFax(fax);
            EnterUserid(email);
            ClickType();
            ClickSubmodule();
            ClickSubmit();
        }

        public void ManageUserPassword(string firstname,string lastname, string mid,string
            phone, string fax, string email)
        {
            EnterFirstname(firstname);
            EnterLastname(lastname);
            EnterMiddlename(mid);
            ClickRole();
            EnterPhone(phone);
            EnterFax(fax);
            EnterUserid(email);
            ClickType();
            ClickSubmodule();
            ClickSubmit();
        }

        public void ManageUserRole(string firstname, string lastname, string mid,string pass,string
            phone, string fax, string email)
        {
            EnterFirstname(firstname);
            EnterLastname(lastname);
            EnterMiddlename(mid);
            EnterPassword(pass);
            EnterPhone(phone);
            EnterFax(fax);
            EnterUserid(email);
            ClickType();
            ClickSubmodule();
            ClickSubmit();
        }

        public void ManageOrganization(string firstname, string lastname, string mid, string pass,string
            phone, string fax, string email)
        {
            EnterFirstname(firstname);
            EnterLastname(lastname);
            EnterMiddlename(mid);
            EnterPassword(pass);
            ClickRole();
            EnterPhone(phone);
            EnterFax(fax);
            EnterUserid(email);
            ClickType();
            ClickSubmodule();
            ClickSubmit();
        }

        public void ManagePhone(string firstname, string lastname, string mid, string pass,string fax, string email)
        {
            EnterFirstname(firstname);
            EnterLastname(lastname);
            EnterMiddlename(mid);
            EnterPassword(pass);
            ClickRole();
            EnterFax(fax);
            EnterUserid(email);
            ClickType();
            ClickSubmodule();
            ClickSubmit();
        }
        public string AlertText()
        {
            return GetAlertText();
        }
        public void ManageEmail(string firstname, string lastname, string mid, string pass, string user, string
            phone, string fax)
        {
            EnterFirstname(firstname);
            EnterLastname(lastname);
            EnterMiddlename(mid);
            EnterPassword(pass);
            ClickRole();
            EnterPhone(phone);
            EnterFax(fax);
            ClickType();
            ClickSubmodule();
            ChooseFile();
            ClickSubmit();
        }

        public void ManageCancelButton()
        {
            ClickCancel();
        }
        public void Selectfile()
        {
            ClickType();
        }
        public bool VerifyGivenSearchnameDisplayed(string searchname)
        {
            return VerifyGivenTextPresent(searchname);
        }
        //To verify user is able to search the record using UserName in table
        private readonly By _searchusername = By.Id("gs_UserName"); 
        private readonly By _RequestTxtBoxname = By.Id("gs_UserName");

        public void EnterSearchName(string uname)
        {
            SendKeys(_searchusername, uname);
            SendKeys(_searchusername, Keys.Enter);
        }

        public void ClickSearchName(string uname)
        {
            SendKeys(_RequestTxtBoxname, Keys.Enter);
        }
        public void searchByUsername(string usern)
        {
            EnterSearchName(usern);
        }

        //search by role name
        private readonly By _searchuserRole = By.Id("gs_RoleName");
        private readonly By _RequestTxtBoxrole = By.Id("gs_RoleName");

        public void Searchrole(string rolename)
        {
            SendKeys(_searchuserRole, rolename);
            SendKeys(_RequestTxtBoxrole, Keys.Enter);
        }
        public void searchByUserRole(string userr)
        {
            Searchrole(userr);
        }

        //search by email
        private readonly By _searchuseremail = By.Id("gs_Email");
        private readonly By _RequestTxtBoxemail = By.Id("gs_Email");

        public void Searchemail(string mail)
        {
            SendKeys(_searchuseremail, mail);
            SendKeys(_RequestTxtBoxemail, Keys.Enter);
        }
        public void searchByUserEmail(string userr)
        {
            Searchemail(userr);
        }

        //search by company name
        private readonly By _searchusercompany = By.Id("gs_CompanyName");
        private readonly By _RequestTxtBox = By.Name("CompanyName");

        public void Searchcompany(string comp)
        {
            SendKeys(_searchusercompany, comp);
            SendKeys(_RequestTxtBox, Keys.Enter);
        }
        public void searchByUserCompany(string userr)
        {
            Searchcompany(userr);
        }
        public void ScrollCompName()
        {
            ScrollToElement(_searchusercompany);
        }

        public void ScrollUserName()
        {
            ScrollToElement(_searchusername);
        }
        //search by phone number
        private readonly By _searchuserPhone = By.Id("gs_Phone");
        private readonly By _RequestTxtBoxPhon = By.Id("gs_Phone");

        public void Searchphone(string phon)
        {
            SendKeys(_searchuserPhone, phon);
            SendKeys(_RequestTxtBoxPhon, Keys.Enter);
        }
        public void searchByUserPhone(string userr)
        {
            Searchphone(userr);
        }
        private readonly By _clickupdate=By.Id("ctl00_ContentPlaceHolder1_BtnSubmit");
        public void ClickUpdate()
        {
            Click(_clickupdate);
        }

        //To verify user able to edit the existing user 
        private readonly By _Edituserinfo = By.XPath("//*[@id='1868']/td[8]/a/img");
        private readonly By _Edituser= By.XPath("//*[@id='1874']/td[8]/a");
        public void EnterPassUpdt(string pass)
        {
            SendKeysWithClear(_password, pass);
        }
        public void ClickEditIcon()
        {
            Click(_Edituser);
        }
        public void UpdateUserDetails()
        {
            Click(_Edituserinfo);
            ClickRole();
            ClickType();
            ClickSubmodule();
            UploadSignature();
        }
        private readonly By _loadingIcon = By.XPath("//div[@class='loader']");
        public void awaitElement()
        {
            Loading(_loadingIcon);
            //WaitUntilElementVisible(_exportExcel);
        }
        //To verify user is able to export and download the all records in Excel sheet
        private readonly By _exportExcel = By.Name("ctl00$ContentPlaceHolder1$export_to_excel_btn");
        public void ClickExportToExcel()
        {
            ClickUsingJS(_exportExcel);
            
        }

        public void GotoScroll()
        {
            ScrollToElement(_exportExcel);


        }

    }
}
