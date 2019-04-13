using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class EndCommonTableExpression<TEndType> : AbstractCommonTableExpression<TEndType>, IEndCommonTableExpression<TEndType>
    {
        public EndCommonTableExpression(WithClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IWithClause<TEndType> And()
        {
            Statement.Append((IEndCommonTableExpression<TEndType> input) => input.And());
            return new WithClause<TEndType>(Statement, EndClosure);
        }

        public IQueryOperand<IQueryGroupEnd<TEndType>> BeginQueryGroup()
        {
            Statement.Append((IEndCommonTableExpression<TEndType> input) => input.BeginQueryGroup());
            return new QueryOperatorGroupEnd<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement).AsOperand();
        }

        public ISelectClauseWithDistinct<TEndType> Select()
        {
            Statement.Append((IEndCommonTableExpression<TEndType> input) => input.Select());
            return new SelectClauseWithDistinct<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }
    }
}
