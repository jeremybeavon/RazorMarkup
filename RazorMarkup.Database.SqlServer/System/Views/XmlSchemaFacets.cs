using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaFacets
    {
        public static readonly ViewName ViewName = new("sys.xml_schema_facets");

        public static readonly Column<SqlInt> FacetId = new("facet_id");

        public static readonly Column<SqlBit> IsFixed = new("is_fixed");

        public static readonly Column<SqlChar> Kind = new("kind");

        public static readonly Column<SqlNVarchar> KindDesc = new("kind_desc");

        public static readonly Column<SqlNVarchar> Value = new("value");

        public static readonly Column<SqlInt> XmlComponentId = new("xml_component_id");
    }
}
