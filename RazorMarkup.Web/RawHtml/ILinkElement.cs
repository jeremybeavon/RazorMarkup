using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface ILinkElement : IHtmlElement<ILinkElement>
    {
        ILinkElement WithUrl(string url);

        ILinkElement WithUrlLanguage(LanguageCode languageCode);

        ILinkElement WithMedia(IMediaOperator media);

        ILinkElement WithMediaType(string mediaType);
    }
}
