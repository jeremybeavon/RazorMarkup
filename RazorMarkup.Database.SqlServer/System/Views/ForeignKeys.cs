using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ForeignKeys
    {
        public static readonly ViewName ViewName = new("sys.foreign_keys");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlTinyInt> DeleteReferentialAction = new("delete_referential_action");

        public static readonly Column<SqlNVarchar> DeleteReferentialActionDesc = new("delete_referential_action_desc");

        public static readonly Column<SqlBit> IsDisabled = new("is_disabled");

        public static readonly Column<SqlBit> IsMsShipped = new("is_ms_shipped");

        public static readonly Column<SqlBit> IsNotForReplication = new("is_not_for_replication");

        public static readonly Column<SqlBit> IsNotTrusted = new("is_not_trusted");

        public static readonly Column<SqlBit> IsPublished = new("is_published");

        public static readonly Column<SqlBit> IsSchemaPublished = new("is_schema_published");

        public static readonly Column<SqlBit> IsSystemNamed = new("is_system_named");

        public static readonly Column<SqlInt> KeyIndexId = new("key_index_id");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ParentObjectId = new("parent_object_id");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlInt> ReferencedObjectId = new("referenced_object_id");

        public static readonly Column<SqlInt> SchemaId = new("schema_id");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");

        public static readonly Column<SqlTinyInt> UpdateReferentialAction = new("update_referential_action");

        public static readonly Column<SqlNVarchar> UpdateReferentialActionDesc = new("update_referential_action_desc");
    }
}
