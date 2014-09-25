using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IDescriptionListElements : IHideObjectMethods
    {
        IHtmlElement Begin();

        IHtmlString End();

        IHtmlElement BeginTerm();

        IHtmlString EndTerm();

        IHtmlElement BeginDescription();

        IHtmlString EndDescription();
    }
}
