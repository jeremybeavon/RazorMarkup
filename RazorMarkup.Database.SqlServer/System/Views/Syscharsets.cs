using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCharSets
    {
        public static readonly ViewName ViewName = new("sys.syscharsets");

        public static readonly Column<SqlVarbinary> Binarydefinition = new("binarydefinition");

        public static readonly Column<SqlTinyInt> Csid = new("csid");

        public static readonly Column<SqlImage> Definition = new("definition");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlTinyInt> Id = new("id");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlSmallInt> Status = new("status");

        public static readonly Column<SqlSmallInt> Type = new("type");
    }
}
