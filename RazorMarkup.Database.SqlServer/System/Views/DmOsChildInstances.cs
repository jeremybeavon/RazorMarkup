using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsChildInstances
    {
        public static readonly ViewName ViewName = new("sys.dm_os_child_instances");

        public static readonly Column<SqlNVarchar> HeartBeat = new("heart_beat");

        public static readonly Column<SqlNVarchar> InstanceName = new("instance_name");

        public static readonly Column<SqlNVarchar> InstancePipeName = new("instance_pipe_name");

        public static readonly Column<SqlDateTime> OsProcessCreationDate = new("OS_process_creation_date");

        public static readonly Column<SqlInt> OsProcessId = new("OS_process_id");

        public static readonly Column<SqlNVarchar> OwningPrincipalName = new("owning_principal_name");

        public static readonly Column<SqlNVarchar> OwningPrincipalSid = new("owning_principal_sid");

        public static readonly Column<SqlVarbinary> OwningPrincipalSidBinary = new("owning_principal_sid_binary");
    }
}
