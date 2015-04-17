using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class XmlSchemaCollections
    {
        public static readonly ViewName ViewName = new ViewName("sys.xml_schema_collections");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlInt> SchemaId = new Column<SqlInt>("schema_id");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
    }
}
