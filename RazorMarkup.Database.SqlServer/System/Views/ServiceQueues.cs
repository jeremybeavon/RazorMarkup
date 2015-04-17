using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceQueues
    {
        public static readonly ViewName ViewName = new ViewName("sys.service_queues");
        
        public static readonly Column<SqlNVarchar> ActivationProcedure = new Column<SqlNVarchar>("activation_procedure");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new Column<SqlInt>("execute_as_principal_id");
        
        public static readonly Column<SqlBit> IsActivationEnabled = new Column<SqlBit>("is_activation_enabled");
        
        public static readonly Column<SqlBit> IsEnqueueEnabled = new Column<SqlBit>("is_enqueue_enabled");
        
        public static readonly Column<SqlBit> IsMsShipped = new Column<SqlBit>("is_ms_shipped");
        
        public static readonly Column<SqlBit> IsPoisonMessageHandlingEnabled = new Column<SqlBit>("is_poison_message_handling_enabled");
        
        public static readonly Column<SqlBit> IsPublished = new Column<SqlBit>("is_published");
        
        public static readonly Column<SqlBit> IsReceiveEnabled = new Column<SqlBit>("is_receive_enabled");
        
        public static readonly Column<SqlBit> IsRetentionEnabled = new Column<SqlBit>("is_retention_enabled");
        
        public static readonly Column<SqlBit> IsSchemaPublished = new Column<SqlBit>("is_schema_published");
        
        public static readonly Column<SqlSmallInt> MaxReaders = new Column<SqlSmallInt>("max_readers");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> ParentObjectId = new Column<SqlInt>("parent_object_id");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> SchemaId = new Column<SqlInt>("schema_id");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
