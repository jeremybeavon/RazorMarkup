using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IPageLinkElement : IHtmlElement<IPageLinkElement>
    {
        IPageLinkElement WithUrl(string url);

        IPageLinkElement WithUrlLanguage(LanguageCode languageCode);

        IPageLinkElement WithRelationship(PageLinkRelationship relationship);

        IPageLinkElement WithTarget(PageLinkTarget target);

        IPageLinkElement WithShortcutKey(string shortcutKey);

        IPageLinkElement WithTabIndex(int tabIndex);
    }
}
