using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDatabaseEncryptionKeys
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_database_encryption_keys");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> EncryptionState = new Column<SqlInt>("encryption_state");
        
        public static readonly Column<SqlVarbinary> EncryptorThumbprint = new Column<SqlVarbinary>("encryptor_thumbprint");
        
        public static readonly Column<SqlNVarchar> EncryptorType = new Column<SqlNVarchar>("encryptor_type");
        
        public static readonly Column<SqlNVarchar> KeyAlgorithm = new Column<SqlNVarchar>("key_algorithm");
        
        public static readonly Column<SqlInt> KeyLength = new Column<SqlInt>("key_length");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlDateTime> OpenedDate = new Column<SqlDateTime>("opened_date");
        
        public static readonly Column<SqlReal> PercentComplete = new Column<SqlReal>("percent_complete");
        
        public static readonly Column<SqlDateTime> RegenerateDate = new Column<SqlDateTime>("regenerate_date");
        
        public static readonly Column<SqlDateTime> SetDate = new Column<SqlDateTime>("set_date");
    }
}
