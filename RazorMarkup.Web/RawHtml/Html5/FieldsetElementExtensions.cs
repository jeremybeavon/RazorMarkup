namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class FieldsetElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IFieldsetElement WithDisabled(this IFieldsetElement fieldset)
        {
            return fieldset.AddAttribute("disabled", "disabled");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = false)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IFieldsetElement WithForm(this IFieldsetElement fieldset, string formId)
        {
            return fieldset.AddAttribute("form", formId);
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IFieldsetElement WithName(this IFieldsetElement fieldset, string name)
        {
            return fieldset.AddAttribute("name", name);
        }
    }
}
