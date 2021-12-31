using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemComponentsSurfaceAreaConfiguration
    {
        public static readonly ViewName ViewName = new("sys.system_components_surface_area_configuration");

        public static readonly Column<SqlSysname> ComponentName = new("component_name");

        public static readonly Column<SqlSysname> DatabaseName = new("database_name");

        public static readonly Column<SqlNVarchar> ObjectName = new("object_name");

        public static readonly Column<SqlNVarchar> SchemaName = new("schema_name");

        public static readonly Column<SqlTinyInt> State = new("state");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
