using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
