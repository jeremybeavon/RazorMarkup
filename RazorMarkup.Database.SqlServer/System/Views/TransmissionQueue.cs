using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TransmissionQueue
    {
        public static readonly ViewName ViewName = new("sys.transmission_queue");

        public static readonly Column<SqlUniqueIdentifier> ConversationHandle = new("conversation_handle");

        public static readonly Column<SqlDateTime> EnqueueTime = new("enqueue_time");

        public static readonly Column<SqlNVarchar> FromServiceName = new("from_service_name");

        public static readonly Column<SqlBit> IsConversationError = new("is_conversation_error");

        public static readonly Column<SqlBit> IsEndOfDialog = new("is_end_of_dialog");

        public static readonly Column<SqlVarbinary> MessageBody = new("message_body");

        public static readonly Column<SqlBigInt> MessageSequenceNumber = new("message_sequence_number");

        public static readonly Column<SqlNVarchar> MessageTypeName = new("message_type_name");

        public static readonly Column<SqlTinyInt> Priority = new("priority");

        public static readonly Column<SqlNVarchar> ServiceContractName = new("service_contract_name");

        public static readonly Column<SqlNVarchar> ToBrokerInstance = new("to_broker_instance");

        public static readonly Column<SqlNVarchar> ToServiceName = new("to_service_name");

        public static readonly Column<SqlNVarchar> TransmissionStatus = new("transmission_status");
    }
}
