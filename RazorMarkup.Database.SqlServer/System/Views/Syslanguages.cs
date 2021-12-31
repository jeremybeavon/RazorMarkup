using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysLanguages
    {
        public static readonly ViewName ViewName = new("sys.syslanguages");

        public static readonly Column<SqlNVarchar> Alias = new("alias");

        public static readonly Column<SqlTinyInt> Datefirst = new("datefirst");

        public static readonly Column<SqlNChar> Dateformat = new("dateformat");

        public static readonly Column<SqlNVarchar> Days = new("days");

        public static readonly Column<SqlSmallInt> Langid = new("langid");

        public static readonly Column<SqlInt> Lcid = new("lcid");

        public static readonly Column<SqlNVarchar> Months = new("months");

        public static readonly Column<SqlSmallInt> Msglangid = new("msglangid");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlNVarchar> Shortmonths = new("shortmonths");

        public static readonly Column<SqlInt> Upgrade = new("upgrade");
    }
}
