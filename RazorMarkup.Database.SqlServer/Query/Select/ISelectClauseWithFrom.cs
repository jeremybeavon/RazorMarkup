namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClauseWithFrom<TEndType> : IHasEnd<TEndType>
    {
        IFromClause<TEndType> From();
    }
}
