using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmCryptographicProviderProperties
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_cryptographic_provider_properties");
        
        public static readonly Column<SqlTinyInt> AsymmetricKeyExport = new Column<SqlTinyInt>("asymmetric_key_export");
        
        public static readonly Column<SqlTinyInt> AsymmetricKeyImport = new Column<SqlTinyInt>("asymmetric_key_import");
        
        public static readonly Column<SqlTinyInt> AsymmetricKeyPersistance = new Column<SqlTinyInt>("asymmetric_key_persistance");
        
        public static readonly Column<SqlTinyInt> AsymmetricKeySupport = new Column<SqlTinyInt>("asymmetric_key_support");
        
        public static readonly Column<SqlNVarchar> AuthenticationType = new Column<SqlNVarchar>("authentication_type");
        
        public static readonly Column<SqlNVarchar> FriendlyName = new Column<SqlNVarchar>("friendly_name");
        
        public static readonly Column<SqlUniqueIdentifier> Guid = new Column<SqlUniqueIdentifier>("guid");
        
        public static readonly Column<SqlInt> ProviderId = new Column<SqlInt>("provider_id");
        
        public static readonly Column<SqlNVarchar> ProviderVersion = new Column<SqlNVarchar>("provider_version");
        
        public static readonly Column<SqlNVarchar> SqlcryptVersion = new Column<SqlNVarchar>("sqlcrypt_version");
        
        public static readonly Column<SqlTinyInt> SymmetricKeyExport = new Column<SqlTinyInt>("symmetric_key_export");
        
        public static readonly Column<SqlTinyInt> SymmetricKeyImport = new Column<SqlTinyInt>("symmetric_key_import");
        
        public static readonly Column<SqlTinyInt> SymmetricKeyPersistance = new Column<SqlTinyInt>("symmetric_key_persistance");
        
        public static readonly Column<SqlTinyInt> SymmetricKeySupport = new Column<SqlTinyInt>("symmetric_key_support");
    }
}
