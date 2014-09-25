using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer
{
    // Do later: Contains, Freetext
    public static class Predicates
    {
        public static bool IsNull<T>(this T value)
            where T : ISqlType
        {
            throw new NotInExpressionException();
        }

        public static bool IsNotNull<T>(this T value)
            where T : ISqlType
        {
            throw new NotInExpressionException();
        }
    }
}
