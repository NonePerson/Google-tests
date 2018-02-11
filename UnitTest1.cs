using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class GoogleSiteTests
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void GoToSite()
        {
            driver.Navigate().GoToUrl("https://www.google.co.il");
        }
        public void TheRest()
        {
            // search input
            By searchInput = By.Id("lst-ib");
            IWebElement searchInputElement = driver.FindElement(searchInput);

            IWebElement searchButton;
            By TheInputElements = By.TagName("input");
            IList<IWebElement> inputElements = driver.FindElements(TheInputElements);
            foreach(IWebElement inputElement in inputElements)
            {
                if (inputElement.Text == "חיפוש ב-Google")
                {
                    searchButton = inputElement;
                }
            }
        }
       
    }
}
