using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SecurableClasses
    {
        public static readonly ViewName ViewName = new ViewName("sys.securable_classes");
        
        public static readonly Column<SqlInt> Class = new Column<SqlInt>("class");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
    }
}
