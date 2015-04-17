using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ConversationEndpoints
    {
        public static readonly ViewName ViewName = new ViewName("sys.conversation_endpoints");
        
        public static readonly Column<SqlUniqueIdentifier> ConversationGroupId = new Column<SqlUniqueIdentifier>("conversation_group_id");
        
        public static readonly Column<SqlUniqueIdentifier> ConversationHandle = new Column<SqlUniqueIdentifier>("conversation_handle");
        
        public static readonly Column<SqlUniqueIdentifier> ConversationId = new Column<SqlUniqueIdentifier>("conversation_id");
        
        public static readonly Column<SqlDateTime> DialogTimer = new Column<SqlDateTime>("dialog_timer");
        
        public static readonly Column<SqlBigInt> EndDialogSequence = new Column<SqlBigInt>("end_dialog_sequence");
        
        public static readonly Column<SqlNVarchar> FarBrokerInstance = new Column<SqlNVarchar>("far_broker_instance");
        
        public static readonly Column<SqlInt> FarPrincipalId = new Column<SqlInt>("far_principal_id");
        
        public static readonly Column<SqlNVarchar> FarService = new Column<SqlNVarchar>("far_service");
        
        public static readonly Column<SqlBigInt> FirstOutOfOrderSequence = new Column<SqlBigInt>("first_out_of_order_sequence");
        
        public static readonly Column<SqlUniqueIdentifier> InboundSessionKeyIdentifier = new Column<SqlUniqueIdentifier>("inbound_session_key_identifier");
        
        public static readonly Column<SqlBit> IsInitiator = new Column<SqlBit>("is_initiator");
        
        public static readonly Column<SqlBit> IsSystem = new Column<SqlBit>("is_system");
        
        public static readonly Column<SqlInt> LastOutOfOrderFrag = new Column<SqlInt>("last_out_of_order_frag");
        
        public static readonly Column<SqlBigInt> LastOutOfOrderSequence = new Column<SqlBigInt>("last_out_of_order_sequence");
        
        public static readonly Column<SqlBinary> LastSendTranId = new Column<SqlBinary>("last_send_tran_id");
        
        public static readonly Column<SqlDateTime> Lifetime = new Column<SqlDateTime>("lifetime");
        
        public static readonly Column<SqlUniqueIdentifier> OutboundSessionKeyIdentifier = new Column<SqlUniqueIdentifier>("outbound_session_key_identifier");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlTinyInt> Priority = new Column<SqlTinyInt>("priority");
        
        public static readonly Column<SqlBigInt> ReceiveSequence = new Column<SqlBigInt>("receive_sequence");
        
        public static readonly Column<SqlInt> ReceiveSequenceFrag = new Column<SqlInt>("receive_sequence_frag");
        
        public static readonly Column<SqlDateTime> SecurityTimestamp = new Column<SqlDateTime>("security_timestamp");
        
        public static readonly Column<SqlBigInt> SendSequence = new Column<SqlBigInt>("send_sequence");
        
        public static readonly Column<SqlInt> ServiceContractId = new Column<SqlInt>("service_contract_id");
        
        public static readonly Column<SqlInt> ServiceId = new Column<SqlInt>("service_id");
        
        public static readonly Column<SqlChar> State = new Column<SqlChar>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlBigInt> SystemSequence = new Column<SqlBigInt>("system_sequence");
    }
}
