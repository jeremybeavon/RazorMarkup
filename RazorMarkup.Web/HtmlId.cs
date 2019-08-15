using System.Web;

namespace RazorMarkup.Web
{
    public sealed class HtmlId : HtmlString
    {
        public HtmlId(string html)
            : base(html)
        {
        }
    }
}
