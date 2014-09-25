namespace RazorMarkup.Database.SqlServer.Types
{
    public sealed class SqlHierarchyId : ISqlType
    {
        public static explicit operator SqlVarbinary(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarbinaryMax(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlChar(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarchar(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlVarcharMax(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNChar(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNVarchar(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }

        public static explicit operator SqlNVarcharMax(SqlHierarchyId value)
        {
            throw new NotInExpressionException();
        }
    }
}
