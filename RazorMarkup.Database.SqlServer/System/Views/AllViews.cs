using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AllViews
    {
        public static readonly ViewName ViewName = new ViewName("sys.all_views");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlBit> HasOpaqueMetadata = new Column<SqlBit>("has_opaque_metadata");
        
        public static readonly Column<SqlBit> HasReplicationFilter = new Column<SqlBit>("has_replication_filter");
        
        public static readonly Column<SqlBit> HasUncheckedAssemblyData = new Column<SqlBit>("has_unchecked_assembly_data");
        
        public static readonly Column<SqlBit> IsDateCorrelationView = new Column<SqlBit>("is_date_correlation_view");
        
        public static readonly Column<SqlBit> IsMsShipped = new Column<SqlBit>("is_ms_shipped");
        
        public static readonly Column<SqlBit> IsPublished = new Column<SqlBit>("is_published");
        
        public static readonly Column<SqlBit> IsReplicated = new Column<SqlBit>("is_replicated");
        
        public static readonly Column<SqlBit> IsSchemaPublished = new Column<SqlBit>("is_schema_published");
        
        public static readonly Column<SqlBit> IsTrackedByCdc = new Column<SqlBit>("is_tracked_by_cdc");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> ParentObjectId = new Column<SqlInt>("parent_object_id");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> SchemaId = new Column<SqlInt>("schema_id");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
        
        public static readonly Column<SqlBit> WithCheckOption = new Column<SqlBit>("with_check_option");
    }
}
