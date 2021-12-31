using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Synonyms
    {
        public static readonly ViewName ViewName = new("sys.synonyms");

        public static readonly Column<SqlNVarchar> BaseObjectName = new("base_object_name");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlBit> IsMsShipped = new("is_ms_shipped");

        public static readonly Column<SqlBit> IsPublished = new("is_published");

        public static readonly Column<SqlBit> IsSchemaPublished = new("is_schema_published");

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
