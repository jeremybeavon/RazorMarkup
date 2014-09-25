using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class DataTypeFunctions
    {
        public static SqlInt DataLength(ISqlType expression)
        {
            throw new NotInExpressionException();
        }

        public static SqlNumeric IdentityCurrent(SqlVarchar tableName)
        {
            throw new NotInExpressionException();
        }

        public static SqlNumeric IdentityIncrement(Text tableOrViewName)
        {
            throw new NotInExpressionException();
        }

        public static SqlNumeric IdentitySeed(Text tableOrViewName)
        {
            throw new NotInExpressionException();
        }

        public static T Identity<T>(T dataType)
            where T : ISqlIntegerType
        {
            throw new NotInExpressionException();
        }

        public static T Identity<T>(T dataType, T seed, T increment)
            where T : ISqlIntegerType
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant SqlVariantProperty(SqlVariant expression, SqlVarchar property) // Enum
        {
            throw new NotInExpressionException();
        }
    }
}
