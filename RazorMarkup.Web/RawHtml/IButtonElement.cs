using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IButtonElement : IHtmlElement<IButtonElement>
    {
        IButtonElement WithDisabled();

        IButtonElement WithName(string name);

        IButtonElement WithValue(string value);

        IButtonElement WithType(ButtonType type);
    }
}
