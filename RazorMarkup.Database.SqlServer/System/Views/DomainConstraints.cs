using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DomainConstraints
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.DOMAIN_CONSTRAINTS");
        
        public static readonly Column<SqlNVarchar> ConstraintCatalog = new Column<SqlNVarchar>("CONSTRAINT_CATALOG");
        
        public static readonly Column<SqlSysname> ConstraintName = new Column<SqlSysname>("CONSTRAINT_NAME");
        
        public static readonly Column<SqlNVarchar> ConstraintSchema = new Column<SqlNVarchar>("CONSTRAINT_SCHEMA");
        
        public static readonly Column<SqlNVarchar> DomainCatalog = new Column<SqlNVarchar>("DOMAIN_CATALOG");
        
        public static readonly Column<SqlSysname> DomainName = new Column<SqlSysname>("DOMAIN_NAME");
        
        public static readonly Column<SqlNVarchar> DomainSchema = new Column<SqlNVarchar>("DOMAIN_SCHEMA");
        
        public static readonly Column<SqlVarchar> InitiallyDeferred = new Column<SqlVarchar>("INITIALLY_DEFERRED");
        
        public static readonly Column<SqlVarchar> IsDeferrable = new Column<SqlVarchar>("IS_DEFERRABLE");
    }
}
