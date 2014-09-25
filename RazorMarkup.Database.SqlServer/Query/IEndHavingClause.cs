namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndHavingClause<TEndType> : IHasEnd<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IOffsetClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
