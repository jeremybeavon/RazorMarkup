using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ForeignKeys
    {
        public static readonly ViewName ViewName = new ViewName("sys.foreign_keys");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlTinyInt> DeleteReferentialAction = new Column<SqlTinyInt>("delete_referential_action");
        
        public static readonly Column<SqlNVarchar> DeleteReferentialActionDesc = new Column<SqlNVarchar>("delete_referential_action_desc");
        
        public static readonly Column<SqlBit> IsDisabled = new Column<SqlBit>("is_disabled");
        
        public static readonly Column<SqlBit> IsMsShipped = new Column<SqlBit>("is_ms_shipped");
        
        public static readonly Column<SqlBit> IsNotForReplication = new Column<SqlBit>("is_not_for_replication");
        
        public static readonly Column<SqlBit> IsNotTrusted = new Column<SqlBit>("is_not_trusted");
        
        public static readonly Column<SqlBit> IsPublished = new Column<SqlBit>("is_published");
        
        public static readonly Column<SqlBit> IsSchemaPublished = new Column<SqlBit>("is_schema_published");
        
        public static readonly Column<SqlBit> IsSystemNamed = new Column<SqlBit>("is_system_named");
        
        public static readonly Column<SqlInt> KeyIndexId = new Column<SqlInt>("key_index_id");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> ParentObjectId = new Column<SqlInt>("parent_object_id");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> ReferencedObjectId = new Column<SqlInt>("referenced_object_id");
        
        public static readonly Column<SqlInt> SchemaId = new Column<SqlInt>("schema_id");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
        
        public static readonly Column<SqlTinyInt> UpdateReferentialAction = new Column<SqlTinyInt>("update_referential_action");
        
        public static readonly Column<SqlNVarchar> UpdateReferentialActionDesc = new Column<SqlNVarchar>("update_referential_action_desc");
    }
}
