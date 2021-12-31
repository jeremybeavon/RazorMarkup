using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbSessionSpaceUsage
    {
        public static readonly ViewName ViewName = new("sys.dm_db_session_space_usage");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBigInt> InternalObjectsAllocPageCount = new("internal_objects_alloc_page_count");

        public static readonly Column<SqlBigInt> InternalObjectsDeallocPageCount = new("internal_objects_dealloc_page_count");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");

        public static readonly Column<SqlBigInt> UserObjectsAllocPageCount = new("user_objects_alloc_page_count");

        public static readonly Column<SqlBigInt> UserObjectsDeallocPageCount = new("user_objects_dealloc_page_count");
    }
}
