using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface ITableElements : IHideObjectMethods
    {
        IHtmlElement Begin();

        IHtmlString End();

        IHtmlElement BeginCaption();

        IHtmlString EndCaption();

        ITableColumnElement Column();

        IHtmlElement BeginHeader();

        IHtmlString EndHeader();

        IHtmlElement BeginBody();

        IHtmlString EndBody();
        
        IHtmlElement BeginFooter();

        IHtmlString EndFooter();

        ITableRowElements Row();
    }
}
