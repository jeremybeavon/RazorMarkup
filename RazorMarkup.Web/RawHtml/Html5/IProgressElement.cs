namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IProgressElement : IHtmlElement<IProgressElement>
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        IProgressElement WithMax(double maxValue);

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        IProgressElement WithValue(double value);
    }
}
