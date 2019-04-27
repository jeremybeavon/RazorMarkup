namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlNumeric : ISqlNumericType
    {
        public static implicit operator SqlNumeric(decimal value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlFloat(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlReal(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlNumeric value)
        {
            throw new NotInExpressionException();
        }
    }
}
