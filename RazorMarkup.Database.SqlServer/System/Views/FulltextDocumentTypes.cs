using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextDocumentTypes
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_document_types");
        
        public static readonly Column<SqlUniqueIdentifier> ClassId = new Column<SqlUniqueIdentifier>("class_id");
        
        public static readonly Column<SqlNVarchar> DocumentType = new Column<SqlNVarchar>("document_type");
        
        public static readonly Column<SqlNVarchar> Manufacturer = new Column<SqlNVarchar>("manufacturer");
        
        public static readonly Column<SqlNVarchar> Path = new Column<SqlNVarchar>("path");
        
        public static readonly Column<SqlNVarchar> Version = new Column<SqlNVarchar>("version");
    }
}
