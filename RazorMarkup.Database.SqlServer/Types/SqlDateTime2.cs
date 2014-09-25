using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlDateTime2 : ISqlDateTimeType
    {
        public static implicit operator SqlDateTime2(DateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlDateTime2 value)
        {
            throw new NotInExpressionException();
        }
    }
}
