using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsLoadedModules
    {
        public static readonly ViewName ViewName = new("sys.dm_os_loaded_modules");

        public static readonly Column<SqlVarbinary> BaseAddress = new("base_address");

        public static readonly Column<SqlNVarchar> Company = new("company");

        public static readonly Column<SqlBit> Debug = new("debug");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlVarchar> FileVersion = new("file_version");

        public static readonly Column<SqlInt> Language = new("language");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlBit> Patched = new("patched");

        public static readonly Column<SqlBit> Prerelease = new("prerelease");

        public static readonly Column<SqlBit> PrivateBuild = new("private_build");

        public static readonly Column<SqlVarchar> ProductVersion = new("product_version");

        public static readonly Column<SqlBit> SpecialBuild = new("special_build");
    }
}
