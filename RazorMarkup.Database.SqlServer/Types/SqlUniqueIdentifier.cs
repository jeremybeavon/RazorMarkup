using System;

namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlUniqueIdentifier : ISqlType
    {
        public static implicit operator SqlUniqueIdentifier(Guid value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlBinary(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinary(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarbinaryMax(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlChar(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarchar(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVarcharMax(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNChar(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarchar(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlNVarcharMax(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }

        public static implicit operator SqlVariant(SqlUniqueIdentifier value)
        {
            throw new NotInExpressionException();
        }
    }
}
