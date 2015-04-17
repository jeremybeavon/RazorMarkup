using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceContractUsages
    {
        public static readonly ViewName ViewName = new ViewName("sys.service_contract_usages");
        
        public static readonly Column<SqlInt> ServiceContractId = new Column<SqlInt>("service_contract_id");
        
        public static readonly Column<SqlInt> ServiceId = new Column<SqlInt>("service_id");
    }
}
