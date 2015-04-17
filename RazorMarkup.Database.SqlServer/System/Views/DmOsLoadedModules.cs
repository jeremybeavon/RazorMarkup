using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsLoadedModules
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_loaded_modules");
        
        public static readonly Column<SqlVarbinary> BaseAddress = new Column<SqlVarbinary>("base_address");
        
        public static readonly Column<SqlNVarchar> Company = new Column<SqlNVarchar>("company");
        
        public static readonly Column<SqlBit> Debug = new Column<SqlBit>("debug");
        
        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");
        
        public static readonly Column<SqlVarchar> FileVersion = new Column<SqlVarchar>("file_version");
        
        public static readonly Column<SqlInt> Language = new Column<SqlInt>("language");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlBit> Patched = new Column<SqlBit>("patched");
        
        public static readonly Column<SqlBit> Prerelease = new Column<SqlBit>("prerelease");
        
        public static readonly Column<SqlBit> PrivateBuild = new Column<SqlBit>("private_build");
        
        public static readonly Column<SqlVarchar> ProductVersion = new Column<SqlVarchar>("product_version");
        
        public static readonly Column<SqlBit> SpecialBuild = new Column<SqlBit>("special_build");
    }
}
