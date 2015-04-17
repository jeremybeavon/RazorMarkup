using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class EndpointWebmethods
    {
        public static readonly ViewName ViewName = new ViewName("sys.endpoint_webmethods");
        
        public static readonly Column<SqlInt> EndpointId = new Column<SqlInt>("endpoint_id");
        
        public static readonly Column<SqlNVarchar> MethodAlias = new Column<SqlNVarchar>("method_alias");
        
        public static readonly Column<SqlNVarchar> Namespace = new Column<SqlNVarchar>("namespace");
        
        public static readonly Column<SqlNVarchar> ObjectName = new Column<SqlNVarchar>("object_name");
        
        public static readonly Column<SqlTinyInt> ResultFormat = new Column<SqlTinyInt>("result_format");
        
        public static readonly Column<SqlNVarchar> ResultFormatDesc = new Column<SqlNVarchar>("result_format_desc");
        
        public static readonly Column<SqlTinyInt> ResultSchema = new Column<SqlTinyInt>("result_schema");
        
        public static readonly Column<SqlNVarchar> ResultSchemaDesc = new Column<SqlNVarchar>("result_schema_desc");
    }
}
