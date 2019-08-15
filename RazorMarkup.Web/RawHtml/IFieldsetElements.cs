using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IFieldsetElements : IHideObjectMethods
    {
        IFieldsetElement Begin();

        IHtmlString End();

        IHtmlElement BeginLegend();

        IHtmlString EndLegend();
    }
}
