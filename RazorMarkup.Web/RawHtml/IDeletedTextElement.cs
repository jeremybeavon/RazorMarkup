using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IDeletedTextElement : IHtmlElement<IDeletedTextElement>
    {
        /// <summary>
        /// Specifies a URL to a document that explains the reason why the text was deleted
        /// </summary>
        IDeletedTextElement WithCite(string url);

        /// <summary>
        /// Specifies the date and time of when the text was deleted
        /// </summary>
        IDeletedTextElement WithDateTime(DateTime deleteDate);
    }
}
