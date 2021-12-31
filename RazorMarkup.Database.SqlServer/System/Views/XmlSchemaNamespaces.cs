using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaNamespaces
    {
        public static readonly ViewName ViewName = new("sys.xml_schema_namespaces");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> XmlCollectionId = new("xml_collection_id");

        public static readonly Column<SqlInt> XmlNamespaceId = new("xml_namespace_id");
    }
}
