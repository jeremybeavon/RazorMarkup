using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class KeyColumnUsage
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.KEY_COLUMN_USAGE");
        
        public static readonly Column<SqlNVarchar> ColumnName = new Column<SqlNVarchar>("COLUMN_NAME");
        
        public static readonly Column<SqlNVarchar> ConstraintCatalog = new Column<SqlNVarchar>("CONSTRAINT_CATALOG");
        
        public static readonly Column<SqlSysname> ConstraintName = new Column<SqlSysname>("CONSTRAINT_NAME");
        
        public static readonly Column<SqlNVarchar> ConstraintSchema = new Column<SqlNVarchar>("CONSTRAINT_SCHEMA");
        
        public static readonly Column<SqlInt> OrdinalPosition = new Column<SqlInt>("ORDINAL_POSITION");
        
        public static readonly Column<SqlNVarchar> TableCatalog = new Column<SqlNVarchar>("TABLE_CATALOG");
        
        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");
        
        public static readonly Column<SqlNVarchar> TableSchema = new Column<SqlNVarchar>("TABLE_SCHEMA");
    }
}
