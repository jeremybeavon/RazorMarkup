namespace RazorMarkup.Web.RawHtml
{
    public interface IInputResetButtonElement : IInputElement<IInputResetButtonElement>
    {
        IInputResetButtonElement WithDisabled();

        IInputResetButtonElement WithText(string text);
    }
}