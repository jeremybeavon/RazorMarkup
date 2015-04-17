using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AsymmetricKeys
    {
        public static readonly ViewName ViewName = new ViewName("sys.asymmetric_keys");
        
        public static readonly Column<SqlChar> Algorithm = new Column<SqlChar>("algorithm");
        
        public static readonly Column<SqlNVarchar> AlgorithmDesc = new Column<SqlNVarchar>("algorithm_desc");
        
        public static readonly Column<SqlInt> AsymmetricKeyId = new Column<SqlInt>("asymmetric_key_id");
        
        public static readonly Column<SqlNVarchar> AttestedBy = new Column<SqlNVarchar>("attested_by");
        
        public static readonly Column<SqlVariant> CryptographicProviderAlgid = new Column<SqlVariant>("cryptographic_provider_algid");
        
        public static readonly Column<SqlUniqueIdentifier> CryptographicProviderGuid = new Column<SqlUniqueIdentifier>("cryptographic_provider_guid");
        
        public static readonly Column<SqlInt> KeyLength = new Column<SqlInt>("key_length");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlNVarchar> ProviderType = new Column<SqlNVarchar>("provider_type");
        
        public static readonly Column<SqlVarbinary> PublicKey = new Column<SqlVarbinary>("public_key");
        
        public static readonly Column<SqlChar> PvtKeyEncryptionType = new Column<SqlChar>("pvt_key_encryption_type");
        
        public static readonly Column<SqlNVarchar> PvtKeyEncryptionTypeDesc = new Column<SqlNVarchar>("pvt_key_encryption_type_desc");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlNVarchar> StringSid = new Column<SqlNVarchar>("string_sid");
        
        public static readonly Column<SqlVarbinary> Thumbprint = new Column<SqlVarbinary>("thumbprint");
    }
}
