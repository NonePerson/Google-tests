using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class GoogleSiteTests
    {
        IWebDriver driver = new EdgeDriver();

        [TestMethod]
        public void GmailHomePageTest()
        {
            GoToSite();

            try
            {
                IWebElement emailBox = driver.FindElement(By.TagName("input"));
                emailBox.Click();
                emailBox.SendKeys("zahavzilberman@gmail.com"); // my email for the matter
                IWebElement sumbit = driver.FindElement(By.ClassName("VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc LQeN7 qIypjc TrZEUc lw1w4b"));
                sumbit.Click();
                while (driver.Url != "https://accounts.google.com/signin/v2/challenge/pwd?service=mail&passive=1209600&osid=1&continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&emr=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin&cid=1&navigationDirection=forward&TL=AKqFyY82RW9audFcsjb6NeeQeYW8cbKPeeDbn6sdVQPBNj3UUKkqeXrhZRcF0F-e")
                {
                    Thread.Sleep(100);
                }
                IWebElement passwordBox = driver.FindElement(By.TagName("input"));
                passwordBox.Click();
                passwordBox.SendKeys("That is none of your conern");
                IWebElement submit2 = driver.FindElement(By.ClassName("VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc LQeN7 qIypjc TrZEUc lw1w4b"));
                submit2.Click();
            }   
            catch (Exception)
            {
                Close();
                NUnit.Framework.Assert.Fail();
            }
            Close();
            NUnit.Framework.Assert.Pass();
        }

        [Test]
        public void GoToSite()
        {
            driver.Navigate().GoToUrl("https://www.gmail.com");
        }

        [TearDown]
        public void Close()
        {
            this.driver.Close();
        }
    }
}
