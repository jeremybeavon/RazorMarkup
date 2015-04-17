using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaFacets
    {
        public static readonly ViewName ViewName = new ViewName("sys.xml_schema_facets");
        
        public static readonly Column<SqlInt> FacetId = new Column<SqlInt>("facet_id");
        
        public static readonly Column<SqlBit> IsFixed = new Column<SqlBit>("is_fixed");
        
        public static readonly Column<SqlChar> Kind = new Column<SqlChar>("kind");
        
        public static readonly Column<SqlNVarchar> KindDesc = new Column<SqlNVarchar>("kind_desc");
        
        public static readonly Column<SqlNVarchar> Value = new Column<SqlNVarchar>("value");
        
        public static readonly Column<SqlInt> XmlComponentId = new Column<SqlInt>("xml_component_id");
    }
}
