using System;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    internal class OrderByAscendingOrDescending<TEndType> : OrderByAnd<TEndType>, IOrderByAscendingOrDescending<TEndType>
    {
        public OrderByAscendingOrDescending(OrderByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IOrderByAnd<TEndType> Ascending()
        {
            Statement.LastColumn.IsAscending = true;
            return this;
        }

        public IOrderByAnd<TEndType> Descending()
        {
            Statement.LastColumn.IsAscending = false;
            return this;
        }
    }
}
