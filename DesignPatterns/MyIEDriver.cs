using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace BrowserCore
{
    public class MyIEDriver : IBrowserDriver
    {
        public IWebDriver GetWebDriver()
        {
            return new InternetExplorerDriver();
        }
    }
}