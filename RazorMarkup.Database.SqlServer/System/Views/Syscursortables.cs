using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCursorTables
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscursortables");
        
        public static readonly Column<SqlInt> CursorHandle = new Column<SqlInt>("cursor_handle");
        
        public static readonly Column<SqlInt> Dbid = new Column<SqlInt>("dbid");
        
        public static readonly Column<SqlNVarchar> Dbname = new Column<SqlNVarchar>("dbname");
        
        public static readonly Column<SqlSmallInt> LockType = new Column<SqlSmallInt>("lock_type");
        
        public static readonly Column<SqlInt> Objectid = new Column<SqlInt>("objectid");
        
        public static readonly Column<SqlSmallInt> OptimizerHint = new Column<SqlSmallInt>("optimizer_hint");
        
        public static readonly Column<SqlNVarchar> ServerName = new Column<SqlNVarchar>("server_name");
        
        public static readonly Column<SqlNVarchar> TableName = new Column<SqlNVarchar>("table_name");
        
        public static readonly Column<SqlNVarchar> TableOwner = new Column<SqlNVarchar>("table_owner");
    }
}
