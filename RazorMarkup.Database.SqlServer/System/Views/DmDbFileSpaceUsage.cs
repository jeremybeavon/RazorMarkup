using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbFileSpaceUsage
    {
        public static readonly ViewName ViewName = new("sys.dm_db_file_space_usage");

        public static readonly Column<SqlBigInt> AllocatedExtentPageCount = new("allocated_extent_page_count");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlSmallInt> FileId = new("file_id");

        public static readonly Column<SqlSmallInt> FilegroupId = new("filegroup_id");

        public static readonly Column<SqlBigInt> InternalObjectReservedPageCount = new("internal_object_reserved_page_count");

        public static readonly Column<SqlBigInt> MixedExtentPageCount = new("mixed_extent_page_count");

        public static readonly Column<SqlBigInt> TotalPageCount = new("total_page_count");

        public static readonly Column<SqlBigInt> UnallocatedExtentPageCount = new("unallocated_extent_page_count");

        public static readonly Column<SqlBigInt> UserObjectReservedPageCount = new("user_object_reserved_page_count");

        public static readonly Column<SqlBigInt> VersionStoreReservedPageCount = new("version_store_reserved_page_count");
    }
}
