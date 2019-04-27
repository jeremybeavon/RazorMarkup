using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class QueryOperatorGroupEnd<TEndType> : AbstractQueryStatement<QueryOperatorGroupBuilder, TEndType>,
        IQueryGroupEnd<TEndType>
    {
        public QueryOperatorGroupEnd(ExpressionBuilder expressionBuilder, TEndType endClosure)
            : base(new QueryOperatorGroupBuilder(expressionBuilder), endClosure)
        {
        }

        public IEndQueryGroup<TEndType> OperatorGroup()
        {
            Statement.Append((IQueryGroupEnd<TEndType> input) => input.OperatorGroup());
            return new EndQueryOperatorGroup<TEndType>(Statement, EndClosure);
        }

        public QueryOperand<IQueryGroupEnd<TEndType>> AsOperand()
        {
            return new QueryOperand<IQueryGroupEnd<TEndType>>(Statement.Operand, this);
        }

        public QueryOperatorGroupEnd<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
