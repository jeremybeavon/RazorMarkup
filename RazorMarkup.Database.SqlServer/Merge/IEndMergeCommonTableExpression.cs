using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IEndMergeCommonTableExpression : IMergeClause
    {
        IWithClause<ICommonTableExpressionEndMerge> And();
    }
}
