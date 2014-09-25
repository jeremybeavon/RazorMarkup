using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IDetailsElement : IHtmlElement<IDetailsElement>
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 12.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 15.0)]
        IDetailsElement WithOpen();
    }
}
