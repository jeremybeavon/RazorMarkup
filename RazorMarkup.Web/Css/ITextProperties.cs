namespace RazorMarkup.Web.Css
{
    public interface ITextProperties : IHideObjectMethods
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 3.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 3.5)]
        string Color(CssColor color);


    }
}
