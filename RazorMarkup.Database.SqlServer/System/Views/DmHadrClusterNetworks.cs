using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrClusterNetworks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_cluster_networks");
        
        public static readonly Column<SqlBit> IsIpv4 = new Column<SqlBit>("is_ipv4");
        
        public static readonly Column<SqlBit> IsPublic = new Column<SqlBit>("is_public");
        
        public static readonly Column<SqlNVarchar> MemberName = new Column<SqlNVarchar>("member_name");
        
        public static readonly Column<SqlNVarchar> NetworkSubnetIp = new Column<SqlNVarchar>("network_subnet_ip");
        
        public static readonly Column<SqlNVarchar> NetworkSubnetIpv4Mask = new Column<SqlNVarchar>("network_subnet_ipv4_mask");
        
        public static readonly Column<SqlInt> NetworkSubnetPrefixLength = new Column<SqlInt>("network_subnet_prefix_length");
    }
}
