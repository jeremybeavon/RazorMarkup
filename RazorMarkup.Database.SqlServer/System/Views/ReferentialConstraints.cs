using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ReferentialConstraints
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS");
        
        public static readonly Column<SqlNVarchar> ConstraintCatalog = new Column<SqlNVarchar>("CONSTRAINT_CATALOG");
        
        public static readonly Column<SqlSysname> ConstraintName = new Column<SqlSysname>("CONSTRAINT_NAME");
        
        public static readonly Column<SqlNVarchar> ConstraintSchema = new Column<SqlNVarchar>("CONSTRAINT_SCHEMA");
        
        public static readonly Column<SqlVarchar> DeleteRule = new Column<SqlVarchar>("DELETE_RULE");
        
        public static readonly Column<SqlVarchar> MatchOption = new Column<SqlVarchar>("MATCH_OPTION");
        
        public static readonly Column<SqlNVarchar> UniqueConstraintCatalog = new Column<SqlNVarchar>("UNIQUE_CONSTRAINT_CATALOG");
        
        public static readonly Column<SqlSysname> UniqueConstraintName = new Column<SqlSysname>("UNIQUE_CONSTRAINT_NAME");
        
        public static readonly Column<SqlNVarchar> UniqueConstraintSchema = new Column<SqlNVarchar>("UNIQUE_CONSTRAINT_SCHEMA");
        
        public static readonly Column<SqlVarchar> UpdateRule = new Column<SqlVarchar>("UPDATE_RULE");
    }
}
