using System;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IInputMonthElement : IInputElement<IInputMonthElement>
    {
        IInputMonthElement WithDisabled();

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        IInputMonthElement WithMax(DateTime max);

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        IInputMonthElement WithMin(DateTime min);

        IInputMonthElement WithValue(DateTime value);
    }
}
