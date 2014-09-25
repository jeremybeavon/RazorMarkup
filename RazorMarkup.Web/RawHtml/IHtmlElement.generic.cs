using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IHtmlElement<TElement> : IFluentHtmlString
        where TElement : IHtmlElement<TElement>
    {
        TElement WithClass(CssClass className);

        TElement WithTextDirection(TextDirection textDirection);

        TElement WithId(HtmlId id);

        TElement WithLanguage(LanguageCode languageCode);

        TElement WithStyle(string style);

        TElement WithTitle(string title);

        TElement AddAttribute(string name, string value);

        TElement AddEmptyAttribute(string name);
    }
}
