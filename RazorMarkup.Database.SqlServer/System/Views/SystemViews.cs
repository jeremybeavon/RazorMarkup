using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemViews
    {
        public static readonly ViewName ViewName = new("sys.system_views");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlBit> HasOpaqueMetadata = new("has_opaque_metadata");

        public static readonly Column<SqlBit> HasReplicationFilter = new("has_replication_filter");

        public static readonly Column<SqlBit> HasUncheckedAssemblyData = new("has_unchecked_assembly_data");

        public static readonly Column<SqlBit> IsDateCorrelationView = new("is_date_correlation_view");

        public static readonly Column<SqlBit> IsMsShipped = new("is_ms_shipped");

        public static readonly Column<SqlBit> IsPublished = new("is_published");

        public static readonly Column<SqlBit> IsReplicated = new("is_replicated");

        public static readonly Column<SqlBit> IsSchemaPublished = new("is_schema_published");

        public static readonly Column<SqlBit> IsTrackedByCdc = new("is_tracked_by_cdc");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ParentObjectId = new("parent_object_id");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> SchemaId = new("schema_id");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");

        public static readonly Column<SqlBit> WithCheckOption = new("with_check_option");
    }
}
