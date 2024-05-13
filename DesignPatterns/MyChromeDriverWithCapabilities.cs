using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace BrowserCore
{
    public class MyChromeDriverWithCapabilities : IBrowserDriver
    {
        public IWebDriver GetWebDriver()
        {
            ChromeOptions options = new();
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--incognito");
            return new ChromeDriver(options);
        }
    }
}