using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class MetadataName : HtmlString
    {
        /// <summary>
        /// Specifies the name of the Web application that the page represents
        /// </summary>
        public static readonly MetadataName ApplicationName = new MetadataName("application-name");

        /// <summary>
        /// Specifies the name of the author of the document.
        /// </summary>
        public static readonly MetadataName Author = new MetadataName("author");

        /// <summary>
        /// Specifies a description of the page. Search engines can pick up this description to
        /// show with the results of searches.
        /// </summary>
        public static readonly MetadataName Description = new MetadataName("description");

        /// <summary>
        /// Specifies one of the software packages used to generate the document (not used on hand-authored pages)
        /// </summary>
        public static readonly MetadataName Generator = new MetadataName("generator");

        /// <summary>
        /// Specifies a comma-separated list of keywords - relevant to the page
        /// (Informs search engines what the page is about).
        /// </summary>
        public static readonly MetadataName Keywords = new MetadataName("keywords");

        public MetadataName(string html)
            : base(html)
        {
        }
    }
}
