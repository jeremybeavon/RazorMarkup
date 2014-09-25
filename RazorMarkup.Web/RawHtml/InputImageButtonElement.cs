using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputImageButtonElement : AbstractInputElement<IInputImageButtonElement>, IInputImageButtonElement
    {
        public InputImageButtonElement(string imageUrl)
            : base("image")
        {
            AddAttribute("src", imageUrl);
        }

        public IInputImageButtonElement WithAlternateText(string text)
        {
            return AddAttribute("alt", text);
        }
        
        public IInputImageButtonElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputImageButtonElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
