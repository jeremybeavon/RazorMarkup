using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class EndCommonTableExpression : AbstractCommonTableExpression, IEndCommonTableExpression
    {
        public EndCommonTableExpression(WithClauseBuilder statement, IEndQuery endClosure)
            : base(statement, endClosure)
        {
        }

        public IWithClause And()
        {
            return new WithClause(Statement, EndClosure);
        }

        public IQueryOperand<IQueryOperatorGroupEnd<IEndQuery>> BeginOperatorGroup()
        {
            return new QueryOperatorGroupEnd<IEndQuery>(EndClosure, Statement.Expression).AsOperand().AsNextClause(Statement);
        }

        public ISelectClauseWithDistinct<IEndQuery> Select()
        {
            return new SelectClauseWithDistinct<IEndQuery>(EndClosure).AsNextClause(Statement);
        }
    }
}
