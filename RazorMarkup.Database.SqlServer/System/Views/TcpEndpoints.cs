using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TcpEndpoints
    {
        public static readonly ViewName ViewName = new("sys.tcp_endpoints");

        public static readonly Column<SqlInt> EndpointId = new("endpoint_id");

        public static readonly Column<SqlVarchar> IpAddress = new("ip_address");

        public static readonly Column<SqlBit> IsAdminEndpoint = new("is_admin_endpoint");

        public static readonly Column<SqlBit> IsDynamicPort = new("is_dynamic_port");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> Port = new("port");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlTinyInt> Protocol = new("protocol");

        public static readonly Column<SqlNVarchar> ProtocolDesc = new("protocol_desc");

        public static readonly Column<SqlTinyInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
