using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public sealed class InlineFrameSandbox : HtmlString
    {
        public static readonly InlineFrameSandbox AllRestrictions = new InlineFrameSandbox(string.Empty);

        /// <summary>
        /// Allows the iframe content to be treated as being from the same origin as the containing document
        /// </summary>
        public static readonly InlineFrameSandbox AllowSameOrigin = new InlineFrameSandbox("allow-same-origin");

        /// <summary>
        /// Allows the iframe content to navigate (load) content from the containing document
        /// </summary>
        public static readonly InlineFrameSandbox AllowTopNavigation = new InlineFrameSandbox("allow-top-navigation");

        /// <summary>
        /// Allows form submission
        /// </summary>
        public static readonly InlineFrameSandbox AllowForms = new InlineFrameSandbox("allow-forms");

        /// <summary>
        /// Allows script execution
        /// </summary>
        public static readonly InlineFrameSandbox AllowScripts = new InlineFrameSandbox("allow-scripts");

        public InlineFrameSandbox(string html)
            : base(html)
        {
        }
    }
}
