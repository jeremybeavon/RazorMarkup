using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWorkerLocalStorage
    {
        public static readonly ViewName ViewName = new("sys.dm_os_worker_local_storage");

        public static readonly Column<SqlVarbinary> BrokerAddress = new("broker_address");

        public static readonly Column<SqlVarbinary> CompExecCtxtAddress = new("comp_exec_ctxt_address");

        public static readonly Column<SqlVarbinary> DiagAddress = new("diag_address");

        public static readonly Column<SqlVarbinary> EcAddress = new("ec_address");

        public static readonly Column<SqlVarbinary> FederatedxactAddress = new("federatedxact_address");

        public static readonly Column<SqlVarbinary> FilestreamAddress = new("filestream_address");

        public static readonly Column<SqlVarbinary> HostTaskAddress = new("host_task_address");

        public static readonly Column<SqlVarbinary> MsqlxactAddress = new("msqlxact_address");

        public static readonly Column<SqlVarbinary> QeCcAddress = new("qe_cc_address");

        public static readonly Column<SqlVarbinary> QueryDriverAddress = new("query_driver_address");

        public static readonly Column<SqlVarbinary> QueryscanAddress = new("queryscan_address");

        public static readonly Column<SqlVarbinary> SniErrorAddress = new("sni_error_address");

        public static readonly Column<SqlVarbinary> SqlProfAddress = new("sql_prof_address");

        public static readonly Column<SqlVarbinary> StackCheckerAddress = new("stack_checker_address");

        public static readonly Column<SqlVarbinary> TaskProxyAddress = new("task_proxy_address");

        public static readonly Column<SqlVarbinary> WorkerAddress = new("worker_address");
    }
}
