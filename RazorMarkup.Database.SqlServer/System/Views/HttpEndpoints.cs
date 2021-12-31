using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class HttpEndpoints
    {
        public static readonly ViewName ViewName = new("sys.http_endpoints");

        public static readonly Column<SqlNVarchar> AuthorizationRealm = new("authorization_realm");

        public static readonly Column<SqlInt> ClearPort = new("clear_port");

        public static readonly Column<SqlNVarchar> DefaultLogonDomain = new("default_logon_domain");

        public static readonly Column<SqlInt> EndpointId = new("endpoint_id");

        public static readonly Column<SqlBit> IsAdminEndpoint = new("is_admin_endpoint");

        public static readonly Column<SqlBit> IsAnonymousEnabled = new("is_anonymous_enabled");

        public static readonly Column<SqlBit> IsBasicAuthEnabled = new("is_basic_auth_enabled");

        public static readonly Column<SqlBit> IsClearPortEnabled = new("is_clear_port_enabled");

        public static readonly Column<SqlBit> IsCompressionEnabled = new("is_compression_enabled");

        public static readonly Column<SqlBit> IsDigestAuthEnabled = new("is_digest_auth_enabled");

        public static readonly Column<SqlBit> IsIntegratedAuthEnabled = new("is_integrated_auth_enabled");

        public static readonly Column<SqlBit> IsKerberosAuthEnabled = new("is_kerberos_auth_enabled");

        public static readonly Column<SqlBit> IsNtlmAuthEnabled = new("is_ntlm_auth_enabled");

        public static readonly Column<SqlBit> IsSslPortEnabled = new("is_ssl_port_enabled");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlTinyInt> Protocol = new("protocol");

        public static readonly Column<SqlNVarchar> ProtocolDesc = new("protocol_desc");

        public static readonly Column<SqlNVarchar> Site = new("site");

        public static readonly Column<SqlInt> SslPort = new("ssl_port");

        public static readonly Column<SqlTinyInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");

        public static readonly Column<SqlNVarchar> UrlPath = new("url_path");
    }
}
