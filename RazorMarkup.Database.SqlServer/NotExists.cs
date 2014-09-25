using RazorMarkup.Database.SqlServer.Expressions.Functions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer
{
    public static class NotExists
    {
        public static ISelectClauseWithDistinct<IEndSubquery<IEndExists>> Select()
        {
            throw new NotInExpressionException();
        }
    }
}
