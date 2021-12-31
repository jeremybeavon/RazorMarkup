using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceQueues
    {
        public static readonly ViewName ViewName = new("sys.service_queues");

        public static readonly Column<SqlNVarchar> ActivationProcedure = new("activation_procedure");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new("execute_as_principal_id");

        public static readonly Column<SqlBit> IsActivationEnabled = new("is_activation_enabled");

        public static readonly Column<SqlBit> IsEnqueueEnabled = new("is_enqueue_enabled");

        public static readonly Column<SqlBit> IsMsShipped = new("is_ms_shipped");

        public static readonly Column<SqlBit> IsPoisonMessageHandlingEnabled = new("is_poison_message_handling_enabled");

        public static readonly Column<SqlBit> IsPublished = new("is_published");

        public static readonly Column<SqlBit> IsReceiveEnabled = new("is_receive_enabled");

        public static readonly Column<SqlBit> IsRetentionEnabled = new("is_retention_enabled");

        public static readonly Column<SqlBit> IsSchemaPublished = new("is_schema_published");

        public static readonly Column<SqlSmallInt> MaxReaders = new("max_readers");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ParentObjectId = new("parent_object_id");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> SchemaId = new("schema_id");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
