using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace BrowserCore
{
    public class MyFirefoxDriver : IBrowserDriver
    {
        public IWebDriver GetWebDriver()
        {
            return new FirefoxDriver();
        }
    }
}