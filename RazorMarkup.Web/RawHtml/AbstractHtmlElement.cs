using System.Text;

namespace RazorMarkup.Web.RawHtml
{
    public abstract class AbstractHtmlElement<TElement> : AbstractFluentHtmlString,
        IHtmlElement<TElement>
        where TElement : IHtmlElement<TElement>
    {
        private readonly StringBuilder textBuilder;
        private readonly bool isEmpty;

        protected AbstractHtmlElement(string elementName, bool isEmpty)
        {
            textBuilder = new StringBuilder("<" + elementName);
            this.isEmpty = isEmpty;
        }

        private TElement Element
        {
            get { return (TElement)(object)this; }
        }

        public override string ToHtmlString()
        {
            return string.Concat(textBuilder, ">");
        }

        public TElement AddAttribute(string name, string value)
        {
            textBuilder.Append(AttributeHelper.GetAttribute(name, value));
            return Element;
        }

        public TElement AddEmptyAttribute(string name)
        {
            textBuilder.Append(name);
            return Element;
        }

        public TElement WithClass(CssClass className)
        {
            return AddAttribute("class", className.ToHtmlString());
        }

        public TElement WithTextDirection(TextDirection textDirection)
        {
            return AddAttribute("dir", textDirection.ToHtmlString());
        }

        public TElement WithId(HtmlId id)
        {
            return AddAttribute("id", id.ToHtmlString());
        }

        public TElement WithLanguage(LanguageCode languageCode)
        {
            return AddAttribute("lang", languageCode.ToHtmlString());
        }

        public TElement WithStyle(string style)
        {
            return AddAttribute("style", style);
        }

        public TElement WithTitle(string title)
        {
            return AddAttribute("title", title);
        }
    }
}
