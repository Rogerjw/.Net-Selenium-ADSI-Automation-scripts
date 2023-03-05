using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    class EmployeeRequestPage : Helpers
    {
        private readonly By _submitButton = By.Id("ctl00_ContentPlaceHolder1_BtnSubmit");
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _employeeRequestSubmenu = By.LinkText("Employee Request");
        private readonly By _headerName = By.XPath("//h4[text()='Employee Request']");
        private readonly By _requestReasonRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbRequestReason_2");
        private readonly By _startDate = By.Id("ctl00_ContentPlaceHolder1_txtStartDate");
        private readonly By _endDate = By.Id("ctl00_ContentPlaceHolder1_txtEndDate");
        private readonly By _lateArrivalDate = By.Id("ctl00_ContentPlaceHolder1_txtLateArrivalDate");
        private readonly By _arrivalTime = By.Id("ctl00_ContentPlaceHolder1_txtLateArrivalTime");
        private readonly By _earlyDismissalDate = By.Id("ctl00_ContentPlaceHolder1_txtEarlyDismissalDate");
        private readonly By _departingTime = By.Id("ctl00_ContentPlaceHolder1_txtDepartingTime");
        private readonly By _otherAppointmentDate = By.Id("ctl00_ContentPlaceHolder1_txtOtherAppointmentDate");
        private readonly By _otherAppointmentTime = By.Id("ctl00_ContentPlaceHolder1_txtOtherAppointmentTime");
        private readonly By _returnTime = By.Id("ctl00_ContentPlaceHolder1_txtReturnTime");
        private readonly By _otherRequestReasonRadioBtn = By.Id("ctl00_ContentPlaceHolder1_rbOtherReason_0");
        private readonly By _editButton = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqEmployeeRequest']/..//tr[2]/td[8]/a");
        private readonly By _firstCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqEmployeeRequest']/..//tr[2]/td[2]");
        private readonly By _secondCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqEmployeeRequest']/..//tr[2]/td[3]");
        private readonly By _thirdCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqEmployeeRequest']/..//tr[2]/td[4]");
        private readonly By _fourthCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqEmployeeRequest']/..//tr[2]/td[5]");
        private readonly By _sixthCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_jqEmployeeRequest']/..//tr[2]/td[7]");
        private readonly By _fnameLabel = By.Id("ctl00_ContentPlaceHolder1_lblFirstName");
        private readonly By _gridfnameTxtBox = By.Id("gs_FirstName");
        private readonly By _gridlnameTxtBox = By.Id("gs_LastName");
        private readonly By _gridRequestReasonTxtBox = By.Id("gs_RequestedReason");
        private readonly By _gridOtherRequestReasonTxtBox = By.Id("gs_OtherRequestedReason"); 
        private readonly By _gridOtherApproveStatusTxtBox = By.Id("gs_ApproveStatus");
        private readonly By _gridPagingNumberInfo = By.ClassName("ui-paging-info");
        private readonly By _logbackin = By.Id("hlLogin");
        private readonly By _logoutBtn = By.LinkText("Logout");

        public EmployeeRequestPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSubmit()
        {
            Click(_submitButton);
        }

        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_employeeRequestSubmenu);
        }

        public string GetHeader()
        {
            return GetElement(_headerName).Text;
        }

        public void ChooseRequestReason()
        {
            Click(_requestReasonRadioBtn);
        }

        public void SelectStartDate(string startDate)
        {
            SendKeysWithClear(_startDate, startDate);
        }

        public void SelectEndDate(string endDate)
        {
            SendKeysWithClear(_endDate, endDate);
        }
        public void SelectLateArrivalDate(string lateArrivalDate)
        {
            SendKeysWithClear(_lateArrivalDate, lateArrivalDate);
        }

        public void SelectArrivalTime(string arrivalTime)
        {
            SendKeysWithClear(_arrivalTime, arrivalTime);
        }

        public void SelectEarlyDismissalDate(string earlyDismissalDate)
        {
            SendKeysWithClear(_earlyDismissalDate, earlyDismissalDate);
        }

        public void SelectDepartingTime(string departingTime)
        {
            SendKeysWithClear(_departingTime, departingTime);
        }

        public void SelectOtherAppointmentDate(string otherAppointmentDate)
        {
            SendKeysWithClear(_otherAppointmentDate, otherAppointmentDate);
        }

        public void SelectOtherAppointmentTime(string otherAppointmentTime)
        {
            SendKeysWithClear(_otherAppointmentTime, otherAppointmentTime);
        }

        public void SelectReturnTime(string returnTime)
        {
            SendKeysWithClear(_returnTime, returnTime);
        }

        public void ChooseOtherRequestReason()
        {
            Click(_otherRequestReasonRadioBtn);
        }

        public void ClickEditButton()
        {
            Click(_editButton);
        }

        public string AlertText()
        {
            return GetAlertText();
        }
        public string GetNames()
        {
            return GetElement(_fnameLabel).Text;
        }

        public string GetFirstCell()
        {
            return GetElement(_firstCell).Text;
        }

        public string GetSecondCell()
        {
            return GetElement(_secondCell).Text;
        }

        public string GetThirdCell()
        {
            return GetElement(_thirdCell).Text;
        }

        public string GetFourthCell()
        {
            return GetElement(_fourthCell).Text;
        }

        public string GetSixthCell()
        {
            return GetElement(_sixthCell).Text;
        }

        public string GetFirstTwoCells()
        {
            return GetFirstCell() + " " + GetSecondCell();
        }

        public void SearchFirstName(string firstName)
        {
            SendKeysWithClear(_gridfnameTxtBox, firstName);
            SendKeys(_gridRequestReasonTxtBox, Keys.Enter);
        }

        public void SearchLastName(string lastName)
        {
            SendKeysWithClear(_gridlnameTxtBox, lastName);
            SendKeys(_gridRequestReasonTxtBox, Keys.Enter);
        }

        public void SearchRequestReason(string requestReason)
        {
            SendKeysWithClear(_gridRequestReasonTxtBox, requestReason);
            SendKeys(_gridRequestReasonTxtBox, Keys.Enter);
        }

        public void SearchOtherRequestReason(string otherRequestReason)
        {
            SendKeysWithClear(_gridOtherRequestReasonTxtBox, otherRequestReason);
            SendKeys(_gridOtherRequestReasonTxtBox, Keys.Enter);
        }

        public void SearchApproveStatus(string status)
        {
            SendKeysWithClear(_gridOtherApproveStatusTxtBox, status);
            SendKeys(_gridOtherApproveStatusTxtBox, Keys.Enter);
        }

        public int GetPagingNumber()
        {
            string pagingNumberInfo = GetElement(_gridPagingNumberInfo).Text;
            var pagingNumberInfoSplit = pagingNumberInfo.Split(" ");
            var numberOfRecords = pagingNumberInfoSplit[pagingNumberInfoSplit.Length - 1];
            return Int32.Parse(numberOfRecords);
        }

        public void ClickLogout()
        {
            Click(_logoutBtn);
        }
    }
}
