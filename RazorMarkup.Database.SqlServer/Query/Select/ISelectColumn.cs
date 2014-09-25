namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectColumn<TEndType> : ISelectClauseWithInto<TEndType>
    {
        ISelectClauseWithInto<TEndType> WithAlias(ColumnAlias columnAlias);
    }
}
