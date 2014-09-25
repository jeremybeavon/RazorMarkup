using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInputSubmitButtonElement : IInputElement<IInputSubmitButtonElement>
    {
        IInputSubmitButtonElement WithDisabled();

        IInputSubmitButtonElement WithText(string text);
    }
}
