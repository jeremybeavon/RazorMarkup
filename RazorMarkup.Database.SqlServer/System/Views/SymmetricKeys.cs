using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SymmetricKeys
    {
        public static readonly ViewName ViewName = new("sys.symmetric_keys");

        public static readonly Column<SqlNVarchar> AlgorithmDesc = new("algorithm_desc");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlVariant> CryptographicProviderAlgid = new("cryptographic_provider_algid");

        public static readonly Column<SqlUniqueIdentifier> CryptographicProviderGuid = new("cryptographic_provider_guid");

        public static readonly Column<SqlChar> KeyAlgorithm = new("key_algorithm");

        public static readonly Column<SqlUniqueIdentifier> KeyGuid = new("key_guid");

        public static readonly Column<SqlInt> KeyLength = new("key_length");

        public static readonly Column<SqlVariant> KeyThumbprint = new("key_thumbprint");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlNVarchar> ProviderType = new("provider_type");

        public static readonly Column<SqlInt> SymmetricKeyId = new("symmetric_key_id");
    }
}
