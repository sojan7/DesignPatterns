using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace BrowserCore
{
    public class MyChromeDriver : IBrowserDriver
    {
        public IWebDriver GetWebDriver()
        {
            return new ChromeDriver();
        }
    }
}