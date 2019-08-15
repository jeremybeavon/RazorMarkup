namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class HtmlDocumentElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IHtmlDocumentElement WithCacheManifest(this IHtmlDocumentElement html, string url)
        {
            return html.AddAttribute("manifest", url);
        }
    }
}
