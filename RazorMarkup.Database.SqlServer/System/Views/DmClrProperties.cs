using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrProperties
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_clr_properties");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlNVarchar> Value = new Column<SqlNVarchar>("value");
    }
}
