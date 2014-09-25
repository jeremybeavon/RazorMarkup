using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class TextElementsExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginArticle(this IRawHtml html)
        {
            return new HtmlElement("article");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndArticle(this IRawHtml html)
        {
            return new HtmlString("</article>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginAside(this ITextElements text)
        {
            return new HtmlElement("aside");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndAside(this ITextElements text)
        {
            return new HtmlString("</aside>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IBidirectionalTextOverrideElement BeginBidirectionalTextOverride(this IRawHtml html)
        {
            return new BidirectionalTextOverrideElement();
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IHtmlString EndBidirectionalTextOverride(this IRawHtml html)
        {
            return new HtmlString("</bdo>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 12.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 15.0)]
        public static IDetailsElement BeginDetails(this ITextElements text)
        {
            return new DetailsElement();
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 12.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 15.0)]
        public static IHtmlString EndDetails(this ITextElements text)
        {
            return new HtmlString("</details>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginHeader(this ITextElements text)
        {
            return new HtmlElement("header");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndHeader(this ITextElements text)
        {
            return new HtmlString("</header>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginFooter(this ITextElements text)
        {
            return new HtmlElement("footer");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndFooter(this ITextElements text)
        {
            return new HtmlString("</footer>");
        }
        
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginMain(this ITextElements text)
        {
            return new HtmlElement("main");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndMain(this ITextElements text)
        {
            return new HtmlString("</main>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginMarkText(this ITextElements text)
        {
            return new HtmlElement("mark");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndMarkText(this ITextElements text)
        {
            return new HtmlString("</mark>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlElement BeginSection(this ITextElements text)
        {
            return new HtmlElement("section");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static IHtmlString EndSection(this ITextElements text)
        {
            return new HtmlString("</section>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 12.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 15.0)]
        public static IHtmlElement BeginSummary(this ITextElements text)
        {
            return new HtmlElement("<summary>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 12.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 15.0)]
        public static IHtmlString EndSummary(this ITextElements text)
        {
            return new HtmlString("</summary>");
        }

        /// <summary>
        /// Specifies where in a text it would be ok to add a line-break.
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 3.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.7)]
        public static IHtmlElement WorkBreak(this ITextElements text)
        {
            return new HtmlElement("wbr", true);
        }
    }
}
