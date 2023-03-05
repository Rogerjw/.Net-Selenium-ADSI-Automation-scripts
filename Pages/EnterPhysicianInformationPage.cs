using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    public class EnterPhysicianInformationPage : Helpers
    {        
        private readonly By _manageTab = By.LinkText("Manage");
        private readonly By _managePhysicianSubmenuTab = By.LinkText("Manage Physician");
        private readonly By _enterPhysicianInformationImage = By.Id("ctl00_ContentPlaceHolder1_ImgCreatePhysician");
        private readonly By _physicianFirstname = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_TxtFirstName");
        private readonly By _physicianLastname = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_TxtLastName");
        private readonly By _physicianNPI = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_TxtNPI");
        private readonly By _physicianName = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_TxtPhysicianName");
        private readonly By _physicianOrganization = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_DdlBusiness");
        private readonly By _physicianCompany = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_DdlCompany");
        private readonly By _physicianCompanyUsers = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_DDLcompanyusers_list");
        private readonly By _physicianBrightreePhysicianID = By.Id("txtBrightreePhysicianID");
        private readonly By _physicianEmailID = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_TxtEmailID");
        private readonly By _physicianPassword = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_TxtPassWord");
        private readonly By _physicianCMDReferringSequence = By.Id("ctl00_ContentPlaceHolder1_tbPhysician_tpPhysicianInformation_txtCMDReferringSequence");
        private readonly By _physicianAddress1 = By.Id("ctl00_ContentPlaceHolder1_tbContactInformation_tpContactInformation_TxtAddress1");
        private readonly By _physicianAddress2 = By.Id("ctl00_ContentPlaceHolder1_tbContactInformation_tpContactInformation_TxtAddress2");
        private readonly By _physicianState = By.Id("ctl00_ContentPlaceHolder1_tbContactInformation_tpContactInformation_DdlState");
        private readonly By _physicianCity = By.Id("ctl00_ContentPlaceHolder1_tbContactInformation_tpContactInformation_DdlCity");
        private readonly By _physicianZip = By.Id("ctl00_ContentPlaceHolder1_tbContactInformation_tpContactInformation_TxtZip");
        private readonly By _physicianPhone = By.Id("ctl00_ContentPlaceHolder1_tbContactInformation_tpContactInformation_TxtPhone");
        private readonly By _physicianFax = By.Id("ctl00_ContentPlaceHolder1_tbContactInformation_tpContactInformation_TxtFax");
        private readonly By _physicianSubmit = By.Id("ctl00_ContentPlaceHolder1_BtnSave");


        public EnterPhysicianInformationPage(IWebDriver driver) : base(driver)
        {

        }

        public void GoToManagePhysician()
        {
            MouseHover(_manageTab);
            Click(_managePhysicianSubmenuTab);
        }

        public void ClickEnterPhysicianInformationImage()
        {            
            Click(_enterPhysicianInformationImage);
        }

        public void EnterPhysicianFirstName(string firstname)
        {
            SendKeys(_physicianFirstname, firstname);
        }
        public void EnterPhysicianLastName(string lastname)
        {
            SendKeys(_physicianLastname, lastname);
        }

        public void EnterPhysicianNPI(string text)
        {
            SendKeys(_physicianNPI, text);
        }       

        public void SelectOrganization(string text)
        {
            SendKeys(_physicianOrganization, text);
        }

        public void SelectCompany(string text)
        {
            SendKeys(_physicianCompany, text);
        }

        public void SelectCompanyUsers(string text)
        {
            SendKeys(_physicianCompanyUsers, text);
        }

        public void EnterBrightreePhysicianID(string text)
        {
            SendKeys(_physicianBrightreePhysicianID, text);
        }

        public void EnterPhysicianEmailID(string text)
        {
            SendKeys(_physicianEmailID, text);
        }

        public void EnterPhysicianPassword(string text)
        {
            SendKeys(_physicianPassword, text);
        }

        public void EnterPhysicianCMDReferringSequence(string text)
        {
            SendKeys(_physicianCMDReferringSequence, text);
        }

        public void EnterPhysicianAddress1(string text)
        {
            SendKeys(_physicianAddress1, text);
        }

        public void EnterPhysicianAddress2(string text)
        {
            SendKeys(_physicianAddress2, text);
        }

        public void SelectPhysicianState(string text)
        {
            SendKeys(_physicianState, text);
        }

        public void SelectPhysicianCity(string text)
        {
            SendKeys(_physicianCity, text);
        }

        public void EnterPhysicianZip(string text)
        {
            SendKeys(_physicianZip, text);
        }

        public void EnterPhysicianPhone(string text)
        {
            SendKeys(_physicianPhone, text);
        }

        public void EnterPhysicianFax(string text) 
        {
            SendKeys(_physicianFax, text);
        }

        public void ClickSubmit() 
        {
            Click(_physicianSubmit);            
        }
        
        public void SelectOximetryReports(string text)
        {
            Click(By.XPath("//label[text()='"+text+"']/following-sibling::input"));
        }

        public void SelectHSTMarketing(string text)
        {
            Click(By.XPath("//input[contains(@id,'rbtHSTMarketing')]/following-sibling::label[text()='"+text+"']"));
        }

        public void SelectOxygenRx(string text)
        {
            Click(By.XPath("//input[contains(@id,'RadioOxygenRxBtn')]/following-sibling::label[text()='" + text + "']"));
        }

        public void SelectNPVisitReports(string text)
        {
            Click(By.XPath("//input[contains(@id,'rbtNPVisitReports')]/following-sibling::label[text()='" + text + "']"));
        }

        public void SelectReportDelivery(string text)
        {
            Click(By.XPath("//input[contains(@id,'radioisReportDeliverybtn')]/following-sibling::label[text()='" + text + "']"));
        }

        public void SelectOximeterReportLayout(string text)
        {
            Click(By.XPath("//input[contains(@id,'rbtOximeterReportLayout')]/following-sibling::label[text()='"+text+"']"));
        }

        public string AlertText()
        {
            return GetAlertText();
        }

        public string AcceptAlert()
        {
            return AcceptAlert();
        }

        public string GetPhysicianNameText()
        {
            return GetElement(_physicianName).Text;
        }

        public void ClearPhysicianName()
        {
            GetElement(_physicianName).Clear();
        }

        public void ClearEmailID()
        {
            GetElement(_physicianEmailID).Clear();
        }

        public void ClearPhysicianPassword()
        {
            GetElement(_physicianPassword).Clear();
        }
    }
}
