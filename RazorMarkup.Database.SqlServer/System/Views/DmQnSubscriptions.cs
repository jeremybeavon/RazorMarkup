using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmQnSubscriptions
    {
        public static readonly ViewName ViewName = new("sys.dm_qn_subscriptions");

        public static readonly Column<SqlDateTime> Created = new("created");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlInt> Timeout = new("timeout");
    }
}
