using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using Originator.DataAccess;

namespace SeleniumTests
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(InternetExplorerDriver))]
    [TestFixture(typeof(ChromeDriver))]
    public class OperationsSystemAudit<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new TWebDriver();
            baseURL = "http://hajwdsbsqik1.sbs.local/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        private void SwitchFrame(string frameId)
        {
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id(frameId)))
                    {
                        driver.SwitchTo().Frame(frameId);
                        break;
                    }
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        [Test]
        public void TheOperationsSystemAuditTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/qik/QikLogin.asp");
            driver.FindElement(By.Id("DlrCode")).Clear();
            driver.FindElement(By.Id("DlrCode")).SendKeys("fnl9999998");
            driver.FindElement(By.Id("DlrPass")).Clear();
            driver.FindElement(By.Id("DlrPass")).SendKeys("pass123");
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();

            SwitchFrame("iframe1");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.CssSelector("#tab6 > span.tabTop")))
                    {
                        break;
                    }
                    else
                    {
                        SwitchFrame("iframe1");
                    }
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.CssSelector("#tab6 > span.tabTop")).Click();
            driver.FindElement(By.LinkText("3. Operations System")).Click();
            driver.FindElement(By.Name("txtSearch")).Clear();
            driver.FindElement(By.Name("txtSearch")).SendKeys("755557");
            driver.FindElement(By.Name("optSearch")).Click();
            driver.FindElement(By.LinkText("755557")).Click();
            driver.FindElement(By.Id("Txt_Dlr_Name")).Clear();
            driver.FindElement(By.Id("Txt_Dlr_Name")).SendKeys("CAPITAL LENDING Test");
            driver.FindElement(By.Id("Txt_Group")).Clear();
            driver.FindElement(By.Id("Txt_Group")).SendKeys("Test");
            driver.FindElement(By.Id("Txt_Street")).Clear();
            driver.FindElement(By.Id("Txt_Street")).SendKeys("101 End Of The Lane Test");
            driver.FindElement(By.Id("Txt_Suburb")).Clear();
            driver.FindElement(By.Id("Txt_Suburb")).SendKeys("Thousand Kauri Test");
            driver.FindElement(By.Id("Txt_P_Suburb")).Clear();
            driver.FindElement(By.Id("Txt_P_Suburb")).SendKeys("Test");
            driver.FindElement(By.Id("Txt_EMail")).Clear();
            driver.FindElement(By.Id("Txt_EMail")).SendKeys("empty@null.dev.nz");
            driver.FindElement(By.Id("Txt_Pwd")).Clear();
            driver.FindElement(By.Id("Txt_Pwd")).SendKeys("pass123");
            driver.FindElement(By.Id("Chk_ShowFNC_OPTIN")).Click();
            driver.FindElement(By.Id("Txt_CustRate")).Clear();
            driver.FindElement(By.Id("Txt_CustRate")).SendKeys("0.11");
            driver.FindElement(By.Id("Txt_CustRate_BL")).Clear();
            driver.FindElement(By.Id("Txt_CustRate_BL")).SendKeys("0.12");
            driver.FindElement(By.Id("Txt_Min_Cust_Rate_VL")).Clear();
            driver.FindElement(By.Id("Txt_Min_Cust_Rate_VL")).SendKeys("0.04");
            driver.FindElement(By.Id("Txt_CmrBook_VL")).Clear();
            driver.FindElement(By.Id("Txt_CmrBook_VL")).SendKeys("85");
            driver.FindElement(By.Id("Txt_MonthlyServiceFee_VL")).Clear();
            driver.FindElement(By.Id("Txt_MonthlyServiceFee_VL")).SendKeys("32");
            driver.FindElement(By.Id("Txt_DlrRate")).Clear();
            driver.FindElement(By.Id("Txt_DlrRate")).SendKeys("0.4");
            new SelectElement(driver.FindElement(By.Id("Cbo_GoodsSold"))).SelectByText("Bikes");
            driver.FindElement(By.Id("Txt_Bank_Acc_Name")).Clear();
            driver.FindElement(By.Id("Txt_Bank_Acc_Name")).SendKeys("Bank Acc Name");
            driver.FindElement(By.Id("Txt_Sendback_Mail")).Clear();
            driver.FindElement(By.Id("Txt_Sendback_Mail")).SendKeys("No sendback");
            driver.FindElement(By.Id("Cmd_Save")).Click();

            driver.Manage().Window.Maximize();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot(); // gets only visible area
            String shotname = String.Format(@"C:\screenshots\OSAudit-{0}-01-SavedData.jpg", driver.ToString());
            ss.SaveAsFile(shotname, System.Drawing.Imaging.ImageFormat.Jpeg);

            driver.FindElement(By.LinkText("Qik Home Page")).Click();

            SwitchFrame("iframe1");
            driver.FindElement(By.CssSelector("#tab8 > span.tabTop")).Click();
            driver.FindElement(By.LinkText("24. Operations System Audit Report")).Click();
            driver.FindElement(By.Id("OriginatorID")).Clear();
            driver.FindElement(By.Id("OriginatorID")).SendKeys("755557");
            driver.FindElement(By.Name("Btn_Go")).Click();

            driver.Manage().Window.Maximize();
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            shotname = String.Format(@"C:\screenshots\OSAudit-{0}-02-Audit.jpg", driver.ToString());
            ss.SaveAsFile(shotname, System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        [Test]
        public void VerifyDealerExists()
        {
            DealerMaster dealerMaster = new DealerMaster();
            var dealer = dealerMaster.DLRMASTs.Find( "754457" );
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
