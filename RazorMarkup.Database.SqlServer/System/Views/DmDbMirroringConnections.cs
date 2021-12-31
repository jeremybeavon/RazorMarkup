using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMirroringConnections
    {
        public static readonly ViewName ViewName = new("sys.dm_db_mirroring_connections");

        public static readonly Column<SqlNVarchar> AuthenticationMethod = new("authentication_method");

        public static readonly Column<SqlDateTime> ConnectTime = new("connect_time");

        public static readonly Column<SqlUniqueIdentifier> ConnectionId = new("connection_id");

        public static readonly Column<SqlSmallInt> EncryptionAlgorithm = new("encryption_algorithm");

        public static readonly Column<SqlNVarchar> EncryptionAlgorithmDesc = new("encryption_algorithm_desc");

        public static readonly Column<SqlBit> IsAccept = new("is_accept");

        public static readonly Column<SqlBit> IsReceiveFlowControlled = new("is_receive_flow_controlled");

        public static readonly Column<SqlBit> IsSendFlowControlled = new("is_send_flow_controlled");

        public static readonly Column<SqlDateTime> LastActivityTime = new("last_activity_time");

        public static readonly Column<SqlSmallInt> LoginState = new("login_state");

        public static readonly Column<SqlNVarchar> LoginStateDesc = new("login_state_desc");

        public static readonly Column<SqlDateTime> LoginTime = new("login_time");

        public static readonly Column<SqlUniqueIdentifier> PeerArbitrationId = new("peer_arbitration_id");

        public static readonly Column<SqlInt> PeerCertificateId = new("peer_certificate_id");

        public static readonly Column<SqlNVarchar> PrincipalName = new("principal_name");

        public static readonly Column<SqlSmallInt> ReceivesPosted = new("receives_posted");

        public static readonly Column<SqlNVarchar> RemoteUserName = new("remote_user_name");

        public static readonly Column<SqlSmallInt> SendsPosted = new("sends_posted");

        public static readonly Column<SqlSmallInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlBigInt> TotalBytesReceived = new("total_bytes_received");

        public static readonly Column<SqlBigInt> TotalBytesSent = new("total_bytes_sent");

        public static readonly Column<SqlBigInt> TotalFragmentsReceived = new("total_fragments_received");

        public static readonly Column<SqlBigInt> TotalFragmentsSent = new("total_fragments_sent");

        public static readonly Column<SqlBigInt> TotalReceives = new("total_receives");

        public static readonly Column<SqlBigInt> TotalSends = new("total_sends");

        public static readonly Column<SqlUniqueIdentifier> TransportStreamId = new("transport_stream_id");
    }
}
