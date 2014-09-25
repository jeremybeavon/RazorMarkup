using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IUserInputElements : IHideObjectMethods
    {
        IInputCheckboxElement Checkbox();

        IInputFileElement File();

        IInputPasswordElement Password();

        IInputRadioButtonElement RadioButton(string value);

        IInputTextElement Text();

        IMultiLineText MultiLineText();

        IDropDown DropDown();

        IFormElement BeginForm();

        IHtmlString EndForm();
    }
}
