using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    /// <summary>
    /// Common attributes added in HTML 5.
    /// </summary>
    /// <remarks>
    /// dropzone and translate are missing because there is no major browser that supports it.
    /// </remarks>
    public static class FluentHtmlStringExtensions
    {
        /// <summary>
        /// Specifies a shortcut key to activate/focus an element
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static TElement WithShortcutKey<TElement>(this TElement element, string shortcutKey)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("accesskey", shortcutKey);
        }

        /// <summary>
        /// Specifies the tabbing order of an element
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static TElement WithTabIndex<TElement>(this TElement element, int tabIndex)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("tabindex", tabIndex.ToString());
        }

        /// <summary>
        /// Specifies the content of an element is editable
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 5.5)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 3.5)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 3.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.6)]
        public static TElement WithContentEditable<TElement>(this TElement element)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("contenteditable", "true");
        }

        /// <summary>
        /// Specifies the content of an element is not editable
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 5.5)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 3.5)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 3.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.6)]
        public static TElement WithoutContentEditable<TElement>(this TElement element)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("contenteditable", "false");
        }

        /// <summary>
        /// Specifies a context menu for an element. The context menu appears when a user right-clicks on the element
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = false)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = false)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = false)]
        public static TElement WithContextMenu<TElement>(this TElement element, string contextMenuId)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("contextmenu", contextMenuId);
        }

        /// <summary>
        /// Used to store custom data private to the page or application
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 5.5)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 2.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 3.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 9.6)]
        public static TElement WithData<TElement>(this TElement element, string key, string value)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("data-" + key, value);
        }

        /// <summary>
        /// Specifies whether an element is draggable or not
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static TElement With<TElement>(this TElement element, DraggableBehaviour draggableBehaviour)
            where TElement : IHtmlElement<TElement>
        {
            string draggableText;
            switch (draggableBehaviour)
            {
                case DraggableBehaviour.DefaultBrowserBehaviour:
                    draggableText = "auto";
                    break;
                case DraggableBehaviour.CanBeDragged:
                    draggableText = "true";
                    break;
                case DraggableBehaviour.CannotBeDragged:
                    draggableText = "false";
                    break;
                default:
                    string message = "draggable behaviour not supported: " + draggableBehaviour;
                    throw new ArgumentException(message, "draggableBehaviour");
            }

            return element.AddAttribute("draggable", draggableText);
        }

        /// <summary>
        /// Specifies that an element is not yet, or is no longer, relevant
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 6.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 11.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 4.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 11.1)]
        public static TElement IsHidden<TElement>(this TElement element)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("hidden", "hidden");
        }

        /// <summary>
        /// Specifies whether the element is to have its spelling and grammar checked or not
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true, MinimumVersion = 9.0)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true, MinimumVersion = 10.0)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true, MinimumVersion = 2.0)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true, MinimumVersion = 5.1)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true, MinimumVersion = 10.5)]
        public static TElement HasSpellCheck<TElement>(this TElement element, bool spellCheck)
            where TElement : IHtmlElement<TElement>
        {
            return element.AddAttribute("spellcheck", spellCheck.ToString().ToLowerInvariant());
        }
    }
}
