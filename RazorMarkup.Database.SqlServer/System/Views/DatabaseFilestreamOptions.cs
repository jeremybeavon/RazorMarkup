using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabaseFilestreamOptions
    {
        public static readonly ViewName ViewName = new("sys.database_filestream_options");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlNVarchar> DirectoryName = new("directory_name");

        public static readonly Column<SqlTinyInt> NonTransactedAccess = new("non_transacted_access");

        public static readonly Column<SqlNVarchar> NonTransactedAccessDesc = new("non_transacted_access_desc");
    }
}
