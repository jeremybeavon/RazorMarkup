using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInputPasswordElement : IInputElement<IInputPasswordElement>
    {
        IInputPasswordElement WithDisabled();

        IInputPasswordElement WithWidth(int numberOfCharacters);

        IInputPasswordElement WithValue(string value);
    }
}
