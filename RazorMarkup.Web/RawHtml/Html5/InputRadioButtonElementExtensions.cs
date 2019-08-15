namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class InputRadioButtonElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        public static IInputRadioButtonElement WithRequired(this IInputRadioButtonElement radioButton)
        {
            return radioButton.AddAttribute("required", "required");
        }
    }
}
