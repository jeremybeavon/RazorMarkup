using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class TriggerFunctions
    {
        public static SqlVarbinary ColumnsUpdated()
        {
            throw new NotInExpressionException();
        }

        public static SqlXml EventData()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt TriggerNestLevel(SqlInt objectId, Text triggerType, Text triggerEventCategory)
        {
            throw new NotInExpressionException();
        }

        public static bool Update(ColumnName columnName)
        {
            throw new NotInExpressionException();
        }
    }
}
