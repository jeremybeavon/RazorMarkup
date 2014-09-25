using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface ITextAreaElement : IHtmlElement<ITextAreaElement>
    {
        ITextAreaElement WithWidth(int numberOfCharacters);

        ITextAreaElement WithDisabled();

        ITextAreaElement WithReadOnly();

        ITextAreaElement WithHeight(int numberOfLines);
    }
}
