using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlDate : ISqlDateTimeType
    {
        public static implicit operator SqlDate(DateTime value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlBinary(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinary(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlSmallDateTime(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTimeOffset(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlDateTime2(SqlDate value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlDate value)
        {
            throw new NotInExpressionException();
        }
    }
}
