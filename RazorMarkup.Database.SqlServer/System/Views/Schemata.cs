using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Schemata
    {
        public static readonly ViewName ViewName = new("INFORMATION_SCHEMA.SCHEMATA");

        public static readonly Column<SqlNVarchar> CatalogName = new("CATALOG_NAME");

        public static readonly Column<SqlSysname> DefaultCharacterSetCatalog = new("DEFAULT_CHARACTER_SET_CATALOG");

        public static readonly Column<SqlSysname> DefaultCharacterSetName = new("DEFAULT_CHARACTER_SET_NAME");

        public static readonly Column<SqlSysname> DefaultCharacterSetSchema = new("DEFAULT_CHARACTER_SET_SCHEMA");

        public static readonly Column<SqlSysname> SchemaName = new("SCHEMA_NAME");

        public static readonly Column<SqlNVarchar> SchemaOwner = new("SCHEMA_OWNER");
    }
}
