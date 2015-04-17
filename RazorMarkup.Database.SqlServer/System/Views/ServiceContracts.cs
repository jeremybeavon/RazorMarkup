using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceContracts
    {
        public static readonly ViewName ViewName = new ViewName("sys.service_contracts");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> ServiceContractId = new Column<SqlInt>("service_contract_id");
    }
}
