using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class DocType : HtmlString
    {
        public static readonly DocType Html5 = new DocType("html");

        public static readonly DocType Html401Strict = new DocType(
            "HTML PUBLIC \"-//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\"");

        public static readonly DocType Html401Transitional = new DocType(
            "HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\"");

        public static readonly DocType Html401Frameset = new DocType(
            "HTML PUBLIC \"-//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\"");

        public static readonly DocType XHtml10Strict = new DocType(
            "html PUBLIC \"-//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"");
        public static readonly DocType XHtml10Transitional = new DocType(
            "html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"");

        public static readonly DocType XHtml10Frameset = new DocType(
            "html PUBLIC \"-//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\"");

        public static readonly DocType XHtml11 = new DocType(
            "html PUBLIC \"-//W3C//DTD XHTML 1.1//EN\" \"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd\"");

        public DocType(string html)
            : base(html)
        {
        }
    }
}
