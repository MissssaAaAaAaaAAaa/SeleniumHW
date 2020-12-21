using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    class Testsfrom1to8
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            //driver = new ChromeDriver();//аналогично для хрома
            driver = new OperaDriver();
            driver.Url = "https://www.epam.com";
        }

        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[1]/span[1]/a", "https://www.epam.com/services")]//Test for scenario 1
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[2]/span/a", "https://www.epam.com/how-we-do-it")]//Test for scenario 2
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[3]/span[1]/a", "https://www.epam.com/our-work")]//Test for scenario 3
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[4]/span/a", "https://www.epam.com/insights")]//Test for scenario 4
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[5]/span[1]/a", "https://www.epam.com/about")]//Test for scenario 5
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/nav/ul/li[6]/span[1]/a", "https://www.epam.com/careers")]//Test for scenario 6
        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[1]/a", "https://www.epam.com/about/who-we-are/contact")]//Test for scenario 7

        public void HeaderButtonsClickabilityTest(string XPathOfEl,string UrlOfOpenedPage)
        {
            driver.Manage().Window.Maximize();
            IWebElement element = driver.FindElement(By.XPath(XPathOfEl));
            element.Click();
            Assert.AreEqual(UrlOfOpenedPage, driver.Url, "the required page wasn't opened");
        }

        [TestCase("//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/button", "//*[@id=\"wrapper\"]/div[2]/div[1]/header/div/ul/li[2]/div/nav")]
        public void SelectLanguageMenuTest(string XPathOfClikcedEl, string XPathOfPopUpdEl)
        {
            driver.Manage().Window.Maximize();
            IWebElement element1 = driver.FindElement(By.XPath(XPathOfClikcedEl));
            element1.Click();
            Assert.AreEqual(true, driver.FindElement(By.XPath(XPathOfPopUpdEl)).Displayed, "the required element is not displayed");
        }

        [TearDown]
        public void closeBrowser()  
        {
            driver.Close();
        }
    }
}
