using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SoapEndpoints
    {
        public static readonly ViewName ViewName = new("sys.soap_endpoints");

        public static readonly Column<SqlSysname> DefaultDatabase = new("default_database");

        public static readonly Column<SqlNVarchar> DefaultNamespace = new("default_namespace");

        public static readonly Column<SqlTinyInt> DefaultResultSchema = new("default_result_schema");

        public static readonly Column<SqlNVarchar> DefaultResultSchemaDesc = new("default_result_schema_desc");

        public static readonly Column<SqlInt> EndpointId = new("endpoint_id");

        public static readonly Column<SqlInt> HeaderLimit = new("header_limit");

        public static readonly Column<SqlBit> IsAdminEndpoint = new("is_admin_endpoint");

        public static readonly Column<SqlBit> IsSessionEnabled = new("is_session_enabled");

        public static readonly Column<SqlBit> IsSqlLanguageEnabled = new("is_sql_language_enabled");

        public static readonly Column<SqlBit> IsXmlCharsetEnforced = new("is_xml_charset_enforced");

        public static readonly Column<SqlNVarchar> LoginType = new("login_type");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlTinyInt> Protocol = new("protocol");

        public static readonly Column<SqlNVarchar> ProtocolDesc = new("protocol_desc");

        public static readonly Column<SqlInt> SessionTimeout = new("session_timeout");

        public static readonly Column<SqlTinyInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");

        public static readonly Column<SqlNVarchar> WsdlGeneratorProcedure = new("wsdl_generator_procedure");
    }
}
