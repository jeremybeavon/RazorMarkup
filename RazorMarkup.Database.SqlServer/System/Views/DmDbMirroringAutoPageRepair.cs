using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMirroringAutoPageRepair
    {
        public static readonly ViewName ViewName = new("sys.dm_db_mirroring_auto_page_repair");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlSmallInt> ErrorType = new("error_type");

        public static readonly Column<SqlInt> FileId = new("file_id");

        public static readonly Column<SqlDateTime> ModificationTime = new("modification_time");

        public static readonly Column<SqlBigInt> PageId = new("page_id");

        public static readonly Column<SqlTinyInt> PageStatus = new("page_status");
    }
}
