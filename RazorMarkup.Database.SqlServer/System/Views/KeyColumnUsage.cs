using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class KeyColumnUsage
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.KEY_COLUMN_USAGE");

        public static readonly Column<SqlNVarchar> ColumnName = new("COLUMN_NAME");

        public static readonly Column<SqlNVarchar> ConstraintCatalog = new("CONSTRAINT_CATALOG");

        public static readonly Column<SqlSysname> ConstraintName = new("CONSTRAINT_NAME");

        public static readonly Column<SqlNVarchar> ConstraintSchema = new("CONSTRAINT_SCHEMA");

        public static readonly Column<SqlInt> OrdinalPosition = new("ORDINAL_POSITION");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlNVarchar> TableSchema = new("TABLE_SCHEMA");
    }
}
