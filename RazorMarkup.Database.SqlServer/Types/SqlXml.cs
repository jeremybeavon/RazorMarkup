namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlXml : ISqlType
    {
        public static explicit operator SqlVarbinary(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlChar(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarchar(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarcharMax(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNChar(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNVarchar(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNVarcharMax(SqlXml value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlXml value)
        {
            throw new NotInExpressionException();
        }
    }
}
