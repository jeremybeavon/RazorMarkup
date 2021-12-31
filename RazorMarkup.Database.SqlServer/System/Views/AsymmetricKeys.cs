using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AsymmetricKeys
    {
        public static readonly ViewName ViewName = new("sys.asymmetric_keys");

        public static readonly Column<SqlChar> Algorithm = new("algorithm");

        public static readonly Column<SqlNVarchar> AlgorithmDesc = new("algorithm_desc");

        public static readonly Column<SqlInt> AsymmetricKeyId = new("asymmetric_key_id");

        public static readonly Column<SqlNVarchar> AttestedBy = new("attested_by");

        public static readonly Column<SqlVariant> CryptographicProviderAlgid = new("cryptographic_provider_algid");

        public static readonly Column<SqlUniqueIdentifier> CryptographicProviderGuid = new("cryptographic_provider_guid");

        public static readonly Column<SqlInt> KeyLength = new("key_length");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlNVarchar> ProviderType = new("provider_type");

        public static readonly Column<SqlVarbinary> PublicKey = new("public_key");

        public static readonly Column<SqlChar> PvtKeyEncryptionType = new("pvt_key_encryption_type");

        public static readonly Column<SqlNVarchar> PvtKeyEncryptionTypeDesc = new("pvt_key_encryption_type_desc");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlNVarchar> StringSid = new("string_sid");

        public static readonly Column<SqlVarbinary> Thumbprint = new("thumbprint");
    }
}
