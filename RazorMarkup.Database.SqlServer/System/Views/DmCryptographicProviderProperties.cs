using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmCryptographicProviderProperties
    {
        public static readonly ViewName ViewName = new("sys.dm_cryptographic_provider_properties");

        public static readonly Column<SqlTinyInt> AsymmetricKeyExport = new("asymmetric_key_export");

        public static readonly Column<SqlTinyInt> AsymmetricKeyImport = new("asymmetric_key_import");

        public static readonly Column<SqlTinyInt> AsymmetricKeyPersistance = new("asymmetric_key_persistance");

        public static readonly Column<SqlTinyInt> AsymmetricKeySupport = new("asymmetric_key_support");

        public static readonly Column<SqlNVarchar> AuthenticationType = new("authentication_type");

        public static readonly Column<SqlNVarchar> FriendlyName = new("friendly_name");

        public static readonly Column<SqlUniqueIdentifier> Guid = new("guid");

        public static readonly Column<SqlInt> ProviderId = new("provider_id");

        public static readonly Column<SqlNVarchar> ProviderVersion = new("provider_version");

        public static readonly Column<SqlNVarchar> SqlcryptVersion = new("sqlcrypt_version");

        public static readonly Column<SqlTinyInt> SymmetricKeyExport = new("symmetric_key_export");

        public static readonly Column<SqlTinyInt> SymmetricKeyImport = new("symmetric_key_import");

        public static readonly Column<SqlTinyInt> SymmetricKeyPersistance = new("symmetric_key_persistance");

        public static readonly Column<SqlTinyInt> SymmetricKeySupport = new("symmetric_key_support");
    }
}
