using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class RemoteServiceBindings
    {
        public static readonly ViewName ViewName = new("sys.remote_service_bindings");

        public static readonly Column<SqlBit> IsAnonymousOn = new("is_anonymous_on");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> RemotePrincipalId = new("remote_principal_id");

        public static readonly Column<SqlInt> RemoteServiceBindingId = new("remote_service_binding_id");

        public static readonly Column<SqlNVarchar> RemoteServiceName = new("remote_service_name");

        public static readonly Column<SqlInt> ServiceContractId = new("service_contract_id");
    }
}
