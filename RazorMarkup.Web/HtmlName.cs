using System.Web;

namespace RazorMarkup.Web
{
    public sealed class HtmlName : HtmlString
    {
        public HtmlName(string html)
            : base(html)
        {
        }
    }
}
