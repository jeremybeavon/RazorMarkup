using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    internal class OrderByWithCollate<TEndType> : OrderByAscendingOrDescending<TEndType>, IOrderByWithCollate<TEndType>,
        IClauseStart<IOrderByWithCollate<TEndType>>
    {
        public OrderByWithCollate(OrderByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public OrderByWithCollate(Expression<Func<object>> expression, TEndType endClosure)
            : base(new OrderByClauseBuilder(expression), endClosure)
        {
        }

        public IOrderByAscendingOrDescending<TEndType> WithCollate(CollationName collationName)
        {
            Statement.LastColumn.CollationName = collationName.ToSqlString();
            return this;
        }

        public IOrderByWithCollate<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
