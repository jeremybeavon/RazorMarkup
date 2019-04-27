using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class CommonTableExpressionQuery<TEndType> : AbstractCommonTableExpression<TEndType>, IQueryOperand<TEndType>
    {
        public CommonTableExpressionQuery(WithClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ISelectClauseWithDistinct<TEndType> Select()
        {
            Statement.Append((IQueryOperand<TEndType> input) => input.Select());
            //CommonTableExpressionEnd<TEndType> end = new CommonTableExpressionEnd<TEndType>(Statement, EndClosure);
            return new SelectClauseWithDistinct<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement.LastExpression);
        }

        public IQueryOperand<IQueryGroupEnd<TEndType>> BeginQueryGroup()
        {
            Statement.Append((IQueryOperand<TEndType> input) => input.BeginQueryGroup());
            //ICommonTableExpressionEnd<TEndType> end = new CommonTableExpressionEnd<TEndType>(Statement, EndClosure);
            return new QueryOperatorGroupEnd<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement.LastExpression).AsOperand();
        }
    }
}
