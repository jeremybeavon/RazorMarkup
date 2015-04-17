using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMirroringConnections
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_mirroring_connections");
        
        public static readonly Column<SqlNVarchar> AuthenticationMethod = new Column<SqlNVarchar>("authentication_method");
        
        public static readonly Column<SqlDateTime> ConnectTime = new Column<SqlDateTime>("connect_time");
        
        public static readonly Column<SqlUniqueIdentifier> ConnectionId = new Column<SqlUniqueIdentifier>("connection_id");
        
        public static readonly Column<SqlSmallInt> EncryptionAlgorithm = new Column<SqlSmallInt>("encryption_algorithm");
        
        public static readonly Column<SqlNVarchar> EncryptionAlgorithmDesc = new Column<SqlNVarchar>("encryption_algorithm_desc");
        
        public static readonly Column<SqlBit> IsAccept = new Column<SqlBit>("is_accept");
        
        public static readonly Column<SqlBit> IsReceiveFlowControlled = new Column<SqlBit>("is_receive_flow_controlled");
        
        public static readonly Column<SqlBit> IsSendFlowControlled = new Column<SqlBit>("is_send_flow_controlled");
        
        public static readonly Column<SqlDateTime> LastActivityTime = new Column<SqlDateTime>("last_activity_time");
        
        public static readonly Column<SqlSmallInt> LoginState = new Column<SqlSmallInt>("login_state");
        
        public static readonly Column<SqlNVarchar> LoginStateDesc = new Column<SqlNVarchar>("login_state_desc");
        
        public static readonly Column<SqlDateTime> LoginTime = new Column<SqlDateTime>("login_time");
        
        public static readonly Column<SqlUniqueIdentifier> PeerArbitrationId = new Column<SqlUniqueIdentifier>("peer_arbitration_id");
        
        public static readonly Column<SqlInt> PeerCertificateId = new Column<SqlInt>("peer_certificate_id");
        
        public static readonly Column<SqlNVarchar> PrincipalName = new Column<SqlNVarchar>("principal_name");
        
        public static readonly Column<SqlSmallInt> ReceivesPosted = new Column<SqlSmallInt>("receives_posted");
        
        public static readonly Column<SqlNVarchar> RemoteUserName = new Column<SqlNVarchar>("remote_user_name");
        
        public static readonly Column<SqlSmallInt> SendsPosted = new Column<SqlSmallInt>("sends_posted");
        
        public static readonly Column<SqlSmallInt> State = new Column<SqlSmallInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlBigInt> TotalBytesReceived = new Column<SqlBigInt>("total_bytes_received");
        
        public static readonly Column<SqlBigInt> TotalBytesSent = new Column<SqlBigInt>("total_bytes_sent");
        
        public static readonly Column<SqlBigInt> TotalFragmentsReceived = new Column<SqlBigInt>("total_fragments_received");
        
        public static readonly Column<SqlBigInt> TotalFragmentsSent = new Column<SqlBigInt>("total_fragments_sent");
        
        public static readonly Column<SqlBigInt> TotalReceives = new Column<SqlBigInt>("total_receives");
        
        public static readonly Column<SqlBigInt> TotalSends = new Column<SqlBigInt>("total_sends");
        
        public static readonly Column<SqlUniqueIdentifier> TransportStreamId = new Column<SqlUniqueIdentifier>("transport_stream_id");
    }
}
