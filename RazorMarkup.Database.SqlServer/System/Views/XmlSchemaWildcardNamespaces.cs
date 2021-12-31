using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaWildcardNamespaces
    {
        public static readonly ViewName ViewName = new("sys.xml_schema_wildcard_namespaces");

        public static readonly Column<SqlNVarchar> Namespace = new("namespace");

        public static readonly Column<SqlInt> XmlComponentId = new("xml_component_id");
    }
}
