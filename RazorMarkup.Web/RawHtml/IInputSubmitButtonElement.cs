namespace RazorMarkup.Web.RawHtml
{
    public interface IInputSubmitButtonElement : IInputElement<IInputSubmitButtonElement>
    {
        IInputSubmitButtonElement WithDisabled();

        IInputSubmitButtonElement WithText(string text);
    }
}
