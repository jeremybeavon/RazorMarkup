using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Servers
    {
        public static readonly ViewName ViewName = new ViewName("sys.servers");
        
        public static readonly Column<SqlSysname> Catalog = new Column<SqlSysname>("catalog");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("collation_name");
        
        public static readonly Column<SqlInt> ConnectTimeout = new Column<SqlInt>("connect_timeout");
        
        public static readonly Column<SqlNVarchar> DataSource = new Column<SqlNVarchar>("data_source");
        
        public static readonly Column<SqlBit> IsCollationCompatible = new Column<SqlBit>("is_collation_compatible");
        
        public static readonly Column<SqlBit> IsDataAccessEnabled = new Column<SqlBit>("is_data_access_enabled");
        
        public static readonly Column<SqlBit> IsDistributor = new Column<SqlBit>("is_distributor");
        
        public static readonly Column<SqlBit> IsLinked = new Column<SqlBit>("is_linked");
        
        public static readonly Column<SqlBit> IsNonsqlSubscriber = new Column<SqlBit>("is_nonsql_subscriber");
        
        public static readonly Column<SqlBit> IsPublisher = new Column<SqlBit>("is_publisher");
        
        public static readonly Column<SqlBit> IsRemoteLoginEnabled = new Column<SqlBit>("is_remote_login_enabled");
        
        public static readonly Column<SqlBit> IsRemoteProcTransactionPromotionEnabled = new Column<SqlBit>("is_remote_proc_transaction_promotion_enabled");
        
        public static readonly Column<SqlBit> IsRpcOutEnabled = new Column<SqlBit>("is_rpc_out_enabled");
        
        public static readonly Column<SqlBit> IsSubscriber = new Column<SqlBit>("is_subscriber");
        
        public static readonly Column<SqlBit> IsSystem = new Column<SqlBit>("is_system");
        
        public static readonly Column<SqlBit> LazySchemaValidation = new Column<SqlBit>("lazy_schema_validation");
        
        public static readonly Column<SqlNVarchar> Location = new Column<SqlNVarchar>("location");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlSysname> Product = new Column<SqlSysname>("product");
        
        public static readonly Column<SqlSysname> Provider = new Column<SqlSysname>("provider");
        
        public static readonly Column<SqlNVarchar> ProviderString = new Column<SqlNVarchar>("provider_string");
        
        public static readonly Column<SqlInt> QueryTimeout = new Column<SqlInt>("query_timeout");
        
        public static readonly Column<SqlInt> ServerId = new Column<SqlInt>("server_id");
        
        public static readonly Column<SqlBit> UsesRemoteCollation = new Column<SqlBit>("uses_remote_collation");
    }
}
