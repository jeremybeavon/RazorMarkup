using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDatabaseEncryptionKeys
    {
        public static readonly ViewName ViewName = new("sys.dm_database_encryption_keys");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> EncryptionState = new("encryption_state");

        public static readonly Column<SqlVarbinary> EncryptorThumbprint = new("encryptor_thumbprint");

        public static readonly Column<SqlNVarchar> EncryptorType = new("encryptor_type");

        public static readonly Column<SqlNVarchar> KeyAlgorithm = new("key_algorithm");

        public static readonly Column<SqlInt> KeyLength = new("key_length");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlDateTime> OpenedDate = new("opened_date");

        public static readonly Column<SqlReal> PercentComplete = new("percent_complete");

        public static readonly Column<SqlDateTime> RegenerateDate = new("regenerate_date");

        public static readonly Column<SqlDateTime> SetDate = new("set_date");
    }
}
