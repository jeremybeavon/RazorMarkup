using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class HttpEndpoints
    {
        public static readonly ViewName ViewName = new ViewName("sys.http_endpoints");
        
        public static readonly Column<SqlNVarchar> AuthorizationRealm = new Column<SqlNVarchar>("authorization_realm");
        
        public static readonly Column<SqlInt> ClearPort = new Column<SqlInt>("clear_port");
        
        public static readonly Column<SqlNVarchar> DefaultLogonDomain = new Column<SqlNVarchar>("default_logon_domain");
        
        public static readonly Column<SqlInt> EndpointId = new Column<SqlInt>("endpoint_id");
        
        public static readonly Column<SqlBit> IsAdminEndpoint = new Column<SqlBit>("is_admin_endpoint");
        
        public static readonly Column<SqlBit> IsAnonymousEnabled = new Column<SqlBit>("is_anonymous_enabled");
        
        public static readonly Column<SqlBit> IsBasicAuthEnabled = new Column<SqlBit>("is_basic_auth_enabled");
        
        public static readonly Column<SqlBit> IsClearPortEnabled = new Column<SqlBit>("is_clear_port_enabled");
        
        public static readonly Column<SqlBit> IsCompressionEnabled = new Column<SqlBit>("is_compression_enabled");
        
        public static readonly Column<SqlBit> IsDigestAuthEnabled = new Column<SqlBit>("is_digest_auth_enabled");
        
        public static readonly Column<SqlBit> IsIntegratedAuthEnabled = new Column<SqlBit>("is_integrated_auth_enabled");
        
        public static readonly Column<SqlBit> IsKerberosAuthEnabled = new Column<SqlBit>("is_kerberos_auth_enabled");
        
        public static readonly Column<SqlBit> IsNtlmAuthEnabled = new Column<SqlBit>("is_ntlm_auth_enabled");
        
        public static readonly Column<SqlBit> IsSslPortEnabled = new Column<SqlBit>("is_ssl_port_enabled");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlTinyInt> Protocol = new Column<SqlTinyInt>("protocol");
        
        public static readonly Column<SqlNVarchar> ProtocolDesc = new Column<SqlNVarchar>("protocol_desc");
        
        public static readonly Column<SqlNVarchar> Site = new Column<SqlNVarchar>("site");
        
        public static readonly Column<SqlInt> SslPort = new Column<SqlInt>("ssl_port");
        
        public static readonly Column<SqlTinyInt> State = new Column<SqlTinyInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
        
        public static readonly Column<SqlNVarchar> UrlPath = new Column<SqlNVarchar>("url_path");
    }
}
