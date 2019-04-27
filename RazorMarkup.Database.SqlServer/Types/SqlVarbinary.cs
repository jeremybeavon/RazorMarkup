namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlVarbinary : ISqlBinaryType
    {
        public static implicit operator SqlVarbinary(byte[] value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTimestamp(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlImage(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlVarbinary value)
        {
            throw new NotInExpressionException();
        }
    }
}
