using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class RemoteServiceBindings
    {
        public static readonly ViewName ViewName = new ViewName("sys.remote_service_bindings");
        
        public static readonly Column<SqlBit> IsAnonymousOn = new Column<SqlBit>("is_anonymous_on");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> RemotePrincipalId = new Column<SqlInt>("remote_principal_id");
        
        public static readonly Column<SqlInt> RemoteServiceBindingId = new Column<SqlInt>("remote_service_binding_id");
        
        public static readonly Column<SqlNVarchar> RemoteServiceName = new Column<SqlNVarchar>("remote_service_name");
        
        public static readonly Column<SqlInt> ServiceContractId = new Column<SqlInt>("service_contract_id");
    }
}
