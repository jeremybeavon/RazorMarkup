namespace RazorMarkup.Web.RawHtml
{
    public interface IInputImageButtonElement : IInputElement<IInputImageButtonElement>
    {
        IInputImageButtonElement WithAlternateText(string text);

        IInputImageButtonElement WithDisabled();

        IInputImageButtonElement WithValue(string value);
    }
}
