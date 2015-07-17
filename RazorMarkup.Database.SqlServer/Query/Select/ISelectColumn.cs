namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectColumn<TEndType> : ISelectClauseAnd<TEndType>
    {
        ISelectClauseAnd<TEndType> As(ColumnAlias columnAlias);
    }
}
