namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class InputElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static TElement WithAutoFocus<TElement>(this IInputElement<TElement> input)
            where TElement : IInputElement<TElement>
        {
            return input.AddEmptyAttribute("autofocus");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static TElement WithForm<TElement>(this IInputElement<TElement> input, string formId)
            where TElement : IInputElement<TElement>
        {
            return input.AddAttribute("form", formId);
        }
    }
}
