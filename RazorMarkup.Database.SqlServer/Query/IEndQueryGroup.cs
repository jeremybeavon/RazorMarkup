namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndQueryGroup<TEndType> : IHasEnd<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IOffsetClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
