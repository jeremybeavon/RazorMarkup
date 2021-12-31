using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaAttributes
    {
        public static readonly ViewName ViewName = new("sys.xml_schema_attributes");

        public static readonly Column<SqlInt> BaseXmlComponentId = new("base_xml_component_id");

        public static readonly Column<SqlNVarchar> DefaultValue = new("default_value");

        public static readonly Column<SqlChar> Derivation = new("derivation");

        public static readonly Column<SqlNVarchar> DerivationDesc = new("derivation_desc");

        public static readonly Column<SqlBit> IsDefaultFixed = new("is_default_fixed");

        public static readonly Column<SqlBit> IsQualified = new("is_qualified");

        public static readonly Column<SqlChar> Kind = new("kind");

        public static readonly Column<SqlNVarchar> KindDesc = new("kind_desc");

        public static readonly Column<SqlBit> MustBeQualified = new("must_be_qualified");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> ScopingXmlComponentId = new("scoping_xml_component_id");

        public static readonly Column<SqlChar> SymbolSpace = new("symbol_space");

        public static readonly Column<SqlNVarchar> SymbolSpaceDesc = new("symbol_space_desc");

        public static readonly Column<SqlInt> XmlCollectionId = new("xml_collection_id");

        public static readonly Column<SqlInt> XmlComponentId = new("xml_component_id");

        public static readonly Column<SqlInt> XmlNamespaceId = new("xml_namespace_id");
    }
}
