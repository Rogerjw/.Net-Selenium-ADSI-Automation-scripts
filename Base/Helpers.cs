using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenQA.Selenium.Interactions;

namespace ADSAutomation.Base
{
    public class Helpers
    {
        private readonly IWebDriver _driver;

        protected Helpers(IWebDriver driver)
        {
            _driver = driver;
        }

        protected void WaitUntilElementVisible(By by)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementVisible(by);
            return _driver.FindElement(by);
        }

        protected void Click(By by)
        {
            //WaitUntilElementVisible(by);
            _driver.FindElement(by).Click();
        }
        protected void ClickUsingJS(By by)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].click();", _driver.FindElement(by));
        }

        protected void SendKeys(By by, string text)
        {
            WaitUntilElementVisible(by);
            _driver.FindElement(by).SendKeys(text);
        }

        protected void SendKeysWithClear(By by, string text)
        {
            WaitUntilElementVisible(by);
            _driver.FindElement(by).Clear();
            _driver.FindElement(by).SendKeys(text);
        }

        protected void MouseHover(By by)
        {
            new Actions(_driver).MoveToElement(_driver.FindElement(by)).Build().Perform();
        }

        public bool VerifyElementDisplayed(By by)
        {
            if (GetElement(by).Displayed)
            {
                return true;
            }
            return false;
        }

        public bool VerifyGivenTextPresent(string text)
        {
            return VerifyElementDisplayed(By.XPath("//*[text()='" + text + "']"));
        }

        public IWebDriver GetDriver()
        {
            return this._driver;
        }

        public Boolean AlertExists()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            if (wait.Until(ExpectedConditions.AlertIsPresent()) == null)
                return false;
            else
                return true;
        }

        public string GetAlertText()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            if (wait.Until(ExpectedConditions.AlertIsPresent()) == null)
                return null;
            else
                return _driver.SwitchTo().Alert().Text;
        }

        public void ClickOkAlert()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            if (!(wait.Until(ExpectedConditions.AlertIsPresent()) == null))
                _driver.SwitchTo().Alert().Accept();
        }

        public int GenerateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0, 999999999);
        }

        protected void PageLoad()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").Equals("complete");
            });
        }

        protected void SwitchToWindow(int windowindex)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[windowindex]);
        }

        public static string Capture(IWebDriver driver, String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var reportPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(reportPath + "Reports\\" + "Screenshots");
            var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "Reports\\Screenshots\\" + screenShotName;
            var localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
            return reportPath;
        }

        protected void Loading(By by)
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        public void ScrollToElement(By by)
        {
            //IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            //js.ExecuteScript("arguments[0].scrollIntoView();", by);
            new Actions(_driver).ScrollToElement(_driver.FindElement(by)).Perform();
        }

        public void Explicitwait(By by)
        {
            WebDriverWait w = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            w.Until(ExpectedConditions.ElementExists(by));
        }
    }
}
