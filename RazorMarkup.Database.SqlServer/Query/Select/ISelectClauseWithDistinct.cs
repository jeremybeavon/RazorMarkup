namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClauseWithDistinct<TEndType> : ISelectClauseWithTop<TEndType>
    {
        ISelectClauseWithTop<TEndType> All();

        ISelectClauseWithTop<TEndType> Distinct();
    }
}
