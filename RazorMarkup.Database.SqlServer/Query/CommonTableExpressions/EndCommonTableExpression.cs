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
            Statement.Append((IEndCommonTableExpression input) => input.And());
            return new WithClause(Statement, EndClosure);
        }

        public IQueryOperand<IQueryOperatorGroupEnd<IEndQuery>> BeginOperatorGroup()
        {
            Statement.Append((IEndCommonTableExpression input) => input.BeginOperatorGroup());
            return new QueryOperatorGroupEnd<IEndQuery>(EndClosure, Statement.Expression).AsOperand().AsNextClause(Statement);
        }

        public ISelectClauseWithDistinct<IEndQuery> Select()
        {
            Statement.Append((IEndCommonTableExpression input) => input.Select());
            return new SelectClauseWithDistinct<IEndQuery>(EndClosure).AsNextClause(Statement);
        }
    }
}
