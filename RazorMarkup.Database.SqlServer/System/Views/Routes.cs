using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Routes
    {
        public static readonly ViewName ViewName = new ViewName("sys.routes");
        
        public static readonly Column<SqlNVarchar> Address = new Column<SqlNVarchar>("address");
        
        public static readonly Column<SqlNVarchar> BrokerInstance = new Column<SqlNVarchar>("broker_instance");
        
        public static readonly Column<SqlDateTime> Lifetime = new Column<SqlDateTime>("lifetime");
        
        public static readonly Column<SqlNVarchar> MirrorAddress = new Column<SqlNVarchar>("mirror_address");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlNVarchar> RemoteServiceName = new Column<SqlNVarchar>("remote_service_name");
        
        public static readonly Column<SqlInt> RouteId = new Column<SqlInt>("route_id");
    }
}
