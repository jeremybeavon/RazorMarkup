using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaNamespaces
    {
        public static readonly ViewName ViewName = new ViewName("sys.xml_schema_namespaces");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
        
        public static readonly Column<SqlInt> XmlNamespaceId = new Column<SqlInt>("xml_namespace_id");
    }
}
