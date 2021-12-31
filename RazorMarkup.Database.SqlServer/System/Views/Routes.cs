using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Routes
    {
        public static readonly ViewName ViewName = new("sys.routes");

        public static readonly Column<SqlNVarchar> Address = new("address");

        public static readonly Column<SqlNVarchar> BrokerInstance = new("broker_instance");

        public static readonly Column<SqlDateTime> Lifetime = new("lifetime");

        public static readonly Column<SqlNVarchar> MirrorAddress = new("mirror_address");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlNVarchar> RemoteServiceName = new("remote_service_name");

        public static readonly Column<SqlInt> RouteId = new("route_id");
    }
}
