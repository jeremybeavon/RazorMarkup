using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class HttpMetadataName : HtmlString
    {
        /// <summary>
        /// Specifies the character encoding for the document.
        /// </summary>
        public static readonly HttpMetadataName ContentType = new HttpMetadataName("content-type");

        /// <summary>
        /// Specified the preferred style sheet to use.
        /// </summary>
        public static readonly HttpMetadataName DefaultStyle = new HttpMetadataName("default-style");

        /// <summary>
        /// Defines a time interval for the document to refresh itself.
        /// </summary>
        public static readonly HttpMetadataName Refresh = new HttpMetadataName("refresh");

        public HttpMetadataName(string html)
            : base(html)
        {
        }
    }
}
