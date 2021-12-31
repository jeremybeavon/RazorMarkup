using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrProperties
    {
        public static readonly ViewName ViewName = new("sys.dm_clr_properties");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlNVarchar> Value = new("value");
    }
}
