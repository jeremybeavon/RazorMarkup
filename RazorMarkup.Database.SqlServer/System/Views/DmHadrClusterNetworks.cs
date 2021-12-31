using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrClusterNetworks
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_cluster_networks");

        public static readonly Column<SqlBit> IsIpv4 = new("is_ipv4");

        public static readonly Column<SqlBit> IsPublic = new("is_public");

        public static readonly Column<SqlNVarchar> MemberName = new("member_name");

        public static readonly Column<SqlNVarchar> NetworkSubnetIp = new("network_subnet_ip");

        public static readonly Column<SqlNVarchar> NetworkSubnetIpv4Mask = new("network_subnet_ipv4_mask");

        public static readonly Column<SqlInt> NetworkSubnetPrefixLength = new("network_subnet_prefix_length");
    }
}
