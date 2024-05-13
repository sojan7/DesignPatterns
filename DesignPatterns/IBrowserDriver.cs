using OpenQA.Selenium;

namespace BrowserCore
{
    public interface IBrowserDriver
    {
        IWebDriver GetWebDriver();
    }
}