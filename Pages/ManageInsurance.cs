using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class ManageInsurance : Helpers
    {
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _managerInsuranceSubmenu = By.LinkText("Manage Insurance");

        public ManageInsurance(IWebDriver driver) : base(driver)
        {
        }
        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_managerInsuranceSubmenu);
        }

        //ADSI INFO
        private readonly By _InsuranceType = By.XPath("//*[@id='ddlInsuranceType1']/option[2]");
        private readonly By _InsuranceADS = By.XPath("//*[@id='ddlADSIInsurance1']/option[2]");
        private readonly By _Save = By.Id("ctl00_ContentPlaceHolder1_UpdateADSINumberButton");
        private readonly By _Cancel = By.Id("ctl00_ContentPlaceHolder1_CancelUpdateADSINumberButton");

        //Insurance info
        private readonly By _InsuranceTypeInfo = By.XPath("//*[@id='ddlInsuranceType']/option[3]");
        private readonly By _InsuranceADSI = By.XPath("//*[@id='ddlADSIInsurance']/option[3]");
        private readonly By _InsuranceName = By.Id("TxtInsuranceName");
        private readonly By _CMDSequence = By.Id("TxtCMDSequenceNumber");

        //contact info
        private readonly By _address1 = By.Id("ctl00_ContentPlaceHolder1_TxtAdress1");
        private readonly By _address2 = By.Id("ctl00_ContentPlaceHolder1_TxtAdress2");
        private readonly By _City = By.Id("ctl00_ContentPlaceHolder1_TxtCity");

        //billing info
        private readonly By _OxyPos = By.Id("ctl00_ContentPlaceHolder1_TxtPOSOximetry1");
        private readonly By _HomeTos = By.Id("ctl00_ContentPlaceHolder1_TxtTOSHomeSleep1");

        //edit icon
        private readonly By _EditIcon = By.XPath("//*[@id='9']/td[7]/a");
        private readonly By _Update = By.Id("ctl00_ContentPlaceHolder1_BtnSaveInsurance");
        //primary tab click
        private readonly By _tabprimary = By.Id("__tab_tpPrimary");
        public void ClickPrimaryTab()
        {
            Click(_tabprimary);
        }
        public void ClickEditIcon()
        {
            Click(_EditIcon);
        }
        public void ClickUpdate()
        {
            Click(_Update);
        }

        public void ClickInsuranceType()
        {
            Click(_InsuranceType);
        }
        public void ClickAdsi()
        {
            Click(_InsuranceADS);
        }

        public void ClickSave()
        {
            Click(_Save);
        }
        public void ClickCancel()
        {
            Click(_Cancel);
        }

        public void ClickInsuranceTypeInfo()
        {
            Click(_InsuranceTypeInfo);
        }
        public void ClickInsuranceADSI()
        {
            Click(_InsuranceADSI);
        }
        public void EnterInsuranceName(string insuranceN)
        {
            SendKeysWithClear(_InsuranceName, insuranceN);
        }

        public void EnterInsuranceCMDSequence(string cmdsequence)
        {
            SendKeys(_CMDSequence, cmdsequence);
        }
        //contact info
        public void EnterInsuranceAddress1(string addr1)
        {
            SendKeys(_address1, addr1);
        }
        public void EnterInsuranceAddress2(string addr2)
        {
            SendKeys(_address2, addr2);
        }
        public void EnterInsuranceCity(string cityname)
        {
            SendKeys(_City, cityname);
        }

        //billing info
        public void EnterInsuranceOxymetryPOS(string Oxy)
        {
            SendKeys(_OxyPos, Oxy);
        }
        public void EnterInsuranceHomeTOS(string Hmetos)
        {
            SendKeys(_HomeTos, Hmetos);
        }

        //CALLING FIELDS AND DROP DOWNS
        public void ManageInsuranceADSI()
        {
            ClickInsuranceType();
            ClickAdsi();
        }
        public string AlertText()
        {
            return GetAlertText();
        }
        public void ManageInsuranceInfo(string insurancenme, string cmdsequence)
        {
            ClickInsuranceTypeInfo();
            ClickInsuranceADSI();
            EnterInsuranceName(insurancenme);
            EnterInsuranceCMDSequence(cmdsequence);
        }

        public void ManageContactInfo(string add1, string add2, string cit)
        {
            EnterInsuranceAddress1(add1);
            EnterInsuranceAddress2(add2);
            EnterInsuranceCity(cit);
        }

        public void ManageBillingInfo(string pos, string tos)
        {
            EnterInsuranceOxymetryPOS(pos);
            EnterInsuranceHomeTOS(tos);
        }

        //To verify the add new button ADSI
        private readonly By _addnew = By.Id("ctl00_ContentPlaceHolder1_BtnCreateInsurance");
        private readonly By _newADSI = By.Id("TxtADSIInsurance1");
        private readonly By _newCmdsequence = By.Id("TxtCMDSequenceNumber1");
        private readonly By _newprayername = By.Id("TxtPayerName");
        private readonly By _newrenderingprovider = By.Id("txtRenderingProvider");
        private readonly By _newbillingprovider = By.Id("txtBillingProvider");
        private readonly By _newOfflocation = By.Id("txtOfficeLocation");
        private readonly By _newfacility = By.Id("txtFacility");
        

        public void EnterNewADSI(string ads)
        {
            SendKeys(_newADSI, ads);
        }
        public void EnterCmdsequence(string ads)
        {
            SendKeys(_newCmdsequence, ads);
        }
        public void EnterNewPrayerName(string ads)
        {
            SendKeys(_newprayername, ads);
        }
        public void EnterNewRenderingProvider(string ads)
        {
            SendKeys(_newrenderingprovider, ads);
        }
        public void EnterNewBillingProvider(string ads)
        {
            SendKeys(_newbillingprovider, ads);
        }
        public void EnterNewOfflocation(string ads)
        {
            SendKeys(_newOfflocation, ads);
        }
        public void EnterNewfacility(string ads)
        {
            SendKeys(_newfacility, ads);
        }
        public void ClickNewButton()
        {
            Click(_addnew);
        }
        public void ManageAddNewADSI(string one, string two,string three, string four, string five, string six, string seven)
        {
            ClickInsuranceType();
            ClickNewButton();
            EnterNewADSI(one);
            EnterCmdsequence(two);
            EnterNewPrayerName(three);
            EnterNewRenderingProvider(four);
            EnterNewBillingProvider(five);
            EnterNewOfflocation(six);
            EnterNewfacility(seven);
        }

        public void ManageUpdateValues(string addrr2)
        {
            ClickEditIcon();
            EnterInsuranceAddress2(addrr2);
        }
        //Verify that updated information saved on system
        private readonly By _created = By.XPath("//*[@id='ddlADSIInsurance1']/option[15]");
        public void ClickCreated()
        {
            ClickInsuranceType();
            Click(_created);
        }
    }
}
