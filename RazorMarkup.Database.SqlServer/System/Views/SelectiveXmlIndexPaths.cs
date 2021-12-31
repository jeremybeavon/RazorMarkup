using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SelectiveXmlIndexPaths
    {
        public static readonly ViewName ViewName = new("sys.selective_xml_index_paths");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlBit> IsNode = new("is_node");

        public static readonly Column<SqlBit> IsSingleton = new("is_singleton");

        public static readonly Column<SqlBit> IsXqueryMaxLengthInferred = new("is_xquery_max_length_inferred");

        public static readonly Column<SqlBit> IsXqueryTypeInferred = new("is_xquery_type_inferred");

        public static readonly Column<SqlSmallInt> MaxLength = new("max_length");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlNVarchar> Path = new("path");

        public static readonly Column<SqlInt> PathId = new("path_id");

        public static readonly Column<SqlTinyInt> PathType = new("path_type");

        public static readonly Column<SqlNVarchar> PathTypeDesc = new("path_type_desc");

        public static readonly Column<SqlTinyInt> Precision = new("precision");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlTinyInt> SystemTypeId = new("system_type_id");

        public static readonly Column<SqlTinyInt> UserTypeId = new("user_type_id");

        public static readonly Column<SqlInt> XmlComponentId = new("xml_component_id");

        public static readonly Column<SqlInt> XqueryMaxLength = new("xquery_max_length");

        public static readonly Column<SqlNVarchar> XqueryTypeDescription = new("xquery_type_description");
    }
}
