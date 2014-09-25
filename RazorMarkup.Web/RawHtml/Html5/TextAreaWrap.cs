using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public sealed class TextAreaWrap : HtmlString
    {
        /// <summary>
        /// The text in the textarea is not wrapped when submitted in a form. This is default
        /// </summary>
        public static readonly TextAreaWrap Soft = new TextAreaWrap("soft");

        /// <summary>
        /// The text in the textarea is wrapped (contains newlines) when submitted in a form.
        /// When "hard" is used, the cols attribute must be specified
        /// </summary>
        public static readonly TextAreaWrap Hard = new TextAreaWrap("hard");

        public TextAreaWrap(string html)
            : base(html)
        {
        }
    }
}
