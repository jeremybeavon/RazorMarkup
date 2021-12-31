using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SelectiveXmlIndexNamespaces
    {
        public static readonly ViewName ViewName = new("sys.selective_xml_index_namespaces");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlBit> IsDefaultUri = new("is_default_uri");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlSysname> Prefix = new("prefix");

        public static readonly Column<SqlNVarchar> Uri = new("uri");
    }
}
