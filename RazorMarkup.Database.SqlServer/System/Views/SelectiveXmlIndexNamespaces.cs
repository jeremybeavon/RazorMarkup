using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SelectiveXmlIndexNamespaces
    {
        public static readonly ViewName ViewName = new ViewName("sys.selective_xml_index_namespaces");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlBit> IsDefaultUri = new Column<SqlBit>("is_default_uri");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlSysname> Prefix = new Column<SqlSysname>("prefix");
        
        public static readonly Column<SqlNVarchar> Uri = new Column<SqlNVarchar>("uri");
    }
}
