using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface ICanvasElement : IHtmlElement<ICanvasElement>
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 2.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 3.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.0)]
        ICanvasElement WithHeight(int pixels);

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 2.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 3.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.0)]
        ICanvasElement WithWidth(int pixels);
    }
}
