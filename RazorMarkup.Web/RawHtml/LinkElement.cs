namespace RazorMarkup.Web.RawHtml
{
    internal sealed class LinkElement : AbstractHtmlElement<ILinkElement>, ILinkElement
    {
        public const string DefaultRelationshipType = "stylesheet";

        public LinkElement()
            : this(DefaultRelationshipType)
        {
        }

        public LinkElement(string relationshipType)
            : base("link", true)
        {
            AddAttribute("rel", relationshipType);
        }

        public ILinkElement WithUrl(string url)
        {
            return AddAttribute("href", url);
        }

        public ILinkElement WithUrlLanguage(LanguageCode languageCode)
        {
            return AddAttribute("hreflang", languageCode.ToHtmlString());
        }

        public ILinkElement WithMedia(IMediaOperator media)
        {
            return AddAttribute("media", media.ToHtmlString());
        }

        public ILinkElement WithMediaType(string mediaType)
        {
            return AddAttribute("type", mediaType);
        }
    }
}
