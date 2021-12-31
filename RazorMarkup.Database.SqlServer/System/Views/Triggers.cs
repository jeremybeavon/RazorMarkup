using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Triggers
    {
        public static readonly ViewName ViewName = new("sys.triggers");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlBit> IsDisabled = new("is_disabled");

        public static readonly Column<SqlBit> IsInsteadOfTrigger = new("is_instead_of_trigger");

        public static readonly Column<SqlBit> IsMsShipped = new("is_ms_shipped");

        public static readonly Column<SqlBit> IsNotForReplication = new("is_not_for_replication");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlTinyInt> ParentClass = new("parent_class");

        public static readonly Column<SqlNVarchar> ParentClassDesc = new("parent_class_desc");

        public static readonly Column<SqlInt> ParentId = new("parent_id");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
