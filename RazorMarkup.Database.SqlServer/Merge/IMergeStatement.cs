using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeStatement : IWithClause<ICommonTableExpressionEnd<IEndMergeCommonTableExpression>>, IMergeClause
    {
    }
}
