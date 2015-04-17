using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemComponentsSurfaceAreaConfiguration
    {
        public static readonly ViewName ViewName = new ViewName("sys.system_components_surface_area_configuration");
        
        public static readonly Column<SqlSysname> ComponentName = new Column<SqlSysname>("component_name");
        
        public static readonly Column<SqlSysname> DatabaseName = new Column<SqlSysname>("database_name");
        
        public static readonly Column<SqlNVarchar> ObjectName = new Column<SqlNVarchar>("object_name");
        
        public static readonly Column<SqlNVarchar> SchemaName = new Column<SqlNVarchar>("schema_name");
        
        public static readonly Column<SqlTinyInt> State = new Column<SqlTinyInt>("state");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
