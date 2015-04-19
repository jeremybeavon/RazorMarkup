using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AvailabilityGroupListenerIpAddresses
    {
        public static readonly ViewName ViewName = new ViewName("sys.availability_group_listener_ip_addresses");

        public static readonly Column<SqlNVarchar> ListenerId = new Column<SqlNVarchar>("listener_id");

        public static readonly Column<SqlNVarchar> IpAddress = new Column<SqlNVarchar>("ip_address");

        public static readonly Column<SqlNVarchar> IpSubNetMask = new Column<SqlNVarchar>("ip_subnet_mask");

        public static readonly Column<SqlBit> IsDhcp = new Column<SqlBit>("is_dhcp");

        public static readonly Column<SqlNVarchar> NetworkSubnetIp = new Column<SqlNVarchar>("network_subnet_ip");

        public static readonly Column<SqlInt> NetworkSubnetPrefixLength = new Column<SqlInt>("network_subnet_prefix_length");

        public static readonly Column<SqlNVarchar> NetworkSubnetIpv4Mask = new Column<SqlNVarchar>("network_subnet_ipv4_mask");

        public static readonly Column<SqlTinyInt, AvailabilityGroupListenerIpAddressesState> State =
            new Column<SqlTinyInt, AvailabilityGroupListenerIpAddressesState>("state");

        public static readonly Column<SqlNVarchar, AvailabilityGroupListenerIpAddressesStateDescriptions> StateDescription =
            new Column<SqlNVarchar, AvailabilityGroupListenerIpAddressesStateDescriptions>("state_desc");
    }
}
