using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlTime : ISqlDateTimeType
    {
        public static implicit operator SqlTime(DateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlTime value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlTime value)
        {
            throw new NotInExpressionException();
        }
    }
}
