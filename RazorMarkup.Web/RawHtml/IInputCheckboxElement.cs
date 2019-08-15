namespace RazorMarkup.Web.RawHtml
{
    public interface IInputCheckboxElement : IInputElement<IInputCheckboxElement>
    {
        IInputCheckboxElement WithChecked();

        IInputCheckboxElement WithDisabled();

        IInputCheckboxElement WithValue(string value);
    }
}
