using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class CryptographicProviders
    {
        public static readonly ViewName ViewName = new("sys.cryptographic_providers");

        public static readonly Column<SqlNVarchar> DllPath = new("dll_path");

        public static readonly Column<SqlUniqueIdentifier> Guid = new("guid");

        public static readonly Column<SqlBit> IsEnabled = new("is_enabled");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ProviderId = new("provider_id");

        public static readonly Column<SqlNVarchar> Version = new("version");
    }
}
