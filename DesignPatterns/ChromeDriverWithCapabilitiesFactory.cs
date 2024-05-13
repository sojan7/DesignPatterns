namespace BrowserCore
{
    public class ChromeDriverWithCapabilitiesFactory : BrowserDriverFactory
    {
        public override IBrowserDriver GetBrowserDriver()
        {
            return new MyChromeDriverWithCapabilities();
        }
    }
}