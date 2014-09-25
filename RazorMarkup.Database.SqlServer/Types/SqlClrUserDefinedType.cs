namespace RazorMarkup.Database.SqlServer.Types
{
    public abstract class SqlClrUserDefinedType : ISqlType
    {
        public static explicit operator SqlVarbinary(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlChar(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarchar(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarcharMax(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNChar(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNVarchar(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNVarcharMax(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlClrUserDefinedType value)
        {
            throw new NotInExpressionException();
        }
    }
}
