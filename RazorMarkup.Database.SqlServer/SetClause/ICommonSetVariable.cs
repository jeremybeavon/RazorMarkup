namespace RazorMarkup.Database.SqlServer.SetClause
{
    public interface ICommonSetVariable<TSetClauseAnd, TSetValue> : ICommonSetValue<TSetClauseAnd>
    {
        TSetValue Equals(ColumnName columnName);
    }
}
