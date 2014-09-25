using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IFormElement : IHtmlElement<IFormElement>
    {
        IFormElement WithCharacterSet(string characterSet);

        IFormElement WithAction(string url);

        IFormElement WithEncodingType(FormEncodingType encodingType);

        IFormElement WithMethod(FormMethod method);

        IFormElement WithName(string name);

        IFormElement WithTarget(PageLinkTarget target);
    }
}
