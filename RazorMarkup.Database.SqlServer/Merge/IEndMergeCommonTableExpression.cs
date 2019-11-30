using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IEndMergeCommonTableExpression :
        IEndCommonTableExpression<IEndMergeCommonTableExpression>,
        IMergeClause
    {
    }
}
