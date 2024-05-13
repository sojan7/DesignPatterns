using BrowserCore;

namespace DesignPatterns
{
    public class ChromeDriverFactory : BrowserDriverFactory
    {
        public override IBrowserDriver GetBrowserDriver()
        {
            return new MyChromeDriver();
        }
    }
}