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
