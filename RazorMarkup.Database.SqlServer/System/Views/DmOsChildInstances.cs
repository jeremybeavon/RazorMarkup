using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsChildInstances
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_child_instances");
        
        public static readonly Column<SqlNVarchar> HeartBeat = new Column<SqlNVarchar>("heart_beat");
        
        public static readonly Column<SqlNVarchar> InstanceName = new Column<SqlNVarchar>("instance_name");
        
        public static readonly Column<SqlNVarchar> InstancePipeName = new Column<SqlNVarchar>("instance_pipe_name");
        
        public static readonly Column<SqlDateTime> OsProcessCreationDate = new Column<SqlDateTime>("OS_process_creation_date");
        
        public static readonly Column<SqlInt> OsProcessId = new Column<SqlInt>("OS_process_id");
        
        public static readonly Column<SqlNVarchar> OwningPrincipalName = new Column<SqlNVarchar>("owning_principal_name");
        
        public static readonly Column<SqlNVarchar> OwningPrincipalSid = new Column<SqlNVarchar>("owning_principal_sid");
        
        public static readonly Column<SqlVarbinary> OwningPrincipalSidBinary = new Column<SqlVarbinary>("owning_principal_sid_binary");
    }
}
