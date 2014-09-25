using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    internal class OrderByAnd<TEndType> : EndOrderByClause<TEndType>, IOrderByAnd<TEndType>
    {
        public OrderByAnd(OrderByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IOrderByWithCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            Statement.Columns.Add(new OrderByColumnBuilder(expression));
            return new OrderByWithCollate<TEndType>(Statement, EndClosure);
        }
    }
}
