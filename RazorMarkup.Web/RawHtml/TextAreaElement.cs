using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TextAreaElement : AbstractHtmlElement<ITextAreaElement>, ITextAreaElement
    {
        public TextAreaElement()
            : base("textarea", false)
        {
        }

        public ITextAreaElement WithWidth(int numberOfCharacters)
        {
            return AddAttribute("cols", numberOfCharacters.ToString());
        }

        public ITextAreaElement WithDisabled()
        {
            return AddEmptyAttribute("disabled");
        }

        public ITextAreaElement WithReadOnly()
        {
            return AddEmptyAttribute("readonly");
        }

        public ITextAreaElement WithHeight(int numberOfLines)
        {
            return AddAttribute("rows", numberOfLines.ToString());
        }
    }
}
