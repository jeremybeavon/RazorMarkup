using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmAuditClassTypeMap
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_audit_class_type_map");
        
        public static readonly Column<SqlVarchar> ClassType = new Column<SqlVarchar>("class_type");
        
        public static readonly Column<SqlNVarchar> ClassTypeDesc = new Column<SqlNVarchar>("class_type_desc");
        
        public static readonly Column<SqlNVarchar> SecurableClassDesc = new Column<SqlNVarchar>("securable_class_desc");
    }
}
