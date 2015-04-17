using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerPrincipalCredentials
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_principal_credentials");
        
        public static readonly Column<SqlInt> CredentialId = new Column<SqlInt>("credential_id");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
    }
}
