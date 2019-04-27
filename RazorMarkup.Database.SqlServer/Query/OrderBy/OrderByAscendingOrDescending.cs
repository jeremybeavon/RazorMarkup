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
            Statement.Append((IOrderByAscendingOrDescending<TEndType> input) => input.Ascending());
            return this;
        }

        public IOrderByAnd<TEndType> Descending()
        {
            Statement.LastColumn.IsAscending = false;
            Statement.Append((IOrderByAscendingOrDescending<TEndType> input) => input.Descending());
            return this;
        }
    }
}
