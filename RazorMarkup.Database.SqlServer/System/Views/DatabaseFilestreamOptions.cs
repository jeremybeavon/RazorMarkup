using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseFilestreamOptions
    {
        public static readonly ViewName ViewName = new ViewName("sys.database_filestream_options");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlNVarchar> DirectoryName = new Column<SqlNVarchar>("directory_name");
        
        public static readonly Column<SqlTinyInt> NonTransactedAccess = new Column<SqlTinyInt>("non_transacted_access");
        
        public static readonly Column<SqlNVarchar> NonTransactedAccessDesc = new Column<SqlNVarchar>("non_transacted_access_desc");
    }
}
