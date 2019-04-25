using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class EndCommonTableExpression : AbstractCommonTableExpression<IEndQuery>, IEndCommonTableExpression
    {
        public EndCommonTableExpression(WithClauseBuilder statement, IEndQuery endClosure)
            : base(statement, endClosure)
        {
        }

        public IWithClause<ICommonTableExpressionEnd<IEndCommonTableExpression>> And()
        {
            Statement.Append((IEndCommonTableExpression input) => input.And());
            return new WithClause<ICommonTableExpressionEnd<IEndCommonTableExpression>>(
                Statement,
                new CommonTableExpressionEnd(Statement, EndClosure));
        }

        public IQueryOperand<IQueryGroupEnd<IEndQuery>> BeginQueryGroup()
        {
            Statement.Append((IEndCommonTableExpression input) => input.BeginQueryGroup());
            return new QueryOperatorGroupEnd<IEndQuery>(ExpressionBuilder, EndClosure).AsNextClause(Statement).AsOperand();
        }

        public ISelectClauseWithDistinct<IEndQuery> Select()
        {
            Statement.Append((IEndCommonTableExpression input) => input.Select());
            return new SelectClauseWithDistinct<IEndQuery>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }
    }
}
