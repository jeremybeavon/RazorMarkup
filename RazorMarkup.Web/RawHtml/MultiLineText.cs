using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class MultiLineText : IMultiLineText
    {
        public ITextAreaElement Begin()
        {
            return new TextAreaElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</textarea>");
        }
    }
}
