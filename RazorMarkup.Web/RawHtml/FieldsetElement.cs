using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class FieldsetElement : AbstractHtmlElement<IFieldsetElement>, IFieldsetElement
    {
        public FieldsetElement()
            : base("fieldset", false)
        {
        }
    }
}
