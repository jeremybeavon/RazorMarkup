using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceBrokerEndpoints
    {
        public static readonly ViewName ViewName = new ViewName("sys.service_broker_endpoints");
        
        public static readonly Column<SqlInt> CertificateId = new Column<SqlInt>("certificate_id");
        
        public static readonly Column<SqlTinyInt> ConnectionAuth = new Column<SqlTinyInt>("connection_auth");
        
        public static readonly Column<SqlNVarchar> ConnectionAuthDesc = new Column<SqlNVarchar>("connection_auth_desc");
        
        public static readonly Column<SqlTinyInt> EncryptionAlgorithm = new Column<SqlTinyInt>("encryption_algorithm");
        
        public static readonly Column<SqlNVarchar> EncryptionAlgorithmDesc = new Column<SqlNVarchar>("encryption_algorithm_desc");
        
        public static readonly Column<SqlInt> EndpointId = new Column<SqlInt>("endpoint_id");
        
        public static readonly Column<SqlBit> IsAdminEndpoint = new Column<SqlBit>("is_admin_endpoint");
        
        public static readonly Column<SqlBit> IsMessageForwardingEnabled = new Column<SqlBit>("is_message_forwarding_enabled");
        
        public static readonly Column<SqlInt> MessageForwardingSize = new Column<SqlInt>("message_forwarding_size");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlTinyInt> Protocol = new Column<SqlTinyInt>("protocol");
        
        public static readonly Column<SqlNVarchar> ProtocolDesc = new Column<SqlNVarchar>("protocol_desc");
        
        public static readonly Column<SqlTinyInt> State = new Column<SqlTinyInt>("state");
        
        public static readonly Column<SqlNVarchar> StateDesc = new Column<SqlNVarchar>("state_desc");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
