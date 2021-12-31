using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Servers
    {
        public static readonly ViewName ViewName = new("sys.servers");

        public static readonly Column<SqlSysname> Catalog = new("catalog");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlInt> ConnectTimeout = new("connect_timeout");

        public static readonly Column<SqlNVarchar> DataSource = new("data_source");

        public static readonly Column<SqlBit> IsCollationCompatible = new("is_collation_compatible");

        public static readonly Column<SqlBit> IsDataAccessEnabled = new("is_data_access_enabled");

        public static readonly Column<SqlBit> IsDistributor = new("is_distributor");

        public static readonly Column<SqlBit> IsLinked = new("is_linked");

        public static readonly Column<SqlBit> IsNonsqlSubscriber = new("is_nonsql_subscriber");

        public static readonly Column<SqlBit> IsPublisher = new("is_publisher");

        public static readonly Column<SqlBit> IsRemoteLoginEnabled = new("is_remote_login_enabled");

        public static readonly Column<SqlBit> IsRemoteProcTransactionPromotionEnabled = new("is_remote_proc_transaction_promotion_enabled");

        public static readonly Column<SqlBit> IsRpcOutEnabled = new("is_rpc_out_enabled");

        public static readonly Column<SqlBit> IsSubscriber = new("is_subscriber");

        public static readonly Column<SqlBit> IsSystem = new("is_system");

        public static readonly Column<SqlBit> LazySchemaValidation = new("lazy_schema_validation");

        public static readonly Column<SqlNVarchar> Location = new("location");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlSysname> Product = new("product");

        public static readonly Column<SqlSysname> Provider = new("provider");

        public static readonly Column<SqlNVarchar> ProviderString = new("provider_string");

        public static readonly Column<SqlInt> QueryTimeout = new("query_timeout");

        public static readonly Column<SqlInt> ServerId = new("server_id");

        public static readonly Column<SqlBit> UsesRemoteCollation = new("uses_remote_collation");
    }
}
