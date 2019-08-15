using System;

namespace RazorMarkup.Web
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class BrowserCompatibilityAttribute : Attribute
    {
        public BrowserCompatibilityAttribute(BrowserType browserType)
        {
            BrowserType = browserType;
            IsSupported = true;
        }

        public BrowserType BrowserType { get; private set; }

        public double MinimumVersion { get; set; }

        public bool IsSupported { get; set; }
    }
}
