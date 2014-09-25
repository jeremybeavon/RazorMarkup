using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IButtonElements : IHideObjectMethods
    {
        IInputSubmitButtonElement Submit();

        IInputImageButtonElement Image(string imageUrl);

        IInputResetButtonElement Reset();

        IInputButtonElement Inline();

        IButtonElement Begin();

        IHtmlString End();
    }
}
