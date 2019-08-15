using System.Web.Mvc;

namespace RazorMarkup.Web.RawHtml
{
    public static class HtmlHelperExtensions
    {
        public static IRawHtml Raw(this HtmlHelper html)
        {
            return new RawHtml();
        }
    }
}
