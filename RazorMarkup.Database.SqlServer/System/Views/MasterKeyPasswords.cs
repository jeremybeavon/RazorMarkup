using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class MasterKeyPasswords
    {
        public static readonly ViewName ViewName = new ViewName("sys.master_key_passwords");
        
        public static readonly Column<SqlInt> CredentialId = new Column<SqlInt>("credential_id");
        
        public static readonly Column<SqlUniqueIdentifier> FamilyGuid = new Column<SqlUniqueIdentifier>("family_guid");
    }
}
