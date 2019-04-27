namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlBinary : ISqlBinaryType
    {
        public static implicit operator SqlBinary(byte[] value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlBinary value)
        {
            throw new NotInExpressionException();
        }
        
        public static implicit operator SqlNVarchar(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDecimal(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTimestamp(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlUniqueIdentifier(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlImage(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlXml(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlClrUserDefinedType(SqlBinary value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlHierarchyId(SqlBinary value)
        {
            throw new NotInExpressionException();
        }
    }
}
