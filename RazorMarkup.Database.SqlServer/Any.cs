using RazorMarkup.Database.SqlServer.Expressions.Functions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer
{
    public static class Any
    {
        public static ISelectClauseWithDistinct<IEndSubquery<IEndAny>> Select()
        {
            throw new NotInExpressionException();
        }
    }
}
