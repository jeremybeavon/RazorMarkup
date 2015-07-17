using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class QueryOperatorGroupEnd<TEndType> : AbstractQueryStatement<QueryOperatorGroupBuilder, TEndType>,
        IQueryOperatorGroupEnd<TEndType>
    {
        public QueryOperatorGroupEnd(Expression initialExpression, TEndType endClosure)
            : base(new QueryOperatorGroupBuilder(initialExpression), endClosure)
        {
        }

        public IEndQueryOperatorGroup<TEndType> OperatorGroup()
        {
            Statement.Append((IQueryOperatorGroupEnd<TEndType> input) => input.OperatorGroup());
            return new EndQueryOperatorGroup<TEndType>(Statement, EndClosure);
        }

        public QueryOperand<IQueryOperatorGroupEnd<TEndType>> AsOperand()
        {
            return new QueryOperand<IQueryOperatorGroupEnd<TEndType>>(Statement.Operand, this);
        }
    }
}
