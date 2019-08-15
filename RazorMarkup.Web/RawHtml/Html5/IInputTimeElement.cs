using System;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IInputTimeElement : IInputElement<IInputTimeElement>
    {
        IInputTimeElement WithDisabled();

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        IInputTimeElement WithMax(DateTime max);

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        IInputTimeElement WithMin(DateTime min);

        IInputTimeElement WithValue(DateTime value);
    }
}
