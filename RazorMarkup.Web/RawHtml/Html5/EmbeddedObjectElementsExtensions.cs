namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class EmbeddedObjectElementsExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IEmbedElement Embed(this IEmbeddedObjectElements embed)
        {
            return new EmbedElement();
        }
    }
}
