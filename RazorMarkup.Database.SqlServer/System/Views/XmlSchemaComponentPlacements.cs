using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaComponentPlacements
    {
        public static readonly ViewName ViewName = new("sys.xml_schema_component_placements");

        public static readonly Column<SqlNVarchar> DefaultValue = new("default_value");

        public static readonly Column<SqlBit> IsDefaultFixed = new("is_default_fixed");

        public static readonly Column<SqlInt> MaxOccurences = new("max_occurences");

        public static readonly Column<SqlInt> MinOccurences = new("min_occurences");

        public static readonly Column<SqlInt> PlacedXmlComponentId = new("placed_xml_component_id");

        public static readonly Column<SqlInt> PlacementId = new("placement_id");

        public static readonly Column<SqlInt> XmlComponentId = new("xml_component_id");
    }
}
