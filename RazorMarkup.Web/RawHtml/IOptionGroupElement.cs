using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IOptionGroupElement : IHtmlElement<IOptionGroupElement>
    {
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 8.0)]
        IOptionGroupElement WithDisabled();

        IOptionGroupElement WithText(string text);
    }
}
