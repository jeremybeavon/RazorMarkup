using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInputImageButtonElement : IInputElement<IInputImageButtonElement>
    {
        IInputImageButtonElement WithAlternateText(string text);

        IInputImageButtonElement WithDisabled();

        IInputImageButtonElement WithValue(string value);
    }
}
