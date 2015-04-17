using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaComponentPlacements
    {
        public static readonly ViewName ViewName = new ViewName("sys.xml_schema_component_placements");
        
        public static readonly Column<SqlNVarchar> DefaultValue = new Column<SqlNVarchar>("default_value");
        
        public static readonly Column<SqlBit> IsDefaultFixed = new Column<SqlBit>("is_default_fixed");
        
        public static readonly Column<SqlInt> MaxOccurences = new Column<SqlInt>("max_occurences");
        
        public static readonly Column<SqlInt> MinOccurences = new Column<SqlInt>("min_occurences");
        
        public static readonly Column<SqlInt> PlacedXmlComponentId = new Column<SqlInt>("placed_xml_component_id");
        
        public static readonly Column<SqlInt> PlacementId = new Column<SqlInt>("placement_id");
        
        public static readonly Column<SqlInt> XmlComponentId = new Column<SqlInt>("xml_component_id");
    }
}
