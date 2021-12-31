using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Openkeys
    {
        public static readonly ViewName ViewName = new("sys.openkeys");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlNVarchar> DatabaseName = new("database_name");

        public static readonly Column<SqlUniqueIdentifier> KeyGuid = new("key_guid");

        public static readonly Column<SqlInt> KeyId = new("key_id");

        public static readonly Column<SqlNVarchar> KeyName = new("key_name");

        public static readonly Column<SqlDateTime> OpenedDate = new("opened_date");

        public static readonly Column<SqlSmallInt> Status = new("status");
    }
}
