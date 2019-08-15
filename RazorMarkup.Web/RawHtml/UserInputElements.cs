using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class UserInputElements : IUserInputElements
    {
        public IInputCheckboxElement Checkbox()
        {
            return new InputCheckboxElement();
        }

        public IInputFileElement File()
        {
            return new InputFileElement();
        }

        public IInputPasswordElement Password()
        {
            return new InputPasswordElement();
        }

        public IInputRadioButtonElement RadioButton(string value)
        {
            return new InputRadioButtonElement(value);
        }

        public IInputTextElement Text()
        {
            return new InputTextElement();
        }

        public IMultiLineText MultiLineText()
        {
            return new MultiLineText();
        }

        public IDropDown DropDown()
        {
            return new DropDown();
        }

        public IFormElement BeginForm()
        {
            return new FormElement();
        }

        public IHtmlString EndForm()
        {
            return new HtmlString("</form>");
        }
    }
}
