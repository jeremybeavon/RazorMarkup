using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class BackupDevices
    {
        public static readonly ViewName ViewName = new("sys.backup_devices");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> PhysicalName = new("physical_name");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
