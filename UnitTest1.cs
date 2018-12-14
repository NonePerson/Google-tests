using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class GoogleSiteTests
    {
        IWebDriver driver = new ChromeDriver();

        public GoogleSiteTests()
        {
        }

        [TestMethod]
        public void GoogleHomePageTest()
        {
            GoToSite();

            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(IsTheGoogleSearchTextShown());
            }
            catch (AssertFailedException)
            {
                Close();
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail();
            }
        }

        [Test]
        public void GoToSite()
        {
            driver.Navigate().GoToUrl("https://www.google.co.il");
        }

        [Test]
        public bool IsTheGoogleSearchTextShown()
        {
            IWebElement searchButton = null;
            By TheInputElements = By.TagName("input");
            IList<IWebElement> inputElements = driver.FindElements(TheInputElements);
            foreach (IWebElement inputElement in inputElements)
            {
                if (inputElement.Text == "חיפוש ב-Google")
                {
                    searchButton = inputElement;
                }
            }

            return searchButton != null;
        }

        [TearDown]
        public void Close()
        {
            this.driver.Close();
        }
    }
}

