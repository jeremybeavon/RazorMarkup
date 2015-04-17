using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextCatalogs
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_catalogs");
        
        public static readonly Column<SqlInt> DataSpaceId = new Column<SqlInt>("data_space_id");
        
        public static readonly Column<SqlInt> FileId = new Column<SqlInt>("file_id");
        
        public static readonly Column<SqlInt> FulltextCatalogId = new Column<SqlInt>("fulltext_catalog_id");
        
        public static readonly Column<SqlBit> IsAccentSensitivityOn = new Column<SqlBit>("is_accent_sensitivity_on");
        
        public static readonly Column<SqlBit> IsDefault = new Column<SqlBit>("is_default");
        
        public static readonly Column<SqlBit> IsImporting = new Column<SqlBit>("is_importing");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlNVarchar> Path = new Column<SqlNVarchar>("path");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
    }
}
