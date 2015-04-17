using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Credentials
    {
        public static readonly ViewName ViewName = new ViewName("sys.credentials");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlInt> CredentialId = new Column<SqlInt>("credential_id");
        
        public static readonly Column<SqlNVarchar> CredentialIdentity = new Column<SqlNVarchar>("credential_identity");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> TargetId = new Column<SqlInt>("target_id");
        
        public static readonly Column<SqlNVarchar> TargetType = new Column<SqlNVarchar>("target_type");
    }
}
