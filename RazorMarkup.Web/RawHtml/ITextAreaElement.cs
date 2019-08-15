namespace RazorMarkup.Web.RawHtml
{
    public interface ITextAreaElement : IHtmlElement<ITextAreaElement>
    {
        ITextAreaElement WithWidth(int numberOfCharacters);

        ITextAreaElement WithDisabled();

        ITextAreaElement WithReadOnly();

        ITextAreaElement WithHeight(int numberOfLines);
    }
}
