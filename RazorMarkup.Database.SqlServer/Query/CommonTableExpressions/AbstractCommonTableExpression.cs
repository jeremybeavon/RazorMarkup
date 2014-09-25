using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal abstract class AbstractCommonTableExpression : AbstractQueryStatement<WithClauseBuilder, IEndQuery>
    {
        protected AbstractCommonTableExpression(WithClauseBuilder statement, IEndQuery endClosure)
            : base(statement, endClosure)
        {
        }
    }
}
