namespace RazorMarkup.Web.RawHtml
{
    public interface IOptionElement : IHtmlElement<IOptionElement>
    {
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 8.0)]
        IOptionElement WithDisabled();

        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 8.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        IOptionElement WithShortText(string shortText);

        IOptionElement WithSelected();

        IOptionElement WithValue(string value);
    }
}
