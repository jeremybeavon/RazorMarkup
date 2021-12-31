using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTcpListenerStates
    {
        public static readonly ViewName ViewName = new("sys.dm_tcp_listener_states");

        public static readonly Column<SqlNVarchar> IpAddress = new("ip_address");

        public static readonly Column<SqlBit> IsIpv4 = new("is_ipv4");

        public static readonly Column<SqlInt> ListenerId = new("listener_id");

        public static readonly Column<SqlInt> Port = new("port");

        public static readonly Column<SqlDateTime> StartTime = new("start_time");

        public static readonly Column<SqlSmallInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlSmallInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
