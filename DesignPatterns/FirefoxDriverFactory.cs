using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace BrowserCore
{
    public class FirefoxDriverFactory : IBrowserDriver
    {
        public IWebDriver GetWebDriver()
        {
            FirefoxOptions options = new();
            return new FirefoxDriver(options);
        }
    }
}