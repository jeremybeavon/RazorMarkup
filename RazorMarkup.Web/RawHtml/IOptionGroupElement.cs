namespace RazorMarkup.Web.RawHtml
{
    public interface IOptionGroupElement : IHtmlElement<IOptionGroupElement>
    {
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 8.0)]
        IOptionGroupElement WithDisabled();

        IOptionGroupElement WithText(string text);
    }
}
