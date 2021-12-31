using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCursorTables
    {
        public static readonly ViewName ViewName = new("sys.syscursortables");

        public static readonly Column<SqlInt> CursorHandle = new("cursor_handle");

        public static readonly Column<SqlInt> Dbid = new("dbid");

        public static readonly Column<SqlNVarchar> Dbname = new("dbname");

        public static readonly Column<SqlSmallInt> LockType = new("lock_type");

        public static readonly Column<SqlInt> Objectid = new("objectid");

        public static readonly Column<SqlSmallInt> OptimizerHint = new("optimizer_hint");

        public static readonly Column<SqlNVarchar> ServerName = new("server_name");

        public static readonly Column<SqlNVarchar> TableName = new("table_name");

        public static readonly Column<SqlNVarchar> TableOwner = new("table_owner");
    }
}
