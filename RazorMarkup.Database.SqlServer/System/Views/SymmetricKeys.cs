using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SymmetricKeys
    {
        public static readonly ViewName ViewName = new ViewName("sys.symmetric_keys");
        
        public static readonly Column<SqlNVarchar> AlgorithmDesc = new Column<SqlNVarchar>("algorithm_desc");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlVariant> CryptographicProviderAlgid = new Column<SqlVariant>("cryptographic_provider_algid");
        
        public static readonly Column<SqlUniqueIdentifier> CryptographicProviderGuid = new Column<SqlUniqueIdentifier>("cryptographic_provider_guid");
        
        public static readonly Column<SqlChar> KeyAlgorithm = new Column<SqlChar>("key_algorithm");
        
        public static readonly Column<SqlUniqueIdentifier> KeyGuid = new Column<SqlUniqueIdentifier>("key_guid");
        
        public static readonly Column<SqlInt> KeyLength = new Column<SqlInt>("key_length");
        
        public static readonly Column<SqlVariant> KeyThumbprint = new Column<SqlVariant>("key_thumbprint");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlNVarchar> ProviderType = new Column<SqlNVarchar>("provider_type");
        
        public static readonly Column<SqlInt> SymmetricKeyId = new Column<SqlInt>("symmetric_key_id");
    }
}
