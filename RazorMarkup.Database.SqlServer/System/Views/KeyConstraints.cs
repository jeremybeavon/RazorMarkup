using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class KeyConstraints
    {
        public static readonly ViewName ViewName = new ViewName("sys.key_constraints");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlBit> IsMsShipped = new Column<SqlBit>("is_ms_shipped");
        
        public static readonly Column<SqlBit> IsPublished = new Column<SqlBit>("is_published");
        
        public static readonly Column<SqlBit> IsSchemaPublished = new Column<SqlBit>("is_schema_published");
        
        public static readonly Column<SqlBit> IsSystemNamed = new Column<SqlBit>("is_system_named");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> ParentObjectId = new Column<SqlInt>("parent_object_id");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> SchemaId = new Column<SqlInt>("schema_id");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
        
        public static readonly Column<SqlInt> UniqueIndexId = new Column<SqlInt>("unique_index_id");
    }
}
