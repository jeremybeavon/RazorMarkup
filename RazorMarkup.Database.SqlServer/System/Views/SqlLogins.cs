using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SqlLogins
    {
        public static readonly ViewName ViewName = new ViewName("sys.sql_logins");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlInt> CredentialId = new Column<SqlInt>("credential_id");
        
        public static readonly Column<SqlSysname> DefaultDatabaseName = new Column<SqlSysname>("default_database_name");
        
        public static readonly Column<SqlSysname> DefaultLanguageName = new Column<SqlSysname>("default_language_name");
        
        public static readonly Column<SqlBit> IsDisabled = new Column<SqlBit>("is_disabled");
        
        public static readonly Column<SqlBit> IsExpirationChecked = new Column<SqlBit>("is_expiration_checked");
        
        public static readonly Column<SqlBit> IsPolicyChecked = new Column<SqlBit>("is_policy_checked");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlVarbinary> PasswordHash = new Column<SqlVarbinary>("password_hash");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
