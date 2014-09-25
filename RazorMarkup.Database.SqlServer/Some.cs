using RazorMarkup.Database.SqlServer.Expressions.Functions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer
{
    public static class Some
    {
        public static ISelectClauseWithDistinct<IEndSubquery<IEndSome>> Select()
        {
            throw new NotInExpressionException();
        }
    }
}
