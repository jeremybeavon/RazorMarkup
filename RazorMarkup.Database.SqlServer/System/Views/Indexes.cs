using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Indexes
    {
        public static readonly ViewName ViewName = new("sys.indexes");

        public static readonly Column<SqlBit> AllowPageLocks = new("allow_page_locks");

        public static readonly Column<SqlBit> AllowRowLocks = new("allow_row_locks");

        public static readonly Column<SqlInt> DataSpaceId = new("data_space_id");

        public static readonly Column<SqlTinyInt> FillFactor = new("fill_factor");

        public static readonly Column<SqlNVarchar> FilterDefinition = new("filter_definition");

        public static readonly Column<SqlBit> HasFilter = new("has_filter");

        public static readonly Column<SqlBit> IgnoreDupKey = new("ignore_dup_key");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlBit> IsDisabled = new("is_disabled");

        public static readonly Column<SqlBit> IsHypothetical = new("is_hypothetical");

        public static readonly Column<SqlBit> IsPadded = new("is_padded");

        public static readonly Column<SqlBit> IsPrimaryKey = new("is_primary_key");

        public static readonly Column<SqlBit> IsUnique = new("is_unique");

        public static readonly Column<SqlBit> IsUniqueConstraint = new("is_unique_constraint");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
