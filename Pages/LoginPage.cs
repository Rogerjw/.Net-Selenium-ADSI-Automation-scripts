﻿using ADSAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Pages
{
    public class LoginPage : Helpers
    {
        private readonly By _username = By.Id("TxtUserName");
        private readonly By _password = By.Id("Txtpassword");
        private readonly By _login = By.Id("BtnSubmitLogin");
        public readonly By _homePageElement = By.XPath("//a[text()='Home']");
        private IWebDriver driver;

        public LoginPage(IWebDriver driver):base(driver)
        {
            
        }        

        public void EnterUsername(string username)
        {
            SendKeysWithClear(_username, username);
        }

        public void EnterPassword(string password)
        {
            SendKeysWithClear(_password, password);
        }

        public void ClickLogInButton()
        {
            Click(_login);
        }

        public void Login(string email, string password)
        {
            EnterUsername(email);
            EnterPassword(password);
            ClickLogInButton();
        }
    }
}
