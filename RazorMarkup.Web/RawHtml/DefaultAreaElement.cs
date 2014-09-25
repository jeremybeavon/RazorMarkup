using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class DefaultAreaElement : AbstractAreaElement<IDefaultAreaElement>, IDefaultAreaElement
    {
        public DefaultAreaElement()
            : base("default")
        {
        }
    }
}
