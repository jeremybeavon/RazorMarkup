namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlBit : ISqlType
    {
        public static implicit operator bool(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(bool value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTimestamp(SqlBit value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlBit value)
        {
            throw new NotInExpressionException();
        }
    }
}
