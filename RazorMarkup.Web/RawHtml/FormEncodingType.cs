using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class FormEncodingType : HtmlString
    {
        /// <summary>
        /// Default. All characters are encoded before sent (spaces are converted to "+" symbols,
        /// and special characters are converted to ASCII HEX values)
        /// </summary>
        public static readonly FormEncodingType XWwwFormUrlEncoding =
            new FormEncodingType("application/x-www-form-urlencoded");

        /// <summary>
        /// No characters are encoded
        /// </summary>
        public static readonly FormEncodingType FormData = new FormEncodingType("multipart/form-data");

        /// <summary>
        /// Spaces are converted to "+" symbols, but no special characters are encoded
        /// </summary>
        public static readonly FormEncodingType TextPlain = new FormEncodingType("text/plain");

        public FormEncodingType(string html)
            : base(html)
        {
        }
    }
}
