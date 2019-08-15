using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface ITableRowElements : IHideObjectMethods
    {
        IHtmlElement Begin();

        IHtmlString End();

        ITableHeaderCellElement BeginHeaderCell();

        IHtmlString EndHeaderCell();

        ITableCellElement BeginCell();

        IHtmlString EndCell();
    }
}
