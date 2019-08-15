using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IOrderedListElements : IHideObjectMethods
    {
        IOrderedListElement Begin();

        IHtmlString End();

        IOrderedListItemElement BeginItem();

        IHtmlString EndItem();
    }
}
