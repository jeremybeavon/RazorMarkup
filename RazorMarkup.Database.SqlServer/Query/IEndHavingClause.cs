namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndHavingClause<TEndType> : IHasEnd<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
