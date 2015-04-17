using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TableConstraints
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.TABLE_CONSTRAINTS");
        
        public static readonly Column<SqlNVarchar> ConstraintCatalog = new Column<SqlNVarchar>("CONSTRAINT_CATALOG");
        
        public static readonly Column<SqlSysname> ConstraintName = new Column<SqlSysname>("CONSTRAINT_NAME");
        
        public static readonly Column<SqlNVarchar> ConstraintSchema = new Column<SqlNVarchar>("CONSTRAINT_SCHEMA");
        
        public static readonly Column<SqlVarchar> ConstraintType = new Column<SqlVarchar>("CONSTRAINT_TYPE");
        
        public static readonly Column<SqlVarchar> InitiallyDeferred = new Column<SqlVarchar>("INITIALLY_DEFERRED");
        
        public static readonly Column<SqlVarchar> IsDeferrable = new Column<SqlVarchar>("IS_DEFERRABLE");
        
        public static readonly Column<SqlNVarchar> TableCatalog = new Column<SqlNVarchar>("TABLE_CATALOG");
        
        public static readonly Column<SqlSysname> TableName = new Column<SqlSysname>("TABLE_NAME");
        
        public static readonly Column<SqlNVarchar> TableSchema = new Column<SqlNVarchar>("TABLE_SCHEMA");
    }
}
