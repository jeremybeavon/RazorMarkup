using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ServerInfoOutput
    {
        public static readonly Column<SqlInt, ServerInfoAttribute> AttributeId =
            new Column<SqlInt, ServerInfoAttribute>("ATTRIBUTE_ID");

        public static readonly Column<SqlVarchar, ServerInfoAttributeNames> AttributeName =
            new Column<SqlVarchar, ServerInfoAttributeNames>("ATTRIBUTE_NAME");

        public static readonly Column<SqlVarchar> AttributeValue = new Column<SqlVarchar>("ATTRIBUTE_VALUE");
    }
}
