using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlTimestamp : ISqlDateTimeType
    {
        public static implicit operator SqlTimestamp(DateTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlDecimal(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNumeric(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBigInt(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlInt(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallInt(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTinyInt(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlMoney(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallMoney(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBit(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlImage(SqlTimestamp value)
        {
            throw new NotInExpressionException();
        }
    }
}
