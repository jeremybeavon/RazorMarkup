namespace RazorMarkup.Web.RawHtml
{
    public interface IInputButtonElement : IInputElement<IInputButtonElement>
    {
        IInputButtonElement WithDisabled();

        IInputButtonElement WithText(string text);
    }
}
