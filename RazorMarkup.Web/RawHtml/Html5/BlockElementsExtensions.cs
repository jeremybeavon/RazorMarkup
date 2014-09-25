using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class BlockElementsExtensions
    {
        /// <summary>
        /// This must be called from inside a block or div.
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = false)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        public static IStyleElement BeginScopedStylesheet(this IBlockElements block)
        {
            return new StyleElement().AddEmptyAttribute("scoped");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = false)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        public static IHtmlString EndScopedStylesheet(this IBlockElements block)
        {
            return new HtmlString("</style>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginNavigation(this IBlockElements block)
        {
            return new HtmlElement("nav");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndNavigation(this IBlockElements block)
        {
            return new HtmlString("</nav>");
        }
    }
}
