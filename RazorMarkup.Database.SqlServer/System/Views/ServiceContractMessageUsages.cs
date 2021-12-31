using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceContractMessageUsages
    {
        public static readonly ViewName ViewName = new("sys.service_contract_message_usages");

        public static readonly Column<SqlBit> IsSentByInitiator = new("is_sent_by_initiator");

        public static readonly Column<SqlBit> IsSentByTarget = new("is_sent_by_target");

        public static readonly Column<SqlInt> MessageTypeId = new("message_type_id");

        public static readonly Column<SqlInt> ServiceContractId = new("service_contract_id");
    }
}
