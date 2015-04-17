using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaModelGroups
    {
        public static readonly ViewName ViewName = new ViewName("sys.xml_schema_model_groups");
        
        public static readonly Column<SqlInt> BaseXmlComponentId = new Column<SqlInt>("base_xml_component_id");
        
        public static readonly Column<SqlChar> Compositor = new Column<SqlChar>("compositor");
        
        public static readonly Column<SqlNVarchar> CompositorDesc = new Column<SqlNVarchar>("compositor_desc");
        
        public static readonly Column<SqlChar> Derivation = new Column<SqlChar>("derivation");
        
        public static readonly Column<SqlNVarchar> DerivationDesc = new Column<SqlNVarchar>("derivation_desc");
        
        public static readonly Column<SqlBit> IsQualified = new Column<SqlBit>("is_qualified");
        
        public static readonly Column<SqlChar> Kind = new Column<SqlChar>("kind");
        
        public static readonly Column<SqlNVarchar> KindDesc = new Column<SqlNVarchar>("kind_desc");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> ScopingXmlComponentId = new Column<SqlInt>("scoping_xml_component_id");
        
        public static readonly Column<SqlChar> SymbolSpace = new Column<SqlChar>("symbol_space");
        
        public static readonly Column<SqlNVarchar> SymbolSpaceDesc = new Column<SqlNVarchar>("symbol_space_desc");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
        
        public static readonly Column<SqlInt> XmlComponentId = new Column<SqlInt>("xml_component_id");
        
        public static readonly Column<SqlInt> XmlNamespaceId = new Column<SqlInt>("xml_namespace_id");
    }
}
