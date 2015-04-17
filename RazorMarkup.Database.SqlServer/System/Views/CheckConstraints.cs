using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class CheckConstraints
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.CHECK_CONSTRAINTS");
        
        public static readonly Column<SqlNVarchar> CheckClause = new Column<SqlNVarchar>("CHECK_CLAUSE");
        
        public static readonly Column<SqlNVarchar> ConstraintCatalog = new Column<SqlNVarchar>("CONSTRAINT_CATALOG");
        
        public static readonly Column<SqlSysname> ConstraintName = new Column<SqlSysname>("CONSTRAINT_NAME");
        
        public static readonly Column<SqlNVarchar> ConstraintSchema = new Column<SqlNVarchar>("CONSTRAINT_SCHEMA");
    }
}
