using RazorMarkup.Database.SqlServer.Query.CommonTableExpressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IQueryStatements :
        IWithClause<ICommonTableExpressionEnd<IEndCommonTableExpression>>,
        IQueryOperand<IEndQuery>
    {
    }
}
