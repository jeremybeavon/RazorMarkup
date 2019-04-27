namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndGroupByClause<TEndType> : IHasEnd<TEndType>,
        IHavingClause<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
