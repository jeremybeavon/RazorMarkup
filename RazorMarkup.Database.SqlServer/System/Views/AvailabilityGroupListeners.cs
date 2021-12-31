using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityGroupListeners
    {
        public static readonly ViewName ViewName = new("sys.availability_group_listeners");

        public static readonly Column<SqlUniqueIdentifier, AvailabilityGroups> GroupId =
            new("group_id");

        public static readonly Column<SqlNVarchar> ListenerId = new("listener_id");

        public static readonly Column<SqlNVarchar> DnsName = new("dns_name");

        public static readonly Column<SqlInt> Port = new("port");

        public static readonly Column<SqlBit> IsConformant = new("is_conformant");

        public static readonly Column<SqlNVarchar> IpConfigurationStringFromCluster =
            new("ip_configuration_string_from_cluster");
    }
}
