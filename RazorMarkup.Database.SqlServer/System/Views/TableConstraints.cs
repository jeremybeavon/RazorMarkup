using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TableConstraints
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.TABLE_CONSTRAINTS");

        public static readonly Column<SqlNVarchar> ConstraintCatalog = new("CONSTRAINT_CATALOG");

        public static readonly Column<SqlSysname> ConstraintName = new("CONSTRAINT_NAME");

        public static readonly Column<SqlNVarchar> ConstraintSchema = new("CONSTRAINT_SCHEMA");

        public static readonly Column<SqlVarchar> ConstraintType = new("CONSTRAINT_TYPE");

        public static readonly Column<SqlVarchar> InitiallyDeferred = new("INITIALLY_DEFERRED");

        public static readonly Column<SqlVarchar> IsDeferrable = new("IS_DEFERRABLE");

        public static readonly Column<SqlNVarchar> TableCatalog = new("TABLE_CATALOG");

        public static readonly Column<SqlSysname> TableName = new("TABLE_NAME");

        public static readonly Column<SqlNVarchar> TableSchema = new("TABLE_SCHEMA");
    }
}
