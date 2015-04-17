using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TransmissionQueue
    {
        public static readonly ViewName ViewName = new ViewName("sys.transmission_queue");
        
        public static readonly Column<SqlUniqueIdentifier> ConversationHandle = new Column<SqlUniqueIdentifier>("conversation_handle");
        
        public static readonly Column<SqlDateTime> EnqueueTime = new Column<SqlDateTime>("enqueue_time");
        
        public static readonly Column<SqlNVarchar> FromServiceName = new Column<SqlNVarchar>("from_service_name");
        
        public static readonly Column<SqlBit> IsConversationError = new Column<SqlBit>("is_conversation_error");
        
        public static readonly Column<SqlBit> IsEndOfDialog = new Column<SqlBit>("is_end_of_dialog");
        
        public static readonly Column<SqlVarbinary> MessageBody = new Column<SqlVarbinary>("message_body");
        
        public static readonly Column<SqlBigInt> MessageSequenceNumber = new Column<SqlBigInt>("message_sequence_number");
        
        public static readonly Column<SqlNVarchar> MessageTypeName = new Column<SqlNVarchar>("message_type_name");
        
        public static readonly Column<SqlTinyInt> Priority = new Column<SqlTinyInt>("priority");
        
        public static readonly Column<SqlNVarchar> ServiceContractName = new Column<SqlNVarchar>("service_contract_name");
        
        public static readonly Column<SqlNVarchar> ToBrokerInstance = new Column<SqlNVarchar>("to_broker_instance");
        
        public static readonly Column<SqlNVarchar> ToServiceName = new Column<SqlNVarchar>("to_service_name");
        
        public static readonly Column<SqlNVarchar> TransmissionStatus = new Column<SqlNVarchar>("transmission_status");
    }
}
