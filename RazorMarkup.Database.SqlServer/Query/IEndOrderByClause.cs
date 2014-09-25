namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndOrderByClause<TEndType> : IHasEnd<TEndType>,
        IOffsetClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
