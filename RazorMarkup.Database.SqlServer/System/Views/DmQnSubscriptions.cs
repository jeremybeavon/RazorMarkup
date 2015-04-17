using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmQnSubscriptions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_qn_subscriptions");
        
        public static readonly Column<SqlDateTime> Created = new Column<SqlDateTime>("created");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlInt> Timeout = new Column<SqlInt>("timeout");
    }
}
