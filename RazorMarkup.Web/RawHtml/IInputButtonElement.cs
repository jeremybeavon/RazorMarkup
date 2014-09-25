using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInputButtonElement : IInputElement<IInputButtonElement>
    {
        IInputButtonElement WithDisabled();

        IInputButtonElement WithText(string text);
    }
}
