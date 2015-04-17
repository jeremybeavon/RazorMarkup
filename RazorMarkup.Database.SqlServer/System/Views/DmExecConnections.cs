using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecConnections
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_connections");
        
        public static readonly Column<SqlNVarchar> AuthScheme = new Column<SqlNVarchar>("auth_scheme");
        
        public static readonly Column<SqlVarchar> ClientNetAddress = new Column<SqlVarchar>("client_net_address");
        
        public static readonly Column<SqlInt> ClientTcpPort = new Column<SqlInt>("client_tcp_port");
        
        public static readonly Column<SqlDateTime> ConnectTime = new Column<SqlDateTime>("connect_time");
        
        public static readonly Column<SqlUniqueIdentifier> ConnectionId = new Column<SqlUniqueIdentifier>("connection_id");
        
        public static readonly Column<SqlNVarchar> EncryptOption = new Column<SqlNVarchar>("encrypt_option");
        
        public static readonly Column<SqlInt> EndpointId = new Column<SqlInt>("endpoint_id");
        
        public static readonly Column<SqlDateTime> LastRead = new Column<SqlDateTime>("last_read");
        
        public static readonly Column<SqlDateTime> LastWrite = new Column<SqlDateTime>("last_write");
        
        public static readonly Column<SqlVarchar> LocalNetAddress = new Column<SqlVarchar>("local_net_address");
        
        public static readonly Column<SqlInt> LocalTcpPort = new Column<SqlInt>("local_tcp_port");
        
        public static readonly Column<SqlInt> MostRecentSessionId = new Column<SqlInt>("most_recent_session_id");
        
        public static readonly Column<SqlVarbinary> MostRecentSqlHandle = new Column<SqlVarbinary>("most_recent_sql_handle");
        
        public static readonly Column<SqlInt> NetPacketSize = new Column<SqlInt>("net_packet_size");
        
        public static readonly Column<SqlNVarchar> NetTransport = new Column<SqlNVarchar>("net_transport");
        
        public static readonly Column<SqlSmallInt> NodeAffinity = new Column<SqlSmallInt>("node_affinity");
        
        public static readonly Column<SqlInt> NumReads = new Column<SqlInt>("num_reads");
        
        public static readonly Column<SqlInt> NumWrites = new Column<SqlInt>("num_writes");
        
        public static readonly Column<SqlUniqueIdentifier> ParentConnectionId = new Column<SqlUniqueIdentifier>("parent_connection_id");
        
        public static readonly Column<SqlNVarchar> ProtocolType = new Column<SqlNVarchar>("protocol_type");
        
        public static readonly Column<SqlInt> ProtocolVersion = new Column<SqlInt>("protocol_version");
        
        public static readonly Column<SqlInt> SessionId = new Column<SqlInt>("session_id");
    }
}
