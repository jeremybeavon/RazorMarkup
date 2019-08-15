namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class TableHeaderCellElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static ITableHeaderCellElement WithAbbreviation(this ITableHeaderCellElement header, string abbreviation)
        {
            return header.AddAttribute("abbr", abbreviation);
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static ITableHeaderCellElement WithHeaders(this ITableHeaderCellElement header, params string[] headers)
        {
            return header.AddAttribute("headers", string.Join(" ", headers));
        }
    }
}
