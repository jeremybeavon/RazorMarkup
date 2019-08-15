using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IBlockElements : IHideObjectMethods
    {
        IHtmlElement Begin();

        IHtmlString End();

        IHtmlElement BeginInline();

        IHtmlString EndInline();
    }
}
