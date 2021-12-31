using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysComments
    {
        public static readonly ViewName ViewName = new("sys.syscomments");

        public static readonly Column<SqlSmallInt> Colid = new("colid");

        public static readonly Column<SqlBit> Compressed = new("compressed");

        public static readonly Column<SqlVarbinary> Ctext = new("ctext");

        public static readonly Column<SqlBit> Encrypted = new("encrypted");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlSmallInt> Language = new("language");

        public static readonly Column<SqlSmallInt> Number = new("number");

        public static readonly Column<SqlSmallInt> Status = new("status");

        public static readonly Column<SqlNVarchar> Text = new("text");

        public static readonly Column<SqlSmallInt> Texttype = new("texttype");
    }
}
