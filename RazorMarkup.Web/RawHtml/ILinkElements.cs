using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface ILinkElements : IHideObjectMethods
    {
        IPageLinkElement BeginPageLink();

        IHtmlString EndPageLink();
    }
}
