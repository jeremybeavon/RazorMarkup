using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class ButtonType : HtmlString
    {
        public static readonly ButtonType Button = new ButtonType("button");

        public static readonly ButtonType Reset = new ButtonType("reset");

        public static readonly ButtonType Submit = new ButtonType("submit");

        public ButtonType(string html)
            : base(html)
        {
        }
    }
}
