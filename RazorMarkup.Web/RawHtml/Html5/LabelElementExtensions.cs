namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class LabelElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static ILabelElement WithForm(this ILabelElement label, string formId)
        {
            return label.AddAttribute("form", formId);
        }
    }
}
