namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class SelectElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static ISelectElement WithAutoFocus(this ISelectElement select)
        {
            return select.AddEmptyAttribute("autofocus");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static ISelectElement WithForm(this ISelectElement select, string formId)
        {
            return select.AddAttribute("form", formId);
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = false)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        public static ISelectElement WithRequired(this ISelectElement select)
        {
            return select.AddEmptyAttribute("required");
        }
    }
}
