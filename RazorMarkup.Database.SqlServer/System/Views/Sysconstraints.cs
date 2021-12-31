using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysConstraints
    {
        public static readonly ViewName ViewName = new("sys.sysconstraints");

        public static readonly Column<SqlInt> Actions = new("actions");

        public static readonly Column<SqlSmallInt> Colid = new("colid");

        public static readonly Column<SqlInt> Constid = new("constid");

        public static readonly Column<SqlInt> Error = new("error");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlTinyInt> Spare1 = new("spare1");

        public static readonly Column<SqlInt> Status = new("status");
    }
}
