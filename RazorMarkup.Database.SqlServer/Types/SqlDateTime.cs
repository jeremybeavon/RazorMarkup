using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlDateTime : ISqlDateTimeType
    {
        public static implicit operator SqlDateTime(DateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNumeric(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlFloat(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlReal(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBigInt(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlInt(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlSmallInt(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTinyInt(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlMoney(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlSmallMoney(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBit(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlDateTime value)
        {
            throw new NotInExpressionException();
        }
    }
}
