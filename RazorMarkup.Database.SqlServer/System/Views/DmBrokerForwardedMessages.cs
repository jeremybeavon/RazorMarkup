using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmBrokerForwardedMessages
    {
        public static readonly ViewName ViewName = new("sys.dm_broker_forwarded_messages");

        public static readonly Column<SqlNVarchar> AdjacentBrokerAddress = new("adjacent_broker_address");

        public static readonly Column<SqlUniqueIdentifier> ConversationId = new("conversation_id");

        public static readonly Column<SqlNVarchar> FromBrokerInstance = new("from_broker_instance");

        public static readonly Column<SqlNVarchar> FromServiceName = new("from_service_name");

        public static readonly Column<SqlTinyInt> HopsRemaining = new("hops_remaining");

        public static readonly Column<SqlBit> IsInitiator = new("is_initiator");

        public static readonly Column<SqlInt> MessageFragmentNumber = new("message_fragment_number");

        public static readonly Column<SqlUniqueIdentifier> MessageId = new("message_id");

        public static readonly Column<SqlBigInt> MessageSequenceNumber = new("message_sequence_number");

        public static readonly Column<SqlInt> TimeConsumed = new("time_consumed");

        public static readonly Column<SqlInt> TimeToLive = new("time_to_live");

        public static readonly Column<SqlNVarchar> ToBrokerInstance = new("to_broker_instance");

        public static readonly Column<SqlNVarchar> ToServiceName = new("to_service_name");
    }
}
