namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClauseAnd<TEndType> : ISelectClauseWithInto<TEndType>, IHideObjectMethods
    {
        ISelectClause<TEndType> And();
    }
}
