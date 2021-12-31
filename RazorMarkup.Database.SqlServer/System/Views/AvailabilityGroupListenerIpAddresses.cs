using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityGroupListenerIpAddresses
    {
        public static readonly ViewName ViewName = new("sys.availability_group_listener_ip_addresses");

        public static readonly Column<SqlNVarchar> ListenerId = new("listener_id");

        public static readonly Column<SqlNVarchar> IpAddress = new("ip_address");

        public static readonly Column<SqlNVarchar> IpSubNetMask = new("ip_subnet_mask");

        public static readonly Column<SqlBit> IsDhcp = new("is_dhcp");

        public static readonly Column<SqlNVarchar> NetworkSubnetIp = new("network_subnet_ip");

        public static readonly Column<SqlInt> NetworkSubnetPrefixLength = new("network_subnet_prefix_length");

        public static readonly Column<SqlNVarchar> NetworkSubnetIpv4Mask = new("network_subnet_ipv4_mask");

        public static readonly Column<SqlTinyInt, AvailabilityGroupListenerIpAddressesState> State =
            new("state");

        public static readonly Column<SqlNVarchar, AvailabilityGroupListenerIpAddressesStateDescriptions> StateDescription =
            new("state_desc");
    }
}
