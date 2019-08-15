using System.Linq;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class InlineFrameElementExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IInlineFrameElement WithSandbox(this IInlineFrameElement iframe, params InlineFrameSandbox[] sandbox)
        {
            return iframe.AddAttribute("sandbox", string.Join(" ", sandbox.Select(item => item.ToHtmlString())));
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = false)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        public static IInlineFrameElement WithSeamless(this IInlineFrameElement iframe)
        {
            return iframe.AddEmptyAttribute("seamless");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IInlineFrameElement WithSourceDocument(this IInlineFrameElement iframe, string html)
        {
            return iframe.AddAttribute("srcdoc", html);
        }
    }
}
