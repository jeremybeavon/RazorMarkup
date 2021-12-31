using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerServices
    {
        public static readonly ViewName ViewName = new("sys.dm_server_services");

        public static readonly Column<SqlNVarchar> ClusterNodename = new("cluster_nodename");

        public static readonly Column<SqlNVarchar> Filename = new("filename");

        public static readonly Column<SqlNVarchar> IsClustered = new("is_clustered");

        public static readonly Column<SqlDateTimeOffset> LastStartupTime = new("last_startup_time");

        public static readonly Column<SqlInt> ProcessId = new("process_id");

        public static readonly Column<SqlNVarchar> ServiceAccount = new("service_account");

        public static readonly Column<SqlNVarchar> Servicename = new("servicename");

        public static readonly Column<SqlInt> StartupType = new("startup_type");

        public static readonly Column<SqlNVarchar> StartupTypeDesc = new("startup_type_desc");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlNVarchar> StatusDesc = new("status_desc");
    }
}
