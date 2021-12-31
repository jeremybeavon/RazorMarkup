using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecConnections
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_connections");

        public static readonly Column<SqlNVarchar> AuthScheme = new("auth_scheme");

        public static readonly Column<SqlVarchar> ClientNetAddress = new("client_net_address");

        public static readonly Column<SqlInt> ClientTcpPort = new("client_tcp_port");

        public static readonly Column<SqlDateTime> ConnectTime = new("connect_time");

        public static readonly Column<SqlUniqueIdentifier> ConnectionId = new("connection_id");

        public static readonly Column<SqlNVarchar> EncryptOption = new("encrypt_option");

        public static readonly Column<SqlInt> EndpointId = new("endpoint_id");

        public static readonly Column<SqlDateTime> LastRead = new("last_read");

        public static readonly Column<SqlDateTime> LastWrite = new("last_write");

        public static readonly Column<SqlVarchar> LocalNetAddress = new("local_net_address");

        public static readonly Column<SqlInt> LocalTcpPort = new("local_tcp_port");

        public static readonly Column<SqlInt> MostRecentSessionId = new("most_recent_session_id");

        public static readonly Column<SqlVarbinary> MostRecentSqlHandle = new("most_recent_sql_handle");

        public static readonly Column<SqlInt> NetPacketSize = new("net_packet_size");

        public static readonly Column<SqlNVarchar> NetTransport = new("net_transport");

        public static readonly Column<SqlSmallInt> NodeAffinity = new("node_affinity");

        public static readonly Column<SqlInt> NumReads = new("num_reads");

        public static readonly Column<SqlInt> NumWrites = new("num_writes");

        public static readonly Column<SqlUniqueIdentifier> ParentConnectionId = new("parent_connection_id");

        public static readonly Column<SqlNVarchar> ProtocolType = new("protocol_type");

        public static readonly Column<SqlInt> ProtocolVersion = new("protocol_version");

        public static readonly Column<SqlInt> SessionId = new("session_id");
    }
}
