using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceContracts
    {
        public static readonly ViewName ViewName = new("sys.service_contracts");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> ServiceContractId = new("service_contract_id");
    }
}
