using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class DacInstances
    {
        public static readonly ViewName ViewName = new("dbo.sysdac_instances");

        public static readonly Column<SqlUniqueIdentifier> InstanceId = new("instance_id");

        public static readonly Column<SqlSysname> InstanceName = new("instance_name");

        public static readonly Column<SqlSysname> TypeName = new("type_name");

        public static readonly Column<SqlNVarchar> TypeVersion = new("type_version");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlVarbinary> TypeStream = new("type_stream");

        public static readonly Column<SqlDateTime> DateCreated = new("date_created");

        public static readonly Column<SqlSysname> CreatedBy = new("created_by");

        public static readonly Column<SqlSysname> DatabaseName = new("database_name");
    }
}
