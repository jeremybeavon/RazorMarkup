using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SoapEndpoints
    {
        public static readonly ViewName ViewName = new ViewName("sys.soap_endpoints");
        
        public static readonly Column<SqlSysname> DefaultDatabase = new Column<SqlSysname>("default_database");
        
        public static readonly Column<SqlNVarchar> DefaultNamespace = new Column<SqlNVarchar>("default_namespace");
        
        public static readonly Column<SqlTinyInt> DefaultResultSchema = new Column<SqlTinyInt>("default_result_schema");
        
        public static readonly Column<SqlNVarchar> DefaultResultSchemaDesc = new Column<SqlNVarchar>("default_result_schema_desc");
        
        public static readonly Column<SqlInt> EndpointId = new Column<SqlInt>("endpoint_id");
        
        public static readonly Column<SqlInt> HeaderLimit = new Column<SqlInt>("header_limit");
        
        public static readonly Column<SqlBit> IsAdminEndpoint = new Column<SqlBit>("is_admin_endpoint");
        
        public static readonly Column<SqlBit> IsSessionEnabled = new Column<SqlBit>("is_session_enabled");
        
        public static readonly Column<SqlBit> IsSqlLanguageEnabled = new Column<SqlBit>("is_sql_language_enabled");
        
        public static readonly Column<SqlBit> IsXmlCharsetEnforced = new Column<SqlBit>("is_xml_charset_enforced");
        
        public static readonly Column<SqlNVarchar> LoginType = new Column<SqlNVarchar>("login_type");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlTinyInt> Protocol = new Column<SqlTinyInt>("protocol");
        
        public static readonly Column<SqlNVarchar> ProtocolDesc = new Column<SqlNVarchar>("protocol_desc");
        
        public static readonly Column<SqlInt> SessionTimeout = new Column<SqlInt>("session_timeout");
        
        public static readonly Column<SqlTinyInt> State = new Column<SqlTinyInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
        
        public static readonly Column<SqlNVarchar> WsdlGeneratorProcedure = new Column<SqlNVarchar>("wsdl_generator_procedure");
    }
}
