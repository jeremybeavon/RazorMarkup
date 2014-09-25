using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class PageLinkTarget : HtmlString
    {
        /// <summary>
        /// Opens the linked document in the same frame as it was clicked (this is default)
        /// </summary>
        public static readonly PageLinkRelationship CurrentWindow = new PageLinkRelationship("_self");

        /// <summary>
        /// Opens the linked document in a new window or tab
        /// </summary>
        public static readonly PageLinkRelationship NewWindowOrTab = new PageLinkRelationship("_blank");

        /// <summary>
        /// Opens the linked document in the parent frame
        /// </summary>
        public static readonly PageLinkRelationship ParentFrame = new PageLinkRelationship("_parent");

        /// <summary>
        /// Opens the linked document in the full body of the window
        /// </summary>
        public static readonly PageLinkRelationship TopFrame = new PageLinkRelationship("_top");

        public PageLinkTarget(string html)
            : base(html)
        {
        }
    }
}
