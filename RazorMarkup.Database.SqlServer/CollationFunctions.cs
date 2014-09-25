using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer
{
    public static class CollationFunctions
    {
        public static SqlVariant CollationProperty(SqlNVarchar collationName, SqlVarchar property) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary TertiaryWeights(ISqlAsciiCharacterStringType text)
        {
            throw new NotInExpressionException();
        }
    }
}
