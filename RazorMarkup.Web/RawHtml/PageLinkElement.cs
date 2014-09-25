using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class PageLinkElement : AbstractHtmlElement<IPageLinkElement>, IPageLinkElement
    {
        public PageLinkElement()
            : base("a", false)
        {
        }

        public IPageLinkElement WithUrl(string link)
        {
            return AddAttribute("href", link);
        }

        public IPageLinkElement WithUrlLanguage(LanguageCode languageCode)
        {
            return AddAttribute("hreflang", languageCode.ToHtmlString());
        }

        public IPageLinkElement WithRelationship(PageLinkRelationship relationship)
        {
            return AddAttribute("rel", relationship.ToHtmlString());
        }

        public IPageLinkElement WithTarget(PageLinkTarget target)
        {
            return AddAttribute("target", target.ToHtmlString());
        }

        public IPageLinkElement WithShortcutKey(string shortcutKey)
        {
            return AddAttribute("accesskey", shortcutKey);
        }

        public IPageLinkElement WithTabIndex(int tabIndex)
        {
            return AddAttribute("tabindex", tabIndex.ToString());
        }
    }
}
