using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ParameterXmlSchemaCollectionUsages
    {
        public static readonly ViewName ViewName = new("sys.parameter_xml_schema_collection_usages");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ParameterId = new("parameter_id");

        public static readonly Column<SqlInt> XmlCollectionId = new("xml_collection_id");
    }
}
