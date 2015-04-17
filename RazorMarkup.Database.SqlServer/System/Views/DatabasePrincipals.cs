using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DatabasePrincipals
    {
        public static readonly ViewName ViewName = new ViewName("sys.database_principals");
        
        public static readonly Column<SqlInt> AuthenticationType = new Column<SqlInt>("authentication_type");
        
        public static readonly Column<SqlNVarchar> AuthenticationTypeDesc = new Column<SqlNVarchar>("authentication_type_desc");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlInt> DefaultLanguageLcid = new Column<SqlInt>("default_language_lcid");
        
        public static readonly Column<SqlSysname> DefaultLanguageName = new Column<SqlSysname>("default_language_name");
        
        public static readonly Column<SqlSysname> DefaultSchemaName = new Column<SqlSysname>("default_schema_name");
        
        public static readonly Column<SqlBit> IsFixedRole = new Column<SqlBit>("is_fixed_role");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> OwningPrincipalId = new Column<SqlInt>("owning_principal_id");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
