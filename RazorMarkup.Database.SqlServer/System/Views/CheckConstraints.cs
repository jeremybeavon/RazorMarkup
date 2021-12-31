using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class CheckConstraints
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.CHECK_CONSTRAINTS");

        public static readonly Column<SqlNVarchar> CheckClause = new("CHECK_CLAUSE");

        public static readonly Column<SqlNVarchar> ConstraintCatalog = new("CONSTRAINT_CATALOG");

        public static readonly Column<SqlSysname> ConstraintName = new("CONSTRAINT_NAME");

        public static readonly Column<SqlNVarchar> ConstraintSchema = new("CONSTRAINT_SCHEMA");
    }
}
