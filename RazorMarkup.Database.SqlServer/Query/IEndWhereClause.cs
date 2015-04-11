namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndWhereClause<TEndType> : IHasEnd<TEndType>,
        IGroupByClause<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
