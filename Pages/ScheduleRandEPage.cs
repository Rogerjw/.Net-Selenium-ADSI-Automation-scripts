using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    public class ScheduleRandEPage : Helpers
    {
        private readonly By _scheduleTab = By.LinkText("Schedule");
        private readonly By _scheduleRandESubmenu = By.LinkText("Schedule R&E");
        private readonly By _patientFirstName = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppatient_TxtFirstName");
        private readonly By _patientLastName = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppatient_TxtLastName");
        private readonly By _patientSubmit = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppatient_BtnSubmit");
        private readonly By _loadingIcon = By.XPath("//div[@class='loader']");
        private readonly By _physicianFirstName = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tpphysician_TextBox1");
        private readonly By _physicianLasstName = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tpphysician_TextBox2");
        private readonly By _physicianSubmit = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tpphysician_btnphysician");
        private readonly By _physicianNext = By.Id("btn_physician_next");
        private readonly By _patientNext = By.Id("btn_patient_next");
        private readonly By _scheduleOxiDiagnosis = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlschedule_imgdiagnosis");
        private readonly By _scheduleOxiDiagnosis1 = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlschedule_ImageButton1");
        private readonly By _scheduleOxiDiagnosis2 = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlschedule_ImageButton2");
        private readonly By _scheduleOxiDiagnosisSubmit = By.Id("btnCancel");
        private readonly By _scheduleOxiRXOnFile = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlschedule_Chkscript");
        private readonly By _scheduleOxiAOBOnFile = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlschedule_chkAOB");
        private readonly By _scheduleOxiRXDate = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlschedule_txtDate");
        private readonly By _scheduleOxiSubmit = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppnlschedule_btnClick");
        private readonly By _scheduleOxiMessage = By.XPath("//div[@class='ui-dialog-content ui-widget-content']");

        public ScheduleRandEPage(IWebDriver driver) : base(driver)
        {

        }

        public bool VerifyElementDisplayed(By by)
        {
            if (GetElement(by).Displayed)
            {
                return true;
            }
            return false;
        }

        public void GoToScheduleRandE()
        {
            MouseHover(_scheduleTab);
            Click(_scheduleRandESubmenu);
        }

        public string SearchPatient(string fname, string lname)
        {
            SendKeys(_patientFirstName, fname);
            SendKeys(_patientLastName, lname);
            Click(_patientSubmit);
            Loading(_loadingIcon);
            return fname;
        }

        public void SelectGivenPatientRecord(string gname)
        {
            Click(By.XPath("//a[text()='" + gname + "']/ancestor::tr[@class='alt']/td[1]/input"));
        }

        public void ClickPatientNext()
        {
            Click(_patientNext);
            Loading(_loadingIcon);
        }

        public void ClickPhysicianNext()
        {
            Click(_physicianNext);
            Loading(_loadingIcon);
        }

        public void SelectPhysician(string fname, string lname)
        {
            SendKeys(_physicianFirstName, fname);
            SendKeys(_physicianLasstName, lname);
            Click(_physicianSubmit);
            Loading(_loadingIcon);
            Click(By.XPath("//a[text()='" + fname + "']/parent::*/parent::*/td/input"));
            Click(_physicianNext);
            Loading(_loadingIcon);
        }

        public void SearchAndSelectDiagnosis(string diagnosis)
        {
            Click(_scheduleOxiDiagnosis);
            PageLoad();
            SwitchToWindow(1);
            Click(By.XPath("//td[text()='" + diagnosis + "']/parent::tr/td/input"));
            Click(_scheduleOxiDiagnosisSubmit);
            SwitchToWindow(0);
        }
        public void SearchAndSelectDiagnosis1(string diagnosis)
        {
            Click(_scheduleOxiDiagnosis1);
            PageLoad();
            SwitchToWindow(1);
            Click(By.XPath("//td[text()='" + diagnosis + "']/parent::tr/td/input"));
            Click(_scheduleOxiDiagnosisSubmit);
            SwitchToWindow(0);
        }
        public void SearchAndSelectDiagnosis2(string diagnosis)
        {
            Click(_scheduleOxiDiagnosis2);
            PageLoad();
            SwitchToWindow(1);
            Click(By.XPath("//td[text()='" + diagnosis + "']/parent::tr/td/input"));
            Click(_scheduleOxiDiagnosisSubmit);
            SwitchToWindow(0);
        }

        public void ChooseRXOnFileCheckbox()
        {
            Click(_scheduleOxiRXOnFile);
        }

        public void ChooseAOBOnFileCheckbox()
        {
            Click(_scheduleOxiAOBOnFile);
        }

        public void EnterRXDate(string rxdate)
        {
            SendKeys(_scheduleOxiRXDate, rxdate);
        }
        public void ClickSubmit()
        {
            Click(_scheduleOxiSubmit);
        }
        public bool VerifyMessage()
        {
            Loading(_loadingIcon);
            if (GetElement(_scheduleOxiMessage).Displayed)
            {
                return true;
            }
            return false;
        }
    }
}
