using ADSAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ADSAutomation.Pages
{
    public class EnterPatientInformation : Helpers
    {
        private readonly By _ManageTab = By.XPath("//a[text()='Manage']");
        private readonly By _ManagePatient = By.XPath("//a[text()='Manage Patient']");
        private readonly By _EnterPatientInformation = By.XPath("//h4[text()='Enter Patient Information']");
        private readonly By _PatientInformation = By.XPath("//span[text()='Patient Information']");
        private readonly By _FirstName = By.XPath("//p[text()='First Name']//..//input");
        private readonly By _LastName = By.XPath("//p[text()='Last Name']//..//input");
        private readonly By _DOB = By.XPath("//p[text()='DOB']//..//input");
        private readonly By _Gender = By.XPath("//p[text()='Gender']//..//select");
        private readonly By _GenderSelect = By.XPath("//option[text()='Male']");
        private readonly By _PrimaryInsurance = By.XPath("//p[text()='Primary Insurance']//..//select");
        private readonly By _PrimaryInsuranceNo = By.XPath("//p[text()='Primary Insurance No.']//..//input");
        private readonly By _PrimaryInsGroup = By.XPath("//p[text()='Primary Ins. Group']//..//input");
        private readonly By _SecondaryInsurance = By.XPath("//p[text()='Secondary Insurance']//..//select");
        private readonly By _SecondaryInsuranceNo = By.XPath("//p[text()='Secondary Insurance No.']//..//input");
        private readonly By _SecondaryInsGroup = By.XPath("//p[text()='Secondary Ins. Group']//..//input");
        private readonly By _Organization = By.XPath("//p[text()='Organization']//..//select");
        private readonly By _Company = By.XPath("(//p[text()='Company']//..//select)[1]");
        private readonly By _BrightreePatientID = By.XPath("//p[text()='Brightree Patient ID#']//..//input");
        private readonly By _HDMSAccounts = By.XPath("//p[text()='HDMS Account#']//..//input");
        private readonly By _CMDAccount = By.XPath("//p[text()='CMD Acct#(Patient ID#)']//..//input");
        private readonly By _AddCSR = By.Id("btnAddCSR");
        private readonly By _FirstNameCSR = By.XPath("(//td[contains(text(),'First Name')]//..//input)[1]");
        private readonly By _LastNameCSR = By.XPath("(//td[contains(text(),'Last Name')]//..//input)[1]");
        private readonly By _EmailCSR = By.XPath("(//td[contains(text(),'Email Address:')]//..//input)[1]");
        private readonly By _SearchCSR = By.Id("ctl00_ContentPlaceHolder1_btnCSRsearch");
        private readonly By _BillingAddress = By.XPath("//span[text()='Billing Address']");
        private readonly By _Address1 =    By.XPath("(//p[text()='Address1']//..//textarea)[1]");
        private readonly By _Address2 = By.XPath("(//p[text()='Address2']//..//textarea)[1]");
        private readonly By _State = By.XPath("(//p[text()='State']//..//select)[1]");
        private readonly By _City = By.XPath("(//p[text()='City']//..//select)[1]");
        private readonly By _Zip = By.XPath("(//p[text()='Zip']//..//input)[1]");
        private readonly By _Phone = By.XPath("(//p[text()='Phone']//..//input)[1]");
        private readonly By _Cell = By.XPath("(//p[text()='Cell']//..//input)[1]");
        private readonly By _Email1 = By.XPath("(//p[text()='Email1']//..//input)[1]");
        private readonly By _Email2 = By.XPath("(//p[text()='Email2']//..//input)[1]");
        private readonly By _DocumentType = By.Id("ctl00_ContentPlaceHolder1_tabDocument_tabpnlDoc_ddlDocumentType");
        private readonly By _Date = By.Id("ctl00_ContentPlaceHolder1_tabDocument_tabpnlDoc_TxtEnterdDate");
        private readonly By _PrescriptionDate = By.XPath("//p[text()='Prescription Date']//..//input");
        private readonly By _UploadFile = By.Id("ctl00_ContentPlaceHolder1_tabDocument_tabpnlDoc_fileUploadDocument");
        private readonly By _UploadButton = By.Id("ctl00_ContentPlaceHolder1_tabDocument_tabpnlDoc_btnUploadFile");
        private readonly By _HSTInsVerificationtab = By.XPath("//span[text()='HST Ins. Verification']");
        private readonly By _InsuranceName = By.Id("ctl00_ContentPlaceHolder1_tbpatient_tpHSTins_txtInsuranceName");
        private readonly By _PlanType = By.XPath("//p[text()='Plan Type:']//..//input");
        private readonly By _InsurancePhone = By.XPath("//p[text()='Insurance Phone:']//..//input");
        private readonly By _InsuranceFax = By.XPath("//p[text()='Insurance Fax:']//..//input");
        private readonly By _InsRepName = By.XPath("//p[text()='Ins. Rep Name:']//..//input");
        private readonly By _ClaimAddress = By.XPath("//p[text()='Claims Address:']//..//input");
        private readonly By _City_State_Zip = By.XPath("//p[text()='City/State/Zip:']//..//input");
        private readonly By _DeductibleInNetwork = By.XPath("(//p[text()='Deductible:']//..//input)[1]");
        private readonly By _MetInNerwork = By.XPath("(//p[text()='Met:']//..//input)[1]");
        private readonly By _DateVerifiedInNetwork = By.XPath("(//p[text()='Date Verified:']//..//input)[1]");
        private readonly By _AuthorizationRequired = By.Id("ctl00_ContentPlaceHolder1_tbpatient_tpHSTins_radiobtnAuthorizationRequired_0");
        private readonly By _Reference = By.XPath("(//label[text()='Reference#:']//..//input)[1]");
        private readonly By _CoInsurance = By.XPath("(//p[text()='Co-Insurance:']//..//input)[1]");
        private readonly By _SubmitButton = By.XPath("//input[@value='Submit']");
        private readonly By _loadingIcon = By.XPath("//div[@class='loader']");


        public EnterPatientInformation(IWebDriver driver) : base(driver)
        {
            
        }

        public void GotoEnterPatientInformation()
        {
            Click(_ManageTab);
            //Click(_ManagePatient);
            //Thread.Sleep(2);
            Click(_EnterPatientInformation);
        }
        public void clickEnterPatientInformation()
        {
            Click(_EnterPatientInformation);
        }

        public void clickPatienInformationTab()
        {
            Click(_PatientInformation);
        }

        public void enterFirstName(string firstname)
        {
            SendKeys(_FirstName, firstname);
        }

        public void enterLastName(string lastname)
        {
            SendKeys(_LastName, lastname);
        }

        public void enterDOB(string DOB)
        {
            SendKeys(_DOB, DOB);
        }

        public void selectGender(string Gender)
        {
            Click(_Gender);
            string Gender_select = string.Format("//option[text()='{0}']", Gender);
            Click(By.XPath(Gender_select));
        }

        public void selectPrimaryInsurance(string PrimaryInsurance)
        {
            Click(_PrimaryInsurance);
            string PrimaryInsurance_select = string.Format("//option[text()='{0}']", PrimaryInsurance);
            Click(By.XPath(PrimaryInsurance_select));
        }

        public void enterPrimaryInsuranceNo(string PrimaryInsuranceNo)
        {
            SendKeys(_PrimaryInsuranceNo, PrimaryInsuranceNo);
        }

        public void enterPrimaryInsGroup(string PrimaryInsGroup)
        {
            SendKeys(_PrimaryInsGroup, PrimaryInsGroup);
        }

        public void selectSecondaryInsurance(string SecondaryInsurance)
        {
            WaitUntilElementVisible(_SecondaryInsurance);
            Thread.Sleep(5);
            //Click(_SecondaryInsurance);
            SendKeys(_SecondaryInsurance, SecondaryInsurance);
           // string SecondaryInsurance_select = string.Format("(//option[text()='{0}'])[1]", SecondaryInsurance);
            //Click(By.XPath(SecondaryInsurance_select));
        }

        public void enterSecondaryInsuranceNo(string SecondaryInsuranceNo)
        {
            SendKeys(_SecondaryInsuranceNo, SecondaryInsuranceNo);
        }

        public void enterSecondaryInsGroup(string SecondaryInsGroup)
        {
            SendKeys(_SecondaryInsGroup, SecondaryInsGroup);
        }
        public void selectOrganization(string Organization)
        {
            WaitUntilElementVisible(_Organization);
            Click(_Organization);
            string Organization_select = string.Format("//option[text()='{0}']", Organization);
            WaitUntilElementVisible(By.XPath(Organization_select));
            Click(By.XPath(Organization_select));
            Thread.Sleep(2);
        }

        public void selectCompany(string Organization,string Company)
        {
            //string Organization_select = string.Format("//option[text()='{0}']", Organization);
            WaitUntilElementVisible(_Company);
            Explicitwait(_Company);
            //Click(_Company);
            WaitUntilElementVisible(_Company);
            SendKeys(_Company, Company);
            //string Company_select = string.Format("//option[text()='{0}']", Company);
            //Click(By.XPath(Company_select));
        }

        public void enterBrightreePatientID(string BrightreePatientID)
        {
            SendKeys(_BrightreePatientID, BrightreePatientID);
        }

        public void enterHDMSAccount(string HDMSAccount)
        {
            SendKeys(_HDMSAccounts, HDMSAccount);
        }

        public void enterCMDAccount(string CMDAccount)
        {
            SendKeys(_CMDAccount, CMDAccount);
        }

        public void AddCSR(string FirstNameCSR,string LastNameCSR,string Email)
        {
            Click(_AddCSR);
            SendKeys(_FirstNameCSR, FirstNameCSR);
            SendKeys(_LastNameCSR, LastNameCSR);
            SendKeys(_EmailCSR, Email);
            Click(_SearchCSR);
        }
        public void enterAddress1(string Address1)
        {
            SendKeys(_Address1, Address1);
        }

        public void selectState(string State)
        {
            Click(_State);
            Click(By.XPath("(//option[text()='" + State + "'])[1]"));
        }

        public void selectCity(string City)
        {
            Loading(_loadingIcon);
            WaitUntilElementVisible(_City);
            Explicitwait(_City);
            Click(_City);
            SendKeys(_City, City);
        }

        public void enterZip(string Zip)
        {
            SendKeys(_Zip, Zip);
        }

        public void enterPhone(string Phone)
        {
            SendKeys(_Phone, Phone);
        }

        public void enterCell(string Cell)
        {
            SendKeys(_Cell, Cell);
        }

        public void enterEmail1(string Email1)
        {
            SendKeys(_Email1, Email1);
        }

        public void enterEmail2(string Email2)
        {
            SendKeys(_Email2, Email2);
        }
        public void entertheDetailsBillingAddress(string Address1,string Address2,string State,string City,string Zip,string Phone,string Cell,string Email1,string Email2, string FirstNameCSR, string LastNameCSR, string Email)
        {
            SendKeys(_Address1,Address1);
            SendKeys(_Address2, Address2);
            Click(_State);
            Click(By.XPath("(//option[text()='" + State + "'])[1]"));
            Loading(_loadingIcon);
            WaitUntilElementVisible(_City);
            Click(_City);
            SendKeys(_City,City);
            SendKeys(_Zip,Zip);
            SendKeys(_Phone,Phone);
            SendKeys(_Cell, Cell);
            SendKeys(_Email1, Email1);
            SendKeys(_Email2, Email2);
            //AddCSR(FirstNameCSR, LastNameCSR, Email);
        }

        public void detailsPatientDocuments(string DocumentType,string Date,string PrescriptionDate,string FilePath)
        {
            Click(_DocumentType);
            Click(By.XPath("(//option[contains(text(),'" + DocumentType + "')])[1]"));
            SendKeys(_Date, Date);
            
            SendKeys(_PrescriptionDate, PrescriptionDate);
            //SendKeys(_UploadFile, FilePath);
            //Click(_UploadButton);
        }

        public void GotoHSTInsuranceVerification()
        {
            Click(_HSTInsVerificationtab);
        }

        public void detailsOfHSTInsuranceVerifcation(string InsuranceName,string PlanType,string InsurancePhone,string InsuranceFax,string InsRepName,string ClaimAddress,string City,string Deductible,string MetInNetwork,string DateVerification,string Reference,string Coinsurance)
        {
            Click(_HSTInsVerificationtab);
            SendKeys(_InsuranceName, InsuranceName);
            SendKeys(_PlanType, PlanType);
            SendKeys(_InsurancePhone,InsurancePhone);
            SendKeys(_InsuranceFax, InsuranceFax);
            SendKeys(_InsRepName, InsRepName);
            SendKeys(_ClaimAddress, ClaimAddress);
            SendKeys(_City_State_Zip, City);
            SendKeys(_DeductibleInNetwork, Deductible);
            SendKeys(_MetInNerwork, MetInNetwork);
            SendKeys(_DateVerifiedInNetwork, DateVerification);
            Click(_AuthorizationRequired);
            SendKeys(_Reference, Reference);
            SendKeys(_CoInsurance, Coinsurance);
        }

        public void clickSubmitButton()
        {
            Click(_SubmitButton);
        }
    }
}
