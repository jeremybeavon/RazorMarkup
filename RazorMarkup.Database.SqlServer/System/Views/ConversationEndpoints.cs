using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ConversationEndpoints
    {
        public static readonly ViewName ViewName = new("sys.conversation_endpoints");

        public static readonly Column<SqlUniqueIdentifier> ConversationGroupId = new("conversation_group_id");

        public static readonly Column<SqlUniqueIdentifier> ConversationHandle = new("conversation_handle");

        public static readonly Column<SqlUniqueIdentifier> ConversationId = new("conversation_id");

        public static readonly Column<SqlDateTime> DialogTimer = new("dialog_timer");

        public static readonly Column<SqlBigInt> EndDialogSequence = new("end_dialog_sequence");

        public static readonly Column<SqlNVarchar> FarBrokerInstance = new("far_broker_instance");

        public static readonly Column<SqlInt> FarPrincipalId = new("far_principal_id");

        public static readonly Column<SqlNVarchar> FarService = new("far_service");

        public static readonly Column<SqlBigInt> FirstOutOfOrderSequence = new("first_out_of_order_sequence");

        public static readonly Column<SqlUniqueIdentifier> InboundSessionKeyIdentifier = new("inbound_session_key_identifier");

        public static readonly Column<SqlBit> IsInitiator = new("is_initiator");

        public static readonly Column<SqlBit> IsSystem = new("is_system");

        public static readonly Column<SqlInt> LastOutOfOrderFrag = new("last_out_of_order_frag");

        public static readonly Column<SqlBigInt> LastOutOfOrderSequence = new("last_out_of_order_sequence");

        public static readonly Column<SqlBinary> LastSendTranId = new("last_send_tran_id");

        public static readonly Column<SqlDateTime> Lifetime = new("lifetime");

        public static readonly Column<SqlUniqueIdentifier> OutboundSessionKeyIdentifier = new("outbound_session_key_identifier");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlTinyInt> Priority = new("priority");

        public static readonly Column<SqlBigInt> ReceiveSequence = new("receive_sequence");

        public static readonly Column<SqlInt> ReceiveSequenceFrag = new("receive_sequence_frag");

        public static readonly Column<SqlDateTime> SecurityTimestamp = new("security_timestamp");

        public static readonly Column<SqlBigInt> SendSequence = new("send_sequence");

        public static readonly Column<SqlInt> ServiceContractId = new("service_contract_id");

        public static readonly Column<SqlInt> ServiceId = new("service_id");

        public static readonly Column<SqlChar> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlBigInt> SystemSequence = new("system_sequence");
    }
}
