using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class PageLinkRelationship : HtmlString
    {
        /// <summary>
        /// Links to an alternate version of the document (i.e. print page, translated or mirror)
        /// </summary>
        public static readonly PageLinkRelationship Alternate = new PageLinkRelationship("alternate");

        /// <summary>
        /// Links to the author of the document
        /// </summary>
        public static readonly PageLinkRelationship Author = new PageLinkRelationship("author");

        /// <summary>
        /// Permanent URL used for bookmarking
        /// </summary>
        public static readonly PageLinkRelationship Bookmark = new PageLinkRelationship("bookmark");

        /// <summary>
        /// Links to a help document
        /// </summary>
        public static readonly PageLinkRelationship Help = new PageLinkRelationship("help");

        /// <summary>
        /// Links to copyright information for the document
        /// </summary>
        public static readonly PageLinkRelationship License = new PageLinkRelationship("license");

        /// <summary>
        /// The next document in a selection
        /// </summary>
        public static readonly PageLinkRelationship NextDocumentInSelection = new PageLinkRelationship("next");

        /// <summary>
        /// Links to an unendorsed document, like a paid link. 
        /// ("nofollow" is used by Google, to specify that the Google search spider should not follow that link)
        /// </summary>
        public static readonly PageLinkRelationship NoFollow = new PageLinkRelationship("nofollow");

        /// <summary>
        /// Specifies that the browser should not send a HTTP referer header if the user follows the hyperlink
        /// </summary>
        public static readonly PageLinkRelationship NoReferrer = new PageLinkRelationship("noreferrer");

        /// <summary>
        /// Specifies that the target document should be cached
        /// </summary>
        public static readonly PageLinkRelationship PreFetch = new PageLinkRelationship("prefetch");

        /// <summary>
        /// The previous document in a selection
        /// </summary>
        public static readonly PageLinkRelationship PreviousDocumentInSelection = new PageLinkRelationship("prev");

        /// <summary>
        /// Links to a search tool for the document
        /// </summary>
        public static readonly PageLinkRelationship Search = new PageLinkRelationship("search");

        /// <summary>
        /// A tag (keyword) for the current document
        /// </summary>
        public static readonly PageLinkRelationship Tag = new PageLinkRelationship("tag");

        public PageLinkRelationship(string html)
            : base(html)
	    {
	    }
    }
}
