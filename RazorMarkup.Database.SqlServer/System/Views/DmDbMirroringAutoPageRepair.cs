using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMirroringAutoPageRepair
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_mirroring_auto_page_repair");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlSmallInt> ErrorType = new Column<SqlSmallInt>("error_type");
        
        public static readonly Column<SqlInt> FileId = new Column<SqlInt>("file_id");
        
        public static readonly Column<SqlDateTime> ModificationTime = new Column<SqlDateTime>("modification_time");
        
        public static readonly Column<SqlBigInt> PageId = new Column<SqlBigInt>("page_id");
        
        public static readonly Column<SqlTinyInt> PageStatus = new Column<SqlTinyInt>("page_status");
    }
}
