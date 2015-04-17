using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerServices
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_server_services");
        
        public static readonly Column<SqlNVarchar> ClusterNodename = new Column<SqlNVarchar>("cluster_nodename");
        
        public static readonly Column<SqlNVarchar> Filename = new Column<SqlNVarchar>("filename");
        
        public static readonly Column<SqlNVarchar> IsClustered = new Column<SqlNVarchar>("is_clustered");
        
        public static readonly Column<SqlDateTimeOffset> LastStartupTime = new Column<SqlDateTimeOffset>("last_startup_time");
        
        public static readonly Column<SqlInt> ProcessId = new Column<SqlInt>("process_id");
        
        public static readonly Column<SqlNVarchar> ServiceAccount = new Column<SqlNVarchar>("service_account");
        
        public static readonly Column<SqlNVarchar> Servicename = new Column<SqlNVarchar>("servicename");
        
        public static readonly Column<SqlInt> StartupType = new Column<SqlInt>("startup_type");
        
        public static readonly Column<SqlNVarchar> StartupTypeDesc = new Column<SqlNVarchar>("startup_type_desc");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlNVarchar> StatusDesc = new Column<SqlNVarchar>("status_desc");
    }
}
