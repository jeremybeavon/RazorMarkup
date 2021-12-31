using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerPrincipalCredentials
    {
        public static readonly ViewName ViewName = new("sys.server_principal_credentials");

        public static readonly Column<SqlInt> CredentialId = new("credential_id");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");
    }
}
