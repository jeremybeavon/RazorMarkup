using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    internal class CommonTableExpression<TEndType> : AbstractCommonTableExpression<TEndType>, ICommonTableExpression<TEndType>,
        IClauseStart<ICommonTableExpression<TEndType>>
    {
        public CommonTableExpression(WithClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IQueryOperand<TEndType> As()
        {
            Statement.Append((ICommonTableExpression<TEndType> input) => input.As());
            return new CommonTableExpressionQuery<TEndType>(Statement, EndClosure);
        }

        public ICommonTableExpression<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
