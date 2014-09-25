namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndForClause<TEndType> : IHasEnd<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
