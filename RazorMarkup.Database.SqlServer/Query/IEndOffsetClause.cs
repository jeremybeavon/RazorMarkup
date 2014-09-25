namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndOffsetClause<TEndType> : IHasEnd<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
