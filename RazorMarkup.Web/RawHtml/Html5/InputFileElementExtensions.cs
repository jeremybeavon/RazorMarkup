namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class InputFileElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IInputFileElement WithAllowMultiple(this IInputFileElement file)
        {
            return file.AddAttribute("multiple", "multiple");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        public static IInputFileElement WithRequired(this IInputFileElement file)
        {
            return file.AddAttribute("required", "required");
        }
    }
}
