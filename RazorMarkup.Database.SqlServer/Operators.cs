using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class Operators
    {
        public static bool Like(this ISqlCharacterStringType text, Text pattern, char? escapeCharacter = null)
        {
            throw new NotInExpressionException();
        }

        public static bool NotLike(this ISqlCharacterStringType text, Text pattern, char? escapeCharacter = null)
        {
            throw new NotInExpressionException();
        }

        public static bool Like(this ISqlCharacterStringType text, IPattern pattern, char? escapeCharacter = null)
        {
            throw new NotInExpressionException();
        }

        public static bool NotLike(this ISqlCharacterStringType text, IPattern pattern, char? escapeCharacter = null)
        {
            throw new NotInExpressionException();
        }
    }
}
