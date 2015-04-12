using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    internal class OrderByCollate<TEndType> : OrderByAscendingOrDescending<TEndType>, IOrderByCollate<TEndType>,
        IClauseStart<IOrderByCollate<TEndType>>
    {
        public OrderByCollate(OrderByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public OrderByCollate(Expression initialExpression, Expression<Func<object>> expression, TEndType endClosure)
            : base(new OrderByClauseBuilder(initialExpression, expression), endClosure)
        {
        }

        public IOrderByAscendingOrDescending<TEndType> Collate(CollationName collationName)
        {
            Statement.LastColumn.CollationName = collationName.ToSqlString();
            Statement.Append((IOrderByCollate<TEndType> input) => input.Collate(null), collationName);
            return this;
        }

        public IOrderByCollate<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
