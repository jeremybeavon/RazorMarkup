using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IUnorderedListElements : IHideObjectMethods
    {
        IHtmlElement Begin();

        IHtmlString End();

        IHtmlElement BeginItem();

        IHtmlString EndItem();
    }
}
