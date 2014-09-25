using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IFigureElements : IHideObjectMethods
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        IHtmlElement Begin();

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        IHtmlString End();

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        IHtmlElement BeginCaption();

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        IHtmlString EndCaption();
    }
}
