using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextCatalogs
    {
        public static readonly ViewName ViewName = new("sys.fulltext_catalogs");

        public static readonly Column<SqlInt> DataSpaceId = new("data_space_id");

        public static readonly Column<SqlInt> FileId = new("file_id");

        public static readonly Column<SqlInt> FulltextCatalogId = new("fulltext_catalog_id");

        public static readonly Column<SqlBit> IsAccentSensitivityOn = new("is_accent_sensitivity_on");

        public static readonly Column<SqlBit> IsDefault = new("is_default");

        public static readonly Column<SqlBit> IsImporting = new("is_importing");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> Path = new("path");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");
    }
}
