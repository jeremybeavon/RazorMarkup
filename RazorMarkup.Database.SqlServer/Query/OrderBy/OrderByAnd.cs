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

        public IOrderByCollate<TEndType> And(Expression<Func<object>> expression)
        {
            Statement.Columns.Add(new OrderByColumnBuilder(expression));
            Statement.Append((IOrderByAnd<TEndType> input) => input.And(null), expression);
            return new OrderByCollate<TEndType>(Statement, EndClosure);
        }
    }
}
