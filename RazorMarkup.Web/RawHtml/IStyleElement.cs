using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IStyleElement : IHtmlElement<IStyleElement>
    {
        /// <summary>
        /// Specifies what media/device the media resource is optimized for
        /// </summary>
        IStyleElement WithMedia(IMediaOperator media);

        /// <summary>
        /// The Internet media type of the style sheet. For now, the only supported value is "text/css".
        /// </summary>
        IStyleElement WithType(string type);
    }
}
