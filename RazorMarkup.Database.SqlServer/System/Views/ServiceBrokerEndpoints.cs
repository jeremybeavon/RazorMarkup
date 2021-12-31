using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceBrokerEndpoints
    {
        public static readonly ViewName ViewName = new("sys.service_broker_endpoints");

        public static readonly Column<SqlInt> CertificateId = new("certificate_id");

        public static readonly Column<SqlTinyInt> ConnectionAuth = new("connection_auth");

        public static readonly Column<SqlNVarchar> ConnectionAuthDesc = new("connection_auth_desc");

        public static readonly Column<SqlTinyInt> EncryptionAlgorithm = new("encryption_algorithm");

        public static readonly Column<SqlNVarchar> EncryptionAlgorithmDesc = new("encryption_algorithm_desc");

        public static readonly Column<SqlInt> EndpointId = new("endpoint_id");

        public static readonly Column<SqlBit> IsAdminEndpoint = new("is_admin_endpoint");

        public static readonly Column<SqlBit> IsMessageForwardingEnabled = new("is_message_forwarding_enabled");

        public static readonly Column<SqlInt> MessageForwardingSize = new("message_forwarding_size");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlTinyInt> Protocol = new("protocol");

        public static readonly Column<SqlNVarchar> ProtocolDesc = new("protocol_desc");

        public static readonly Column<SqlTinyInt> State = new("state");

        public static readonly Column<SqlNVarchar> StateDesc = new("state_desc");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
