namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlText : ISqlAsciiCharacterStringType, ISqlNonMaxCharacterStringType
    {
        public static implicit operator SqlText(string value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNText(SqlText value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlText value)
        {
            throw new NotInExpressionException();
        }
    }
}
