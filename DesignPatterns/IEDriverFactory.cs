namespace BrowserCore
{
    public class IEDriverFactory : BrowserDriverFactory
    {
        public override IBrowserDriver GetBrowserDriver()
        {
            return new MyIEDriver();
        }
    }
}