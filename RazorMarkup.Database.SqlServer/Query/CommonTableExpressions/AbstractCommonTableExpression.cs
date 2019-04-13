using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal abstract class AbstractCommonTableExpression<TEndType> : AbstractQueryStatement<WithClauseBuilder, TEndType>
    {
        protected AbstractCommonTableExpression(WithClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }
    }
}
