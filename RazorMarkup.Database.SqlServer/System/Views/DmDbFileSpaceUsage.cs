using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbFileSpaceUsage
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_file_space_usage");
        
        public static readonly Column<SqlBigInt> AllocatedExtentPageCount = new Column<SqlBigInt>("allocated_extent_page_count");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlSmallInt> FileId = new Column<SqlSmallInt>("file_id");
        
        public static readonly Column<SqlSmallInt> FilegroupId = new Column<SqlSmallInt>("filegroup_id");
        
        public static readonly Column<SqlBigInt> InternalObjectReservedPageCount = new Column<SqlBigInt>("internal_object_reserved_page_count");
        
        public static readonly Column<SqlBigInt> MixedExtentPageCount = new Column<SqlBigInt>("mixed_extent_page_count");
        
        public static readonly Column<SqlBigInt> TotalPageCount = new Column<SqlBigInt>("total_page_count");
        
        public static readonly Column<SqlBigInt> UnallocatedExtentPageCount = new Column<SqlBigInt>("unallocated_extent_page_count");
        
        public static readonly Column<SqlBigInt> UserObjectReservedPageCount = new Column<SqlBigInt>("user_object_reserved_page_count");
        
        public static readonly Column<SqlBigInt> VersionStoreReservedPageCount = new Column<SqlBigInt>("version_store_reserved_page_count");
    }
}
