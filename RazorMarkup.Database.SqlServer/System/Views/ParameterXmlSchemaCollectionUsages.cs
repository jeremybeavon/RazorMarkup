using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ParameterXmlSchemaCollectionUsages
    {
        public static readonly ViewName ViewName = new ViewName("sys.parameter_xml_schema_collection_usages");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> ParameterId = new Column<SqlInt>("parameter_id");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
    }
}
