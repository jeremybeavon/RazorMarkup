namespace RazorMarkup.Web.RawHtml
{
    public interface IInputTextElement : IInputElement<IInputTextElement>
    {
        IInputTextElement WithDisabled();

        IInputTextElement WithWidth(int numberOfCharacters);

        IInputTextElement WithValue(string value);
    }
}
