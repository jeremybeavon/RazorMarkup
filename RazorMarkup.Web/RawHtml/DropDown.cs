using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class DropDown : IDropDown
    {
        public ISelectElement Begin()
        {
            return new SelectElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</select>");
        }
        
        public IOptionGroupElement BeginOptionGroup()
        {
            return new OptionGroupElement();
        }

        public IHtmlString EndOptionGroup()
        {
            return new HtmlString("</optgroup>");
        }

        public IOptionElement BeginOption()
        {
            return new OptionElement();
        }

        public IHtmlString EndOption()
        {
            return new HtmlString("</option>");
        }
    }
}
