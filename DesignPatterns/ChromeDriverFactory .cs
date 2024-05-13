using BrowserCore;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DesignPatterns
{
    public class ChromeDriverFactory : IBrowserDriver
    {
        public IWebDriver GetWebDriver()
        {
            ChromeOptions options = new();
            return new ChromeDriver(options);
        }
    }
}