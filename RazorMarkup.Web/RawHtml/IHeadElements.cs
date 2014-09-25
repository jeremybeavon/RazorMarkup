using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IHeadElements : IHideObjectMethods
    {
        ILinkElement StylesheetLink();

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = false)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        ILinkElement Link(string relationshipType);

        IStyleElement BeginStylesheet();

        IHtmlString EndStylesheet();

        IBaseElement BaseUrl();
    }
}
