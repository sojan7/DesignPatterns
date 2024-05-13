using DesignPatterns;

namespace BrowserCore
{
    public class BrowserDriverFactory
    {
        public IBrowserDriver GetBrowserDriver(string browser)
        {
            return browser.ToLower() switch
            {
                "chrome" => new ChromeDriverFactory(),
                "firefox" => new FirefoxDriverFactory(),
                "ie" => new IEDriverFactory(),
                _ => throw new NotSupportedException($"Browser '{browser}' is not supported."),
            };
        }
    }
}