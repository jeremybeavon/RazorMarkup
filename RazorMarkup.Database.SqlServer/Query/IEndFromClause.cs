namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndFromClause<TEndType> : IHasEnd<TEndType>,
        IWhereClause<TEndType>,
        IGroupByClause<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IOffsetClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
