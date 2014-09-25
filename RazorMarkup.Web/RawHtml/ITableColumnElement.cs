using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface ITableColumnElement : IHtmlElement<ITableColumnElement>
    {
        /// <summary>
        /// Specifies the number of columns a &lt;col&gt; element should span
        /// </summary>
        ITableColumnElement WithSpan(int span);
    }
}
