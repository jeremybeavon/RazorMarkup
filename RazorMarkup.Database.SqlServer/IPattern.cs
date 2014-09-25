namespace RazorMarkup.Database.SqlServer
{
    public interface IPattern : IHideObjectMethods
    {
        IPattern ThenText(string text);

        IPattern ThenZeroOrMoreCharacters();

        IPattern ThenAnyCharacter();

        IPattern ThenCharacter(char min, char max);

        IPattern ThenOneOf(string validCharacters);

        IPattern ThenNotCharacter(char min, char max);

        IPattern ThenNotOneOf(string validCharacters);
    }
}
