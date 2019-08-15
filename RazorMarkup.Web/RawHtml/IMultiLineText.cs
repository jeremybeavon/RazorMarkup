using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IMultiLineText : IHideObjectMethods
    {
        ITextAreaElement Begin();

        IHtmlString End();
    }
}
