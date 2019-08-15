namespace RazorMarkup.Web.RawHtml
{
    public interface IInputPasswordElement : IInputElement<IInputPasswordElement>
    {
        IInputPasswordElement WithDisabled();

        IInputPasswordElement WithWidth(int numberOfCharacters);

        IInputPasswordElement WithValue(string value);
    }
}
