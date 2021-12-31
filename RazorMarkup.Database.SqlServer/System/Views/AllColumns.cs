using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AllColumns
    {
        public static readonly ViewName ViewName = new("sys.all_columns");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> DefaultObjectId = new("default_object_id");

        public static readonly Column<SqlBit> IsAnsiPadded = new("is_ansi_padded");

        public static readonly Column<SqlBit> IsColumnSet = new("is_column_set");

        public static readonly Column<SqlBit> IsComputed = new("is_computed");

        public static readonly Column<SqlBit> IsDtsReplicated = new("is_dts_replicated");

        public static readonly Column<SqlBit> IsFilestream = new("is_filestream");

        public static readonly Column<SqlBit> IsIdentity = new("is_identity");

        public static readonly Column<SqlBit> IsMergePublished = new("is_merge_published");

        public static readonly Column<SqlBit> IsNonSqlSubscribed = new("is_non_sql_subscribed");

        public static readonly Column<SqlBit> IsNullable = new("is_nullable");

        public static readonly Column<SqlBit> IsReplicated = new("is_replicated");

        public static readonly Column<SqlBit> IsRowguidcol = new("is_rowguidcol");

        public static readonly Column<SqlBit> IsSparse = new("is_sparse");

        public static readonly Column<SqlBit> IsXmlDocument = new("is_xml_document");

        public static readonly Column<SqlSmallInt> MaxLength = new("max_length");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlTinyInt> Precision = new("precision");

        public static readonly Column<SqlInt> RuleObjectId = new("rule_object_id");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlTinyInt> SystemTypeId = new("system_type_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");

        public static readonly Column<SqlInt> XmlCollectionId = new("xml_collection_id");
    }
}
