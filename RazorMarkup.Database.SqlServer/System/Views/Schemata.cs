using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Schemata
    {
        public static readonly ViewName ViewName = new ViewName("INFORMATION_SCHEMA.SCHEMATA");
        
        public static readonly Column<SqlNVarchar> CatalogName = new Column<SqlNVarchar>("CATALOG_NAME");
        
        public static readonly Column<SqlSysname> DefaultCharacterSetCatalog = new Column<SqlSysname>("DEFAULT_CHARACTER_SET_CATALOG");
        
        public static readonly Column<SqlSysname> DefaultCharacterSetName = new Column<SqlSysname>("DEFAULT_CHARACTER_SET_NAME");
        
        public static readonly Column<SqlSysname> DefaultCharacterSetSchema = new Column<SqlSysname>("DEFAULT_CHARACTER_SET_SCHEMA");
        
        public static readonly Column<SqlSysname> SchemaName = new Column<SqlSysname>("SCHEMA_NAME");
        
        public static readonly Column<SqlNVarchar> SchemaOwner = new Column<SqlNVarchar>("SCHEMA_OWNER");
    }
}
