namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlImage : ISqlBinaryType
    {
        public static implicit operator SqlImage(byte[] value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlImage value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlImage value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlImage value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTimestamp(SqlImage value)
        {
            throw new NotInExpressionException();
        }
    }
}
