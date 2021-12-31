using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrInstanceNodeMap
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_instance_node_map");

        public static readonly Column<SqlNVarchar> AgResourceId = new("ag_resource_id");

        public static readonly Column<SqlNVarchar> InstanceName = new("instance_name");

        public static readonly Column<SqlNVarchar> NodeName = new("node_name");
    }
}
