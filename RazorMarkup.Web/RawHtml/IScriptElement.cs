using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IScriptElement : IHtmlElement<IScriptElement>
    {
        IScriptElement WithCharacterSet(string characterSet);

        /// <summary>
        /// A script that will not run until after the page has loaded
        /// </summary>
        IScriptElement WithDefer();

        IScriptElement WithUrl(string url);
    }
}
