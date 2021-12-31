using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnXmlSchemaCollectionUsages
    {
        public static readonly ViewName ViewName = new("sys.column_xml_schema_collection_usages");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> XmlCollectionId = new("xml_collection_id");
    }
}
