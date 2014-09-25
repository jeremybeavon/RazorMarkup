using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlDateTimeOffset : ISqlDateTimeType
    {
        public static implicit operator SqlDateTimeOffset(DateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlTime(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlDateTimeOffset value)
        {
            throw new NotInExpressionException();
        }
    }
}
