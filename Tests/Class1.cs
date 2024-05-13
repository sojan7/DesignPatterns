using BrowserCore;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        private readonly BrowserDriverFactory factory;
        private readonly IBrowserDriver browserDriver;

        public Class1()
        {
            factory = new();
            browserDriver = factory.GetBrowserDriver("chrome");
        }

        [Test]
        public void TestMethod1()
        {
            var driver = browserDriver.GetWebDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Quit();
        }
    }
}