using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace BrowserCore
{
    public class IEDriverFactory : IBrowserDriver
    {
        public IWebDriver GetWebDriver()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            return new InternetExplorerDriver(options);
        }
    }
}