using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class CursorFunctions
    {
        public static SqlInt CursorRows()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt FetchStatus()
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallInt CursorStatus(Text source, Text name) // Enum
        {
            throw new NotInExpressionException();
        }
    }
}
