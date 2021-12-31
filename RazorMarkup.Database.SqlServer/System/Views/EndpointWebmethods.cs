using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class EndpointWebmethods
    {
        public static readonly ViewName ViewName = new("sys.endpoint_webmethods");

        public static readonly Column<SqlInt> EndpointId = new("endpoint_id");

        public static readonly Column<SqlNVarchar> MethodAlias = new("method_alias");

        public static readonly Column<SqlNVarchar> Namespace = new("namespace");

        public static readonly Column<SqlNVarchar> ObjectName = new("object_name");

        public static readonly Column<SqlTinyInt> ResultFormat = new("result_format");

        public static readonly Column<SqlNVarchar> ResultFormatDesc = new("result_format_desc");

        public static readonly Column<SqlTinyInt> ResultSchema = new("result_schema");

        public static readonly Column<SqlNVarchar> ResultSchemaDesc = new("result_schema_desc");
    }
}
