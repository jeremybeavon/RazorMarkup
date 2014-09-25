using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInputResetButtonElement : IInputElement<IInputResetButtonElement>
    {
        IInputResetButtonElement WithDisabled();

        IInputResetButtonElement WithText(string text);
    }
}