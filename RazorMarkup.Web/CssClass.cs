using System.Web;

namespace RazorMarkup.Web
{
    public sealed class CssClass : HtmlString
    {
        public CssClass(string html)
            : base(html)
        {
        }
    }
}
