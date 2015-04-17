using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWorkerLocalStorage
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_worker_local_storage");
        
        public static readonly Column<SqlVarbinary> BrokerAddress = new Column<SqlVarbinary>("broker_address");
        
        public static readonly Column<SqlVarbinary> CompExecCtxtAddress = new Column<SqlVarbinary>("comp_exec_ctxt_address");
        
        public static readonly Column<SqlVarbinary> DiagAddress = new Column<SqlVarbinary>("diag_address");
        
        public static readonly Column<SqlVarbinary> EcAddress = new Column<SqlVarbinary>("ec_address");
        
        public static readonly Column<SqlVarbinary> FederatedxactAddress = new Column<SqlVarbinary>("federatedxact_address");
        
        public static readonly Column<SqlVarbinary> FilestreamAddress = new Column<SqlVarbinary>("filestream_address");
        
        public static readonly Column<SqlVarbinary> HostTaskAddress = new Column<SqlVarbinary>("host_task_address");
        
        public static readonly Column<SqlVarbinary> MsqlxactAddress = new Column<SqlVarbinary>("msqlxact_address");
        
        public static readonly Column<SqlVarbinary> QeCcAddress = new Column<SqlVarbinary>("qe_cc_address");
        
        public static readonly Column<SqlVarbinary> QueryDriverAddress = new Column<SqlVarbinary>("query_driver_address");
        
        public static readonly Column<SqlVarbinary> QueryscanAddress = new Column<SqlVarbinary>("queryscan_address");
        
        public static readonly Column<SqlVarbinary> SniErrorAddress = new Column<SqlVarbinary>("sni_error_address");
        
        public static readonly Column<SqlVarbinary> SqlProfAddress = new Column<SqlVarbinary>("sql_prof_address");
        
        public static readonly Column<SqlVarbinary> StackCheckerAddress = new Column<SqlVarbinary>("stack_checker_address");
        
        public static readonly Column<SqlVarbinary> TaskProxyAddress = new Column<SqlVarbinary>("task_proxy_address");
        
        public static readonly Column<SqlVarbinary> WorkerAddress = new Column<SqlVarbinary>("worker_address");
    }
}
