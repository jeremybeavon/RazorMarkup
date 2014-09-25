using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IParameterElement : IHtmlElement<IParameterElement>
    {
        IParameterElement WithName(string name);

        IParameterElement WithValue(string value);
    }
}
