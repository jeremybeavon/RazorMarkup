using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTcpListenerStates
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tcp_listener_states");
        
        public static readonly Column<SqlNVarchar> IpAddress = new Column<SqlNVarchar>("ip_address");
        
        public static readonly Column<SqlBit> IsIpv4 = new Column<SqlBit>("is_ipv4");
        
        public static readonly Column<SqlInt> ListenerId = new Column<SqlInt>("listener_id");
        
        public static readonly Column<SqlInt> Port = new Column<SqlInt>("port");
        
        public static readonly Column<SqlDateTime> StartTime = new Column<SqlDateTime>("start_time");
        
        public static readonly Column<SqlSmallInt> State = new Column<SqlSmallInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlSmallInt> Type = new Column<SqlSmallInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
