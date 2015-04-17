using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Openkeys
    {
        public static readonly ViewName ViewName = new ViewName("sys.openkeys");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlNVarchar> DatabaseName = new Column<SqlNVarchar>("database_name");
        
        public static readonly Column<SqlUniqueIdentifier> KeyGuid = new Column<SqlUniqueIdentifier>("key_guid");
        
        public static readonly Column<SqlInt> KeyId = new Column<SqlInt>("key_id");
        
        public static readonly Column<SqlNVarchar> KeyName = new Column<SqlNVarchar>("key_name");
        
        public static readonly Column<SqlDateTime> OpenedDate = new Column<SqlDateTime>("opened_date");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
    }
}
