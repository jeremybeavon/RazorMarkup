using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class CryptographicProviders
    {
        public static readonly ViewName ViewName = new ViewName("sys.cryptographic_providers");
        
        public static readonly Column<SqlNVarchar> DllPath = new Column<SqlNVarchar>("dll_path");
        
        public static readonly Column<SqlUniqueIdentifier> Guid = new Column<SqlUniqueIdentifier>("guid");
        
        public static readonly Column<SqlBit> IsEnabled = new Column<SqlBit>("is_enabled");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ProviderId = new Column<SqlInt>("provider_id");
        
        public static readonly Column<SqlNVarchar> Version = new Column<SqlNVarchar>("version");
    }
}
