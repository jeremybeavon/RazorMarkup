namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class PageLinkElementExtensions
    {
        private const double NotSupported = double.NaN;
        private const double Unknown = 0;

        /// <summary>
        /// Specifies that the target will be downloaded when a user clicks on the hyperlink
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IPageLinkElement WithDownloadLink(this IPageLinkElement element, string link)
        {
            return element.AddAttribute("download", link);
        }

        /// <summary>
        /// Specifies what media/device the linked document is optimized for
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IPageLinkElement WithMedia(this IPageLinkElement element, IMediaOperator media)
        {
            return element.AddAttribute("media", media.ToHtmlString());
        }

        /// <summary>
        /// Specifies the media type of the linked document
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IPageLinkElement WithMediaType(this IPageLinkElement element, string mediaType)
        {
            return element.AddAttribute("type", mediaType);
        }
    }
}
