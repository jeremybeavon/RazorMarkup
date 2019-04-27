namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlNText : ISqlUnicodeCharacterStringType, ISqlNonMaxCharacterStringType
    {
        public static implicit operator SqlNText(string value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlNText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlNText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlNText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlNText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlNText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlNText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlText(SqlNText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlNText value)
        {
            throw new NotInExpressionException();
        }
    }
}
