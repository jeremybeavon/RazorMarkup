using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class MessageTypeXmlSchemaCollectionUsages
    {
        public static readonly ViewName ViewName = new("sys.message_type_xml_schema_collection_usages");

        public static readonly Column<SqlInt> MessageTypeId = new("message_type_id");

        public static readonly Column<SqlInt> XmlCollectionId = new("xml_collection_id");
    }
}
