using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class FormElement : AbstractHtmlElement<IFormElement>, IFormElement
    {
        public FormElement()
            : base("form", false)
        {
        }

        public IFormElement WithCharacterSet(string characterSet)
        {
            return AddAttribute("accept-charset", characterSet);
        }

        public IFormElement WithAction(string url)
        {
            return AddAttribute("action", url);
        }

        public IFormElement WithEncodingType(FormEncodingType encodingType)
        {
            return AddAttribute("enctype", encodingType.ToHtmlString());
        }

        public IFormElement WithMethod(FormMethod method)
        {
            return AddAttribute("method", method.ToHtmlString());
        }

        public IFormElement WithName(string name)
        {
            return AddAttribute("name", name);
        }

        public IFormElement WithTarget(PageLinkTarget target)
        {
            return AddAttribute("target", target.ToHtmlString());
        }
    }
}
