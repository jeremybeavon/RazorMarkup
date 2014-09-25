using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class RawHtmlExtensions
    {
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 2.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 3.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.0)]
        public static ICanvasElement BeginCanvas(this IRawHtml html)
        {
            return new CanvasElement();
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 2.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 3.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.0)]
        public static IHtmlString EndCanvas(this IRawHtml html)
        {
            return new HtmlString("</canvas>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 20.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.0)]
        public static IHtmlElement BeginDataList(this IRawHtml html)
        {
            return new HtmlElement("datalist");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 20.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.0)]
        public static IHtmlString EndDataList(this IRawHtml html)
        {
            return new HtmlString("</datalist>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 8.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.0)]
        public static IMeterElement BeginMeter(this IRawHtml html)
        {
            return new MeterElement();
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 8.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.0)]
        public static IHtmlString EndMeter(this IRawHtml html)
        {
            return new HtmlString("</meter>");
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 8.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 16.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.0)]
        public static IProgressElement BeginProgressBar(this IRawHtml html)
        {
            return new ProgressElement();
        }
        
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 8.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 16.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.0)]
        public static IHtmlString EndProgressBar(this IRawHtml html)
        {
            return new HtmlString("</progress>");
        }

        /// <summary>
        /// The type attribute is no longer required in HTML 5.
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IScriptElement BeginHtml5Script(this IRawHtml html)
        {
            return new ScriptElement(null);
        }
    }
}
/* 
 * TODOs
 * time
 * video
 *      source
 *      track
 * 
 * Controls:
 * output
 * 
 * input.list
 * input.step for everything except number
 * input.value for color
 * 
 * Later
 * audio
 *      source
 *      track
 * dialog
 * menu
 * menuitem
 * rp
 * rt
 * ruby
 */
