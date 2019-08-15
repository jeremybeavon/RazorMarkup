using System.Web;

namespace RazorMarkup.Web.Css
{
    public sealed class CssColor : HtmlString
    {
        /// <summary>
        /// The initial keyword is used to set a CSS property to its default value.
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 19.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 1.2)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 15.0)]
        public static readonly CssColor Initial = new CssColor("initial");

        /// <summary>
        /// The inherit keyword specifies that a property should inherit its value from its parent element.
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 8.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 1.0)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 4.0)]
        public static readonly CssColor Inherit = new CssColor("inherit");

        public CssColor(string html)
            : base(html)
        {
        }

        public static CssColor Hexadecimal(byte red, byte green, byte blue)
        {
            return new CssColor(string.Concat("#", red, green, blue));
        }

        public static CssColor Rgb(byte red, byte green, byte blue)
        {
            return new CssColor(string.Format("rgb({0},{1},{2})", red, green, blue));
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 3.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 10.0)]
        public static CssColor Rgba(byte red, byte green, byte blue, double alpha)
        {
            return new CssColor(string.Format("rgba({0},{1},{2},{3})", red, green, blue, alpha));
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 10.0)]
        public static CssColor Hsl(short hue, byte saturationPercentage, byte lightnessPercentage)
        {
            return new CssColor(string.Format("hsl({0},{1}%,{2}%)", hue, saturationPercentage, lightnessPercentage));
        }

        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 3.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 10.0)]
        public static CssColor Hsla(string hue, byte saturationPercentage, byte lightnessPercentage, double opacity)
        {
            return new CssColor(string.Format("hsla({0},{1}%,{2}%,{3})", hue, saturationPercentage, lightnessPercentage, opacity));
        }
    }
}
