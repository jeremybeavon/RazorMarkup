using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInputTextElement : IInputElement<IInputTextElement>
    {
        IInputTextElement WithDisabled();

        IInputTextElement WithWidth(int numberOfCharacters);

        IInputTextElement WithValue(string value);
    }
}
