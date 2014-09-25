using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlSmallDateTime : ISqlDateTimeType
    {
        public static implicit operator SqlSmallDateTime(DateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDate(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNumeric(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlFloat(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlReal(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBigInt(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlInt(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlSmallInt(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTinyInt(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlMoney(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlSmallMoney(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBit(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlTimestamp(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlSmallDateTime value)
        {
            throw new NotInExpressionException();
        }
    }
}
