using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IListElements : IHideObjectMethods
    {
        IDescriptionListElements Description();

        IOrderedListElements Ordered();

        IUnorderedListElements Unordered();
    }
}
