namespace BrowserCore
{
    public class FirefoxDriverFactory : BrowserDriverFactory
    {
        public override IBrowserDriver GetBrowserDriver()
        {
            return new MyFirefoxDriver();
        }
    }
}