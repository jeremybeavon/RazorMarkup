using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface ISelectElement : IHtmlElement<ISelectElement>
    {
        ISelectElement WithDisabled();

        ISelectElement WithMultipleSelections();

        ISelectElement WithName(string name);

        ISelectElement WithSize(int numberOfVisibleOptions);
    }
}
