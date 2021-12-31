using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysDepends
    {
        public static readonly ViewName ViewName = new("sys.sysdepends");

        public static readonly Column<SqlSmallInt> Depdbid = new("depdbid");

        public static readonly Column<SqlInt> Depid = new("depid");

        public static readonly Column<SqlSmallInt> Depnumber = new("depnumber");

        public static readonly Column<SqlSmallInt> Depsiteid = new("depsiteid");

        public static readonly Column<SqlTinyInt> Deptype = new("deptype");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlSmallInt> Number = new("number");

        public static readonly Column<SqlBit> Readobj = new("readobj");

        public static readonly Column<SqlBit> Resultobj = new("resultobj");

        public static readonly Column<SqlBit> Selall = new("selall");

        public static readonly Column<SqlSmallInt> Status = new("status");
    }
}
