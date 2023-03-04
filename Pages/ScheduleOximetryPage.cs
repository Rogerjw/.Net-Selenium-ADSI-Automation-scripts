using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    public class ScheduleOximetryPage : Helpers
    {
        private readonly By _scheduleTab = By.LinkText("Schedule"); 
        private readonly By _scheduleOximetrySubmenu = By.LinkText("Schedule Oximetry");
        private readonly By _patientFirstName = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppatient_TxtFirstName");
        private readonly By _patientLastName = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppatient_TxtLastName");
        private readonly By _patientSubmit = By.Id("ctl00_ContentPlaceHolder1_tbschedule_tppatient_BtnSubmit");

        public ScheduleOximetryPage(IWebDriver driver) : base(driver)
        {

        }

        public void GoToScheduleOximetry()
        {
            MouseHover(_scheduleTab);
            Click(_scheduleOximetrySubmenu);
        }

        public void SearchPatient(string fname, string lname)
        {
            SendKeys(_patientFirstName, fname);
            SendKeys(_patientFirstName, lname);
            Click(_patientSubmit);
        }

        public void SelectGivenPatientRecord()
        {            
            Click(_patientSubmit);
        }

    }
}
