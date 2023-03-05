using ADSAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.TestScripts
{
    [TestFixture]
    class ManageUserTest : MasterTest
    {
        private LoginPage _loginPage;
        private ManageUser _manageUser;

        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(_driver);
            _manageUser = new ManageUser(_driver);
        }

        [Test(Description = "Verify whether a user can click Manage user sub module")]
        public void HoverManageUserPage()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.ChooseFile();
            Assert.AreEqual("Manage User", _manageUser.GetHeader());
        }

        [Test(Description = "To verify user is able to create a new user with all data")]
        public void TestVerify_newUser_TobeCreated()  
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ManageUserCreation("Ratifah", "rat", "JM", " raj123", "0780258460", "8460", "raj@gmail.com");
        }

        [Test(Description = "To verify First Name field in Manage User page")]
        public void TestVerify_No_FirstNameUserPageFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.EnterLastname("Cameron");
            _manageUser.EnterMiddlename("kim");
            _manageUser.EnterPassword("cam123");
            _manageUser.ClickRole();
            _manageUser.EnterPhone("0789765414");
            _manageUser.EnterFax("7863542769");
            _manageUser.EnterUserid("cam@gmail.com");
            _manageUser.ClickType();
            _manageUser.ClickSubmodule();
            _manageUser.ChooseFile();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ClickSubmit();
        }

        [Test(Description = "To verify Password field in Manage User page")]
        public void TestVerify_No_PasswordUserPageFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ManageUserPassword("David","Cameron"," davidcam", "0780258460", "8460", "jean@gmail.com");
        }

        [Test(Description = "To verify Role field in Manage User page")]
        public void TestVerify_No_RoleFields_Selected()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ManageUserRole("David","Cameron", "Jean", "123","0780258460", "8460", "jean@gmail.com");
        }

        [Test(Description = "To verify Organization field in Manage User page")]
        public void TestVerify_No_OrganizationFields_Selected()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ManageOrganization("David", "Cameron", "Jean", " 123", "0780258460", "8460", "jean@gmail.com");
        }

        [Test(Description = "To verify Company field in Manage User page")]
        public void TestVerify_No_CompanyFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.EnterFirstname("David");
            _manageUser.EnterLastname("Cameron");
            _manageUser.EnterMiddlename("kim");
            _manageUser.EnterPassword("cam123");
            _manageUser.ClickRole2();
            _manageUser.EnterPhone("0789765414");
            _manageUser.EnterFax("7863542769");
            _manageUser.EnterUserid("cam@gmail.com");
            _manageUser.ClickType();
            _manageUser.ClickSubmodule();
            _manageUser.ChooseFile();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ClickSubmit();
            Assert.AreEqual(true, _manageUser.AlertText().Contains("Enter First Name"));
        }

        [Test(Description = "To verify Phone No field in Manage User page")]
        public void TestVerify_No_PhoneFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ManagePhone("David", "Cameron", "Jean"," 123","8460", "jean@gmail.com");
        }

        [Test(Description = "To verify Email field in Manage User page")]
        public void TestVerify_No_EmailFields()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ManageEmail("David", "Cameron", "Jean", "123", " davidcam","0780998460", "8460");
        }

        [Test(Description = "To verify Cancel functionality in Manage User page")]
        public void TestVerify_CancelButton()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.ManageCancelButton();
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "To verify user is able to search the record using UserName in table")]
        public void TestVerifySearchByUsername()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.ScrollUserName();
            _manageUser.EnterSearchName("Muthu");
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "To verify user is able to search the record using Role Name in table")]
        public void TestVerifySearchByRolename()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.searchByUserRole("Area User");
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "To verify user is able to search the record using Email in table")]
        public void TestVerifySearchByEmail()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.searchByUserEmail("muthu");
        }

        [Test(Description = "To verify user is able to search the record using CompanyName in table")]
        public void TestVerifySearchByCompanyName()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.ScrollCompName();
            _manageUser.searchByUserCompany("fax");
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "To verify user is able to search the record using Phone No in table")]
        public void TestVerifySearchByPhoneNo()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.searchByUserPhone("7656833202");
            Assert.AreEqual("Oximetry", _driver.Title);
        }

        [Test(Description = "To verify user able to edit the existing user ")]
        public void TestVerifyEditExistingUser()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            _manageUser.ClickEditIcon();
            _manageUser.EnterPassUpdt("12345");
            _manageUser.ClickSubmodule();
            _manageUser.UploadSignature();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.ClickUpdate();
        }

        [Test(Description = "To verify user is able to export and download the all records in Excel sheet")]
        public void TestVerifyExportAllRecords()
        {
            _loginPage.Login("admin@techaffinity.com", "admin");
            _manageUser.GoToAdmin();
            Assert.AreEqual("Oximetry", _driver.Title);
            _manageUser.GotoScroll();
            _manageUser.ClickExportToExcel();
        }
    }
}
