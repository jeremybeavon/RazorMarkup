using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnXmlSchemaCollectionUsages
    {
        public static readonly ViewName ViewName = new ViewName("sys.column_xml_schema_collection_usages");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
    }
}
