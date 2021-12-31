using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextDocumentTypes
    {
        public static readonly ViewName ViewName = new("sys.fulltext_document_types");

        public static readonly Column<SqlUniqueIdentifier> ClassId = new("class_id");

        public static readonly Column<SqlNVarchar> DocumentType = new("document_type");

        public static readonly Column<SqlNVarchar> Manufacturer = new("manufacturer");

        public static readonly Column<SqlNVarchar> Path = new("path");

        public static readonly Column<SqlNVarchar> Version = new("version");
    }
}
