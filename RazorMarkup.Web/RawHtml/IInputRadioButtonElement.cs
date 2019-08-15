namespace RazorMarkup.Web.RawHtml
{
    public interface IInputRadioButtonElement : IInputElement<IInputRadioButtonElement>
    {
        IInputRadioButtonElement WithChecked();

        IInputRadioButtonElement WithDisabled();
    }
}
