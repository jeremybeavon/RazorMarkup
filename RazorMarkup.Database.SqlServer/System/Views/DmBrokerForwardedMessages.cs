using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmBrokerForwardedMessages
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_broker_forwarded_messages");
        
        public static readonly Column<SqlNVarchar> AdjacentBrokerAddress = new Column<SqlNVarchar>("adjacent_broker_address");
        
        public static readonly Column<SqlUniqueIdentifier> ConversationId = new Column<SqlUniqueIdentifier>("conversation_id");
        
        public static readonly Column<SqlNVarchar> FromBrokerInstance = new Column<SqlNVarchar>("from_broker_instance");
        
        public static readonly Column<SqlNVarchar> FromServiceName = new Column<SqlNVarchar>("from_service_name");
        
        public static readonly Column<SqlTinyInt> HopsRemaining = new Column<SqlTinyInt>("hops_remaining");
        
        public static readonly Column<SqlBit> IsInitiator = new Column<SqlBit>("is_initiator");
        
        public static readonly Column<SqlInt> MessageFragmentNumber = new Column<SqlInt>("message_fragment_number");
        
        public static readonly Column<SqlUniqueIdentifier> MessageId = new Column<SqlUniqueIdentifier>("message_id");
        
        public static readonly Column<SqlBigInt> MessageSequenceNumber = new Column<SqlBigInt>("message_sequence_number");
        
        public static readonly Column<SqlInt> TimeConsumed = new Column<SqlInt>("time_consumed");
        
        public static readonly Column<SqlInt> TimeToLive = new Column<SqlInt>("time_to_live");
        
        public static readonly Column<SqlNVarchar> ToBrokerInstance = new Column<SqlNVarchar>("to_broker_instance");
        
        public static readonly Column<SqlNVarchar> ToServiceName = new Column<SqlNVarchar>("to_service_name");
    }
}
