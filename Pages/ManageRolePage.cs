using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    public class ManageRolePage : Helpers
    {
        private readonly By _adminTab = By.LinkText("Admin");
        private readonly By _manageRolesSubmenu = By.LinkText("Manage Roles");
        private readonly By _manageRolesHeader = By.XPath("//h4[text()='Manage Roles']");
        private readonly By _submitButton = By.Name("ctl00$ContentPlaceHolder1$BtnSubmit");
        private readonly By _roleNameTxtBox = By.Id("ctl00_ContentPlaceHolder1_TxtRoleName");
        private readonly By _chkSelectAllEdit = By.Id("ctl00_ContentPlaceHolder1_GrdMenuItem_ctl01_chkSelectAllEdit");
        private readonly By _chkSelectAllUpload = By.Id("ctl00_ContentPlaceHolder1_GrdMenuItem_ctl01_chkSelectAllUpload");
        private readonly By _chkSelectAllViewRpt = By.Id("ctl00_ContentPlaceHolder1_GrdMenuItem_ctl01_chkSelectAllViewRpt");
        private readonly By _chkSelectAllDelete = By.Id("ctl00_ContentPlaceHolder1_GrdMenuItem_ctl01_chkSelectAllDelete");
        private readonly By _radiobtnManagerType = By.Id("ctl00_ContentPlaceHolder1_RadBtnLstManagerType_0");
        private readonly By _cancelButton = By.Id("ctl00_ContentPlaceHolder1_BtnCancel");
        private readonly By _editButton = By.Id("ctl00_ContentPlaceHolder1_GrdRoles_ctl02_ImgBtnEdit");
        private readonly By _deleteButton = By.Id("ctl00_ContentPlaceHolder1_GrdRoles_ctl02_ImgBtnDelete");
        private readonly By _firstCell = By.XPath("//table[@id='ctl00_ContentPlaceHolder1_GrdRoles']/..//tr[2]/td[1]");
        private readonly By _typeRadioButton = By.Id("ctl00_ContentPlaceHolder1_RadBtnLstManagerType_2");

        public ManageRolePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToAdmin()
        {
            MouseHover(_adminTab);
            Click(_manageRolesSubmenu);
        }

        public string GetHeader()
        {
            return GetElement(By.XPath("//h4[text()='Manage Roles']")).Text;
        }

        public void GoToSubmit()
        {
            Click(_submitButton); 
        }

        public string GetFirstCell()
        {
            return GetElement(_firstCell).Text;
        }

        public void EnterRoleName(string roleName)
        {
            SendKeysWithClear(_roleNameTxtBox, roleName);
        }

        public void SelectAllFields()
        {
            Click(_radiobtnManagerType);
            Click(_chkSelectAllEdit);
            Click(_chkSelectAllUpload);
            Click(_chkSelectAllViewRpt);
            Click(_chkSelectAllDelete);
        }

        public void ClickCancel()
        {
            Click(_cancelButton);
        }

        public void ClickEditButton()
        {
            Click(_editButton);
        }

        public void ClickDeleteButton()
        {
            Click(_deleteButton);
        }

        public string GetRoleNameTextBoxValue()
        {
            return GetElement(_roleNameTxtBox).GetAttribute("value");
        }

        public Boolean IsAnyCheckboxSelected()
        {
            return GetElement(_chkSelectAllEdit).Selected || GetElement(_chkSelectAllUpload).Selected || GetElement(_chkSelectAllViewRpt).Selected || GetElement(_chkSelectAllDelete).Selected;
        }

        public void ChooseType()
        {
            Click(_typeRadioButton);
        }

    }
}
