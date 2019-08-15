using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class FormMethod : HtmlString
    {
        /// <summary>
        /// Default. Appends the form-data to the URL in name/value pairs: URL?name=value&amp;name=value
        /// </summary>
        public static readonly FormMethod Get = new FormMethod("get");

        /// <summary>
        /// Sends the form-data as an HTTP post transaction
        /// </summary>
        public static readonly FormMethod Post = new FormMethod("post");

        public FormMethod(string html)
            : base(html)
        {
        }
    }
}
