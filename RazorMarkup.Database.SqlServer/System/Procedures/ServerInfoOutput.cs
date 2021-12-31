using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ServerInfoOutput
    {
        public static readonly Column<SqlInt, ServerInfoAttribute> AttributeId =
            new("ATTRIBUTE_ID");

        public static readonly Column<SqlVarchar, ServerInfoAttributeNames> AttributeName =
            new("ATTRIBUTE_NAME");

        public static readonly Column<SqlVarchar> AttributeValue = new("ATTRIBUTE_VALUE");
    }
}
