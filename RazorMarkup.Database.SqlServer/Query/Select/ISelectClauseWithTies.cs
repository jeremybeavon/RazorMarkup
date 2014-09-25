namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClauseWithTies<TEndType> : ISelectClause<TEndType>
    {
        ISelectClause<TEndType> WithTies();
    }
}
