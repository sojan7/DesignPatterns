using BrowserCore;
using DesignPatterns;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test, Order(1)]
        public void ChromeTestMethod()
        {
            BrowserDriverFactory factory = new ChromeDriverFactory();
            IBrowserDriver browserDriver = factory.GetBrowserDriver();
            IWebDriver driver = browserDriver.GetWebDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.example.com");
            driver.Quit();
            Assert.Pass();
        }

        [Test, Order(2)]
        public void ChromeDriverWithCapabilitiesFactoryTestMethod()
        {
            BrowserDriverFactory factory = new ChromeDriverWithCapabilitiesFactory();
            IBrowserDriver browserDriver = factory.GetBrowserDriver();
            IWebDriver driver = browserDriver.GetWebDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.example.com");
            driver.Quit();
            Assert.Pass();
        }

        [Test, Order(3)]
        public void FireFoxTestMethod()
        {
            BrowserDriverFactory factory = new FirefoxDriverFactory();
            IBrowserDriver browserDriver = factory.GetBrowserDriver();
            IWebDriver driver = browserDriver.GetWebDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.example.com");
            driver.Quit();
            Assert.Pass();
        }

        [Test, Order(4)]
        public void IETestMethod()
        {
            BrowserDriverFactory factory = new IEDriverFactory();
            IBrowserDriver browserDriver = factory.GetBrowserDriver();
            IWebDriver driver = browserDriver.GetWebDriver();
            driver.Navigate().GoToUrl("https://www.example.com");
            driver.Quit();
            Assert.Pass();
        }
    }
}