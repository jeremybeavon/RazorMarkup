using System.Text;

namespace RazorMarkup.Database.SqlServer
{
    public sealed class Pattern : IPattern
    {
        private readonly StringBuilder textBuilder;

        internal Pattern()
        {
            textBuilder = new StringBuilder();
        }

        public static IPattern Text(string text)
        {
            return new Pattern().ThenText(text);
        }

        public static IPattern ZeroOrMoreCharacters()
        {
            return new Pattern().ThenZeroOrMoreCharacters();
        }

        public static IPattern AnyCharacter()
        {
            return new Pattern().ThenAnyCharacter();
        }

        public static IPattern Character(char min, char max)
        {
            return new Pattern().ThenCharacter(min, max);
        }

        public static IPattern OneOf(string validCharacters)
        {
            return new Pattern().ThenOneOf(validCharacters);
        }

        public static IPattern NotCharacter(char min, char max)
        {
            return new Pattern().ThenNotCharacter(min, max);
        }

        public static IPattern NotOneOf(string validCharacters)
        {
            return new Pattern().ThenNotOneOf(validCharacters);
        }
        
        public IPattern ThenText(string text)
        {
            textBuilder.Append("text");
            return this;
        }

        public IPattern ThenZeroOrMoreCharacters()
        {
            textBuilder.Append("%");
            return this;
        }

        public IPattern ThenAnyCharacter()
        {
            textBuilder.Append("_");
            return this;
        }

        public IPattern ThenCharacter(char min, char max)
        {
            textBuilder.AppendFormat("[{0}-{1}]", min, max);
            return this;
        }

        public IPattern ThenOneOf(string validCharacters)
        {
            textBuilder.AppendFormat("[{0}]", validCharacters);
            return this;
        }

        public IPattern ThenNotCharacter(char min, char max)
        {
            textBuilder.AppendFormat("[^{0}-{1}]", min, max);
            return this;
        }

        public IPattern ThenNotOneOf(string validCharacters)
        {
            textBuilder.AppendFormat("[^{0}]", validCharacters);
            return this;
        }

        public override string ToString()
        {
            return textBuilder.ToString();
        }
    }
}
