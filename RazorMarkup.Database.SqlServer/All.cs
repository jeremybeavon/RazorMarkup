using RazorMarkup.Database.SqlServer.Expressions.Functions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer
{
    public static class All
    {
        public static ISelectClauseWithDistinct<IEndSubquery<IEndAll>> Select()
        {
            throw new NotInExpressionException();
        }
    }
}
