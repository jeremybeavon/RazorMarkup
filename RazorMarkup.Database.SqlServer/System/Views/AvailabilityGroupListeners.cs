using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityGroupListeners
    {
        public static readonly ViewName ViewName = new ViewName("sys.availability_group_listeners");

        public static readonly Column<SqlUniqueIdentifier, AvailabilityGroups> GroupId =
            new Column<SqlUniqueIdentifier, AvailabilityGroups>("group_id");

        public static readonly Column<SqlNVarchar> ListenerId = new Column<SqlNVarchar>("listener_id");

        public static readonly Column<SqlNVarchar> DnsName = new Column<SqlNVarchar>("dns_name");

        public static readonly Column<SqlInt> Port = new Column<SqlInt>("port");

        public static readonly Column<SqlBit> IsConformant = new Column<SqlBit>("is_conformant");

        public static readonly Column<SqlNVarchar> IpConfigurationStringFromCluster =
            new Column<SqlNVarchar>("ip_configuration_string_from_cluster");
    }
}
